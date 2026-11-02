namespace FitnessHealthApp
{
    partial class Form2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnFull = new System.Windows.Forms.Button();
            this.btnKarın = new System.Windows.Forms.Button();
            this.btnGogus = new System.Windows.Forms.Button();
            this.btnSırt = new System.Windows.Forms.Button();
            this.btnOmuz = new System.Windows.Forms.Button();
            this.btnBacak = new System.Windows.Forms.Button();
            this.btnKol = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sqLiteCommandBuilder1 = new System.Data.SQLite.SQLiteCommandBuilder();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1118, 581);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.BackgroundImage = global::FitnessHealthApp.Properties.Resources._66ac4228f7701b4b13bde3c8280c425b2;
            this.tabPage1.Controls.Add(this.btnFull);
            this.tabPage1.Controls.Add(this.btnKarın);
            this.tabPage1.Controls.Add(this.btnGogus);
            this.tabPage1.Controls.Add(this.btnSırt);
            this.tabPage1.Controls.Add(this.btnOmuz);
            this.tabPage1.Controls.Add(this.btnBacak);
            this.tabPage1.Controls.Add(this.btnKol);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1110, 543);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "BÖLGE";
            // 
            // btnFull
            // 
            this.btnFull.BackColor = System.Drawing.Color.Gray;
            this.btnFull.Font = new System.Drawing.Font("Ravie", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFull.Location = new System.Drawing.Point(397, 393);
            this.btnFull.Name = "btnFull";
            this.btnFull.Size = new System.Drawing.Size(318, 133);
            this.btnFull.TabIndex = 6;
            this.btnFull.Text = "FULL BODY";
            this.btnFull.UseVisualStyleBackColor = false;
            this.btnFull.Click += new System.EventHandler(this.btnFull_Click);
            // 
            // btnKarın
            // 
            this.btnKarın.BackColor = System.Drawing.Color.Gray;
            this.btnKarın.Font = new System.Drawing.Font("Ravie", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKarın.Location = new System.Drawing.Point(742, 227);
            this.btnKarın.Name = "btnKarın";
            this.btnKarın.Size = new System.Drawing.Size(318, 135);
            this.btnKarın.TabIndex = 5;
            this.btnKarın.Text = "KARIN";
            this.btnKarın.UseVisualStyleBackColor = false;
            this.btnKarın.Click += new System.EventHandler(this.btnKarın_Click);
            // 
            // btnGogus
            // 
            this.btnGogus.BackColor = System.Drawing.Color.Gray;
            this.btnGogus.Font = new System.Drawing.Font("Ravie", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGogus.Location = new System.Drawing.Point(397, 225);
            this.btnGogus.Name = "btnGogus";
            this.btnGogus.Size = new System.Drawing.Size(318, 135);
            this.btnGogus.TabIndex = 4;
            this.btnGogus.Text = "GÖĞÜS";
            this.btnGogus.UseVisualStyleBackColor = false;
            this.btnGogus.Click += new System.EventHandler(this.btnGogus_Click);
            // 
            // btnSırt
            // 
            this.btnSırt.BackColor = System.Drawing.Color.Gray;
            this.btnSırt.Font = new System.Drawing.Font("Ravie", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSırt.Location = new System.Drawing.Point(46, 227);
            this.btnSırt.Name = "btnSırt";
            this.btnSırt.Size = new System.Drawing.Size(318, 131);
            this.btnSırt.TabIndex = 3;
            this.btnSırt.Text = "SIRT";
            this.btnSırt.UseVisualStyleBackColor = false;
            this.btnSırt.Click += new System.EventHandler(this.btnSırt_Click);
            // 
            // btnOmuz
            // 
            this.btnOmuz.BackColor = System.Drawing.Color.Gray;
            this.btnOmuz.Font = new System.Drawing.Font("Ravie", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOmuz.Location = new System.Drawing.Point(742, 53);
            this.btnOmuz.Name = "btnOmuz";
            this.btnOmuz.Size = new System.Drawing.Size(318, 135);
            this.btnOmuz.TabIndex = 2;
            this.btnOmuz.Text = "OMUZ";
            this.btnOmuz.UseVisualStyleBackColor = false;
            this.btnOmuz.Click += new System.EventHandler(this.btnOmuz_Click);
            // 
            // btnBacak
            // 
            this.btnBacak.BackColor = System.Drawing.Color.Gray;
            this.btnBacak.Font = new System.Drawing.Font("Ravie", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBacak.Location = new System.Drawing.Point(397, 53);
            this.btnBacak.Name = "btnBacak";
            this.btnBacak.Size = new System.Drawing.Size(318, 135);
            this.btnBacak.TabIndex = 1;
            this.btnBacak.Text = "BACAK";
            this.btnBacak.UseVisualStyleBackColor = false;
            this.btnBacak.Click += new System.EventHandler(this.btnBacak_Click);
            // 
            // btnKol
            // 
            this.btnKol.BackColor = System.Drawing.Color.Gray;
            this.btnKol.Font = new System.Drawing.Font("Ravie", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKol.Location = new System.Drawing.Point(46, 53);
            this.btnKol.Name = "btnKol";
            this.btnKol.Size = new System.Drawing.Size(318, 135);
            this.btnKol.TabIndex = 0;
            this.btnKol.Text = "KOL";
            this.btnKol.UseVisualStyleBackColor = false;
            this.btnKol.Click += new System.EventHandler(this.btnKol_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1110, 543);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PROGRAM";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::FitnessHealthApp.Properties.Resources._66ac4228f7701b4b13bde3c8280c425b3;
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.btnGeri);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 552);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(977, 470);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(120, 35);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(977, 416);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(120, 32);
            this.btnGeri.TabIndex = 5;
            this.btnGeri.Text = "GERİ DÖN";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(396, 8);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(575, 529);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Hareket Adı";
            this.columnHeader1.Width = 148;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Set Sayısı";
            this.columnHeader2.Width = 146;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tekrar Sayısı";
            this.columnHeader3.Width = 155;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(977, 363);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 36);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "EKLE";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 516);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // sqLiteCommandBuilder1
            // 
            this.sqLiteCommandBuilder1.DataAdapter = null;
            this.sqLiteCommandBuilder1.QuoteSuffix = "]";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 605);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Text = "Kontrol Paneli";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnFull;
        private System.Windows.Forms.Button btnKarın;
        private System.Windows.Forms.Button btnGogus;
        private System.Windows.Forms.Button btnSırt;
        private System.Windows.Forms.Button btnOmuz;
        private System.Windows.Forms.Button btnBacak;
        private System.Windows.Forms.Button btnKol;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnKaydet;
        private System.Data.SQLite.SQLiteCommandBuilder sqLiteCommandBuilder1;
    }
}