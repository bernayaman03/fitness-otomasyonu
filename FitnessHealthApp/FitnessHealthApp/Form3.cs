using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace FitnessHealthApp
{
    public partial class Form3 : Form
    {
        // Kullanıcı seçimlerini tutmak için değişkenler
        int secilenPaketFiyati = 0;
        public Form3()
        {

           
            InitializeComponent();
        }

        
        private void Form3_Load(object sender, EventArgs e)
        {

            lblSelectedPrice.Text = ""; // Başlangıçta seçili fiyat yok
            secilenPaketFiyati = 0; // Başlangıç fiyatını sıfırla

        }
        private void LoadDataGridView()
        {
            
        }
        private void ShowChart()
        {
          
        }

        private void chartProgress_Click(object sender, EventArgs e)
        {
      

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            
        }

        private void grpB1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox3.Checked) // 12 aylık paket seçildiyse
            {
                string sadeceSayi = new string(lblPrice3.Text.Where(char.IsDigit).ToArray());
                if (int.TryParse(sadeceSayi, out int fiyat))
                {
                    secilenPaketFiyati = fiyat;
                    lblSelectedPrice.Text = $"{fiyat} TL";
                }
                else
                {
                    MessageBox.Show("Fiyat bilgisi doğru bir formatta değil!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                UncheckOtherCheckboxes(checkBox3); // Diğer checkbox'ları kapat
            }
            else
            {
                lblSelectedPrice.Text = ""; // Seçim kaldırılırsa label'ı temizle
            }
        }
        private void GuncelleFiyat()
        {
            lblSelectedPrice.Text = secilenPaketFiyati.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void UncheckOtherCheckboxes(System.Windows.Forms.CheckBox selectedCheckbox)
        {
            if (selectedCheckbox != chk1Month)
                chk1Month.Checked = false;

            if (selectedCheckbox != chk6Month)
                chk6Month.Checked = false;

            if (selectedCheckbox != checkBox3)
                checkBox3.Checked = false;

            // Kullanıcıya bilgi ver
            MessageBox.Show("Sadece bir paket seçebilirsiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnPay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCardNumber.Text) ||
        string.IsNullOrWhiteSpace(txtCardName.Text) ||
        string.IsNullOrWhiteSpace(txtExpiryDate.Text) ||
        string.IsNullOrWhiteSpace(txtCVV.Text))
            {
                MessageBox.Show("Lütfen tüm kart bilgilerini eksiksiz doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (secilenPaketFiyati == 0)
            {
                MessageBox.Show("Lütfen bir üyelik paketi seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ödeme başarılı mesajı
            MessageBox.Show($"Ödemeniz başarıyla alındı!\nToplam Tutar: {secilenPaketFiyati} TL", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form1 form1 = new Form1();
            form1.Show();
        }
    

        private void chk1Month_CheckedChanged(object sender, EventArgs e)
        {
            if (chk1Month.Checked) // 1 aylık paket seçildiyse
            {
                string sadeceSayi = new string(lblPrice1.Text.Where(char.IsDigit).ToArray());
                if (int.TryParse(sadeceSayi, out int fiyat))
                {
                    secilenPaketFiyati = fiyat;
                    lblSelectedPrice.Text = $"{fiyat} TL";
                }
                else
                {
                    MessageBox.Show("Fiyat bilgisi doğru bir formatta değil!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                UncheckOtherCheckboxes(chk1Month); // Diğer checkbox'ları kapat
            }
            else
            {
                lblSelectedPrice.Text = ""; // Seçim kaldırılırsa label'ı temizle
            }
        }

        private void chk6Month_CheckedChanged(object sender, EventArgs e)
        {
            if (chk6Month.Checked) // 6 aylık paket seçildiyse
            {
                // Metni temizleyip sadece sayıyı al
                string sadeceSayi = new string(lblPrice2.Text.Where(char.IsDigit).ToArray());
                if (int.TryParse(sadeceSayi, out int fiyat))
                {
                    secilenPaketFiyati = fiyat; // Temizlenmiş fiyatı değişkene ata
                    lblSelectedPrice.Text = $"{fiyat} TL"; // 6 aylık fiyatı yaz
                }
                else
                {
                    MessageBox.Show("Fiyat bilgisi doğru bir formatta değil!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                UncheckOtherCheckboxes(chk6Month); // Diğer checkbox'ları kapat
            }
            else
            {
                lblSelectedPrice.Text = ""; // Seçim kaldırılırsa label'ı temizle
            }
        }

        private void lblSelectedPrice_Click(object sender, EventArgs e)
        {


        }
    }
}
