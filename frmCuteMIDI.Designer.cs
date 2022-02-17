namespace CuteMIDI
{
    partial class frmCuteMIDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.sONGDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sONGDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Test";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PathKaraoke";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(747, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(841, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.progressBar2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 218);
            this.panel1.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(890, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 23);
            this.button2.TabIndex = 37;
            this.button2.Text = "Run";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar2.Location = new System.Drawing.Point(0, 199);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(983, 19);
            this.progressBar2.TabIndex = 36;
            // 
            // sONGDataGridView
            // 
            this.sONGDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sONGDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sONGDataGridView.Location = new System.Drawing.Point(0, 218);
            this.sONGDataGridView.Name = "sONGDataGridView";
            this.sONGDataGridView.Size = new System.Drawing.Size(983, 350);
            this.sONGDataGridView.TabIndex = 9;
            // 
            // frmCuteMIDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 568);
            this.Controls.Add(this.sONGDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "frmCuteMIDI";
            this.Text = "ตัดเพลงซ้ำ MIDI";
            this.Load += new System.EventHandler(this.frmCuteMIDI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sONGDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.DataGridView sONGDataGridView;
        private System.Windows.Forms.Button button2;
    }
}

