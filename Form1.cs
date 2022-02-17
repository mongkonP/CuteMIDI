using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DbfDataReader;
namespace CuteMIDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string Endcode(string s)
        {
            Encoding iso = Encoding.GetEncoding("iso-8859-1");
            Encoding utf8 = Encoding.UTF8;
            byte[] utfBytes = utf8.GetBytes(s);
            byte[] isoBytes = Encoding.Convert(iso, iso, utfBytes);
            string msg = iso.GetString(isoBytes);

            return msg;
        }
        string dbPath = @"D:\Extreme Karaoke\KARAOKA TOR\Data";
        string file = @"D:\Extreme Karaoke\KARAOKA TOR\Data\SONG.DBF";
        private void Form1_Load(object sender, EventArgs e)
        {
            /*using (var dpfTable = new DbfDataReader.DbfTable(file, DbfDataReader.EncodingProvider.BigEndianUnicode))
            {
                var dpfRecord = new DbfDataReader.DbfRecord(dpfTable);
                while (dpfTable.Read(dpfRecord))
                {
                    var CODE = Convert.ToString(dpfRecord.Values[4]);
                    MessageBox.Show(Endcode(CODE));
                }
               
            }*/
             using (var dbfDataReader = new DbfDataReader.DbfDataReader(@"D:\Extreme Karaoke\KARAOKA TOR\Data\SONG.DBF"))
             {
                 while (dbfDataReader.Read())
                 {
                     var CODE = Convert.ToString( dbfDataReader["ARTIST"]);
                    MessageBox.Show(Endcode(CODE));
                 }
             }








        }
    }
}
