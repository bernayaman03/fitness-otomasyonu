namespace FitnessHealthApp
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSelectedPrice = new System.Windows.Forms.Label();
            this.picCredit = new System.Windows.Forms.PictureBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.txtExpiryDate = new System.Windows.Forms.TextBox();
            this.txtCardName = new System.Windows.Forms.TextBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grpB1 = new System.Windows.Forms.GroupBox();
            this.lblPrice1 = new System.Windows.Forms.Label();
            this.lbl1ay = new System.Windows.Forms.Label();
            this.chk1Month = new System.Windows.Forms.CheckBox();
            this.grpB6 = new System.Windows.Forms.GroupBox();
            this.lblPrice2 = new System.Windows.Forms.Label();
            this.lbl6ay = new System.Windows.Forms.Label();
            this.chk6Month = new System.Windows.Forms.CheckBox();
            this.grpB12 = new System.Windows.Forms.GroupBox();
            this.lblPrice3 = new System.Windows.Forms.Label();
            this.lbl12ay = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCredit)).BeginInit();
            this.grpB1.SuspendLayout();
            this.grpB6.SuspendLayout();
            this.grpB12.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lblSelectedPrice);
            this.panel1.Controls.Add(this.picCredit);
            this.panel1.Controls.Add(this.btnPay);
            this.panel1.Controls.Add(this.txtCVV);
            this.panel1.Controls.Add(this.txtExpiryDate);
            this.panel1.Controls.Add(this.txtCardName);
            this.panel1.Controls.Add(this.txtCardNumber);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(12, 420);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 310);
            this.panel1.TabIndex = 1;
            // 
            // lblSelectedPrice
            // 
            this.lblSelectedPrice.ForeColor = System.Drawing.Color.White;
            this.lblSelectedPrice.Location = new System.Drawing.Point(799, 23);
            this.lblSelectedPrice.Name = "lblSelectedPrice";
            this.lblSelectedPrice.Size = new System.Drawing.Size(164, 25);
            this.lblSelectedPrice.TabIndex = 14;
            this.lblSelectedPrice.Click += new System.EventHandler(this.lblSelectedPrice_Click);
            // 
            // picCredit
            // 
            this.picCredit.Image = global::FitnessHealthApp.Properties.Resources.Google_Noto_Emoji_Objects_62882_credit_card_512;
            this.picCredit.Location = new System.Drawing.Point(19, 36);
            this.picCredit.Name = "picCredit";
            this.picCredit.Size = new System.Drawing.Size(417, 246);
            this.picCredit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCredit.TabIndex = 13;
            this.picCredit.TabStop = false;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPay.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPay.Location = new System.Drawing.Point(887, 257);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(266, 38);
            this.btnPay.TabIndex = 12;
            this.btnPay.Text = "ONAY";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtCVV
            // 
            this.txtCVV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCVV.Location = new System.Drawing.Point(799, 221);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(129, 30);
            this.txtCVV.TabIndex = 11;
            this.txtCVV.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtExpiryDate
            // 
            this.txtExpiryDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtExpiryDate.Location = new System.Drawing.Point(799, 166);
            this.txtExpiryDate.Name = "txtExpiryDate";
            this.txtExpiryDate.Size = new System.Drawing.Size(129, 30);
            this.txtExpiryDate.TabIndex = 10;
            this.txtExpiryDate.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtCardName
            // 
            this.txtCardName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCardName.Location = new System.Drawing.Point(799, 121);
            this.txtCardName.Name = "txtCardName";
            this.txtCardName.Size = new System.Drawing.Size(129, 30);
            this.txtCardName.TabIndex = 9;
            this.txtCardName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCardNumber.Location = new System.Drawing.Point(799, 68);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(129, 30);
            this.txtCardNumber.TabIndex = 8;
            this.txtCardNumber.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Seçilen Üyelik Paketi Fiyatı\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(505, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Kart Numarası";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(505, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ad Soyad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(505, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Son Kullanma Tarihi";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(505, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "CVV";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // grpB1
            // 
            this.grpB1.BackColor = System.Drawing.Color.Gray;
            this.grpB1.Controls.Add(this.lblPrice1);
            this.grpB1.Controls.Add(this.lbl1ay);
            this.grpB1.Controls.Add(this.chk1Month);
            this.grpB1.Location = new System.Drawing.Point(19, 14);
            this.grpB1.Name = "grpB1";
            this.grpB1.Size = new System.Drawing.Size(342, 311);
            this.grpB1.TabIndex = 2;
            this.grpB1.TabStop = false;
            this.grpB1.Text = "1 AYLIK PLAN";
            this.grpB1.Enter += new System.EventHandler(this.grpB1_Enter);
            // 
            // lblPrice1
            // 
            this.lblPrice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice1.Location = new System.Drawing.Point(6, 272);
            this.lblPrice1.Name = "lblPrice1";
            this.lblPrice1.Size = new System.Drawing.Size(166, 23);
            this.lblPrice1.TabIndex = 0;
            this.lblPrice1.Text = "1200 \r\n\r\n\r\n\r\nTL";
            this.lblPrice1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbl1ay
            // 
            this.lbl1ay.BackColor = System.Drawing.Color.Gray;
            this.lbl1ay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl1ay.Location = new System.Drawing.Point(7, 35);
            this.lbl1ay.Name = "lbl1ay";
            this.lbl1ay.Size = new System.Drawing.Size(310, 226);
            this.lbl1ay.TabIndex = 1;
            this.lbl1ay.Text = "- Sadece 1 aylık kullanım.\r\n\r\n- Grup derslerine katılım.\r\n\r\n- Tüm ekipmanlardan f" +
    "aydalanma.\r\n\r\n- Haftada 1 ücretsiz kişisel antrenör desteği.\r\n\r\nFİYAT: 1200 TL";
            this.lbl1ay.Click += new System.EventHandler(this.label1_Click);
            // 
            // chk1Month
            // 
            this.chk1Month.AutoSize = true;
            this.chk1Month.Location = new System.Drawing.Point(280, 272);
            this.chk1Month.Name = "chk1Month";
            this.chk1Month.Size = new System.Drawing.Size(56, 20);
            this.chk1Month.TabIndex = 0;
            this.chk1Month.Text = "SEÇ";
            this.chk1Month.UseVisualStyleBackColor = true;
            this.chk1Month.CheckedChanged += new System.EventHandler(this.chk1Month_CheckedChanged);
            // 
            // grpB6
            // 
            this.grpB6.BackColor = System.Drawing.Color.Gray;
            this.grpB6.Controls.Add(this.lblPrice2);
            this.grpB6.Controls.Add(this.lbl6ay);
            this.grpB6.Controls.Add(this.chk6Month);
            this.grpB6.Location = new System.Drawing.Point(367, 14);
            this.grpB6.Name = "grpB6";
            this.grpB6.Size = new System.Drawing.Size(368, 311);
            this.grpB6.TabIndex = 3;
            this.grpB6.TabStop = false;
            this.grpB6.Text = "6 AYLIK PLAN";
            // 
            // lblPrice2
            // 
            this.lblPrice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice2.Location = new System.Drawing.Point(6, 275);
            this.lblPrice2.Name = "lblPrice2";
            this.lblPrice2.Size = new System.Drawing.Size(143, 23);
            this.lblPrice2.TabIndex = 1;
            this.lblPrice2.Text = "6000 \r\n\r\n\r\nTL";
            // 
            // lbl6ay
            // 
            this.lbl6ay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl6ay.Location = new System.Drawing.Point(6, 37);
            this.lbl6ay.Name = "lbl6ay";
            this.lbl6ay.Size = new System.Drawing.Size(319, 224);
            this.lbl6ay.TabIndex = 2;
            this.lbl6ay.Text = resources.GetString("lbl6ay.Text");
            this.lbl6ay.Click += new System.EventHandler(this.label2_Click);
            // 
            // chk6Month
            // 
            this.chk6Month.AutoSize = true;
            this.chk6Month.Location = new System.Drawing.Point(285, 275);
            this.chk6Month.Name = "chk6Month";
            this.chk6Month.Size = new System.Drawing.Size(56, 20);
            this.chk6Month.TabIndex = 1;
            this.chk6Month.Text = "SEÇ";
            this.chk6Month.UseVisualStyleBackColor = true;
            this.chk6Month.CheckedChanged += new System.EventHandler(this.chk6Month_CheckedChanged);
            // 
            // grpB12
            // 
            this.grpB12.BackColor = System.Drawing.Color.Gray;
            this.grpB12.Controls.Add(this.lblPrice3);
            this.grpB12.Controls.Add(this.lbl12ay);
            this.grpB12.Controls.Add(this.checkBox3);
            this.grpB12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpB12.Location = new System.Drawing.Point(741, 14);
            this.grpB12.Name = "grpB12";
            this.grpB12.Size = new System.Drawing.Size(412, 311);
            this.grpB12.TabIndex = 4;
            this.grpB12.TabStop = false;
            this.grpB12.Text = "12 AYLIK PLAN (1 YIL)";
            // 
            // lblPrice3
            // 
            this.lblPrice3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice3.Location = new System.Drawing.Point(6, 273);
            this.lblPrice3.Name = "lblPrice3";
            this.lblPrice3.Size = new System.Drawing.Size(149, 23);
            this.lblPrice3.TabIndex = 2;
            this.lblPrice3.Text = "9000\r\n\r\n TL";
            this.lblPrice3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl12ay
            // 
            this.lbl12ay.AutoSize = true;
            this.lbl12ay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl12ay.Location = new System.Drawing.Point(6, 20);
            this.lbl12ay.Name = "lbl12ay";
            this.lbl12ay.Size = new System.Drawing.Size(385, 252);
            this.lbl12ay.TabIndex = 3;
            this.lbl12ay.Text = resources.GetString("lbl12ay.Text");
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(330, 273);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(61, 22);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "SEÇ";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.grpB1);
            this.panel2.Controls.Add(this.grpB12);
            this.panel2.Controls.Add(this.grpB6);
            this.panel2.Location = new System.Drawing.Point(12, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1176, 361);
            this.panel2.TabIndex = 5;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FitnessHealthApp.Properties.Resources._66ac4228f7701b4b13bde3c8280c425b4;
            this.ClientSize = new System.Drawing.Size(1211, 755);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Aylık İlerleme Raporları";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCredit)).EndInit();
            this.grpB1.ResumeLayout(false);
            this.grpB1.PerformLayout();
            this.grpB6.ResumeLayout(false);
            this.grpB6.PerformLayout();
            this.grpB12.ResumeLayout(false);
            this.grpB12.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpB1;
        private System.Windows.Forms.GroupBox grpB6;
        private System.Windows.Forms.GroupBox grpB12;
        private System.Windows.Forms.CheckBox chk1Month;
        private System.Windows.Forms.CheckBox chk6Month;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label lbl6ay;
        private System.Windows.Forms.Label lbl12ay;
        public System.Windows.Forms.Label lbl1ay;
        private System.Windows.Forms.Label lblPrice1;
        private System.Windows.Forms.Label lblPrice2;
        private System.Windows.Forms.Label lblPrice3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.TextBox txtExpiryDate;
        private System.Windows.Forms.TextBox txtCardName;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picCredit;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblSelectedPrice;
    }
}