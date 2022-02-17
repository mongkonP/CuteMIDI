using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CuteMIDI
{
    public partial class frmCuteMIDI : Form
    {
        public frmCuteMIDI()
        {
            InitializeComponent();
        }
         int sngDel =0, sngRun =0 ;
        string PathKARA;
         double startCounter;//= DateTime.Now.TimeOfDay.TotalSeconds
         int maxThread = 10;
        private void button1_Click(object sender, EventArgs e)
        {
            Text = "Adding Database";
            using (FolderBrowserDialog fb = new FolderBrowserDialog
            {
                RootFolder = System.Environment.SpecialFolder.MyComputer,
                ShowNewFolderButton = false
            })
            {
                fb.ShowDialog();
                textBox1.Text = fb.SelectedPath;
                PathKARA = textBox1.Text;
                string PathData = "";
                if (textBox1.Text.ToUpper().EndsWith("\\DATA"))
                {
                    PathData = textBox1.Text.ToUpper();
                }
                else
                {
                    PathData = textBox1.Text.ToUpper() + "\\DATA";
                }
                if (!System.IO.Directory.Exists(PathData)) { MessageBox.Show("ไม่พบ Song Data"); return; }
                string ConnectionString = "Dsn=dBASE Files;dbq=" + PathData.ToUpper() + ";defaultdir=" + PathData.ToUpper() + ";driverid=533;maxbuffersize=2048;pagetimeout=5";

                System.Data.Odbc.OdbcConnection conn = new System.Data.Odbc.OdbcConnection(ConnectionString);
                conn.Open();
                string strQuery = "SELECT CODE,TYPE,SUB_TYPE,ARTIST + TITLE as SongName FROM SONG where TYPE like '%MIDI%'  order by ARTIST + TITLE";
                System.Data.Odbc.OdbcDataAdapter adapter = new System.Data.Odbc.OdbcDataAdapter(strQuery, conn);
                System.Data.DataSet ds = new System.Data.DataSet();
                adapter.Fill(ds);
                sONGDataGridView.DataSource = ds.Tables[0].DefaultView;
                Text = "All Song:" + (sONGDataGridView.RowCount - 1);

            }

          
        }

         private void CheckFile(object obj)
        {
            string cri = "";
            int min = (int)((object[])obj)[0];
            int max = (int)((object[])obj)[1];
            int i = min;
            while (true)
            {

                if (this.sONGDataGridView[3, i].Value.ToString().Trim().Replace(" ", "").ToUpper() != cri)
                {
                    cri = this.sONGDataGridView[3, i].Value.ToString().Trim().Replace(" ", "").ToUpper();
                }
                else
                {
                    sngDel++;
                    if (this.sONGDataGridView[2, i].Value.ToString() == "EMK")
                    {
                        MIDI_Dll.MIDI_Dll.MoveFile(PathKARA + "\\SONGS\\MIDI\\EMK\\" + this.sONGDataGridView[0, i].Value.ToString().Substring(0, 1) + "\\" + this.sONGDataGridView[0, i].Value.ToString() + ".emk");
                    }
                    else if (this.sONGDataGridView[2, i].Value.ToString() == "NCN")
                    {
                        MIDI_Dll.MIDI_Dll.MoveFile(PathKARA + "\\SONGS\\MIDI\\NCN\\Lyrics\\" + this.sONGDataGridView[0, i].Value.ToString().Substring(0, 1) + "\\" + this.sONGDataGridView[0, i].Value.ToString() + ".lyr");
                        MIDI_Dll.MIDI_Dll.MoveFile(PathKARA + "\\SONGS\\MIDI\\NCN\\Cursor\\" + this.sONGDataGridView[0, i].Value.ToString().Substring(0, 1) + "\\" + this.sONGDataGridView[0, i].Value.ToString() + ".cur");
                        MIDI_Dll.MIDI_Dll.MoveFile(PathKARA + "\\SONGS\\MIDI\\NCN\\Song\\" + this.sONGDataGridView[0, i].Value.ToString().Substring(0, 1) + "\\" + this.sONGDataGridView[0, i].Value.ToString() + ".mid");
                    }

                }
                try
                {

                    if (sngRun > 0)
                    {
                        double t = DateTime.Now.TimeOfDay.TotalSeconds - startCounter;
                        double strt = (double)((this.sONGDataGridView.RowCount - sngRun) * t / sngRun);

                        this.label3.Invoke(new Action(() =>
                        {

                            this.label3.Text = "Cri =" + cri + Environment.NewLine +
                                "Check code " + this.sONGDataGridView[0, i].Value.ToString() + this.sONGDataGridView[2, i].Value.ToString() + Environment.NewLine +
                                "Delete file;" + sngDel + Environment.NewLine +
                                "File: " + sngRun + "/" + (this.sONGDataGridView.RowCount - 1) + Environment.NewLine +
                                "Completion Ratio:" + string.Format("{0:0.0000}", Convert.ToDouble(100 * (double)sngRun / (double)(this.sONGDataGridView.RowCount - 1))) + " %" + Environment.NewLine +
                                "Speed:" + string.Format("{0:0.00}", ((double)sngRun / t)) + "file/s" + Environment.NewLine +
                                "Elapsed time:" + MIDI_Dll.MIDI_Dll.Time(t) + Environment.NewLine +
                                "Remaining time:" + MIDI_Dll.MIDI_Dll.Time(strt);
                        }));
                    }
                    this.progressBar2.Invoke(new Action(() => { this.progressBar2.Value = sngRun; }));
                }
                catch { }
                System.Threading.Thread.Sleep(5);
                sngRun++;

                i++;

                if (i > max + 1 || i > sONGDataGridView.RowCount)
                {
                    { return; }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sngPer = (int)(sONGDataGridView.RowCount - 1) / maxThread;
            progressBar2.Invoke(new Action(() => { progressBar2.Maximum = this.sONGDataGridView.RowCount - 1; }));
            startCounter = DateTime.Now.TimeOfDay.TotalSeconds;
            for (int i = 0; i < maxThread; i++)
            {
                new System.Threading.Thread(CheckFile).Start(new object[] { i * sngPer, (i + 1) * sngPer });
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmCuteMIDI_Load(object sender, EventArgs e)
         {
             
         }
    }
}
