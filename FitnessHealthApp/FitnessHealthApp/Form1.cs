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
using System.Data.SQLite;

namespace FitnessHealthApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            TextBox txtUsername = new TextBox();
            TextBox txtPassword = new TextBox();
         
            InitializeComponent();
          
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            
                string connectionString = "Data Source=\"C:\\Users\\CASPER\\Desktop\\Yeni klasör (3)\\FitnessHealthApp\\FitnessHealthApp\\fitness.db\";Version=3;";

                string username = txtUsername.Text; // Kullanıcı adı textbox'ı
                string password = txtPassword.Text; // Şifre textbox'ı

                // Basit bir kontrol: Kullanıcı adı ve şifre boş olmamalı
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Lütfen kullanıcı adı ve şifreyi girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    // SQLite bağlantısını açıyoruz
                    using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                    {
                        conn.Open();

                        // SQL sorgusu: Kullanıcı adı ve şifreyi kontrol et
                        string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";

                        using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                        {
                            // Parametreleri ekliyoruz
                            cmd.Parameters.AddWithValue("@username", username);
                            cmd.Parameters.AddWithValue("@password", password);

                            // Sorguyu çalıştırıyoruz ve sonucu alıyoruz
                            int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                            if (userCount > 0)
                            {
                                // Kullanıcı adı ve şifre doğruysa
                                MessageBox.Show("Giriş başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Form2'yi açalım (örneğin, kullanıcı ID'si ile)
                                int userID = 1; // Bu kısmı gerçek kullanıcı ID'siyle değiştirmeniz gerekebilir
                                Form2 form2 = new Form2(userID);
                                form2.Show();

                                // Form1'i gizliyoruz
                                this.Hide();
                            }
                            else
                            {
                                // Kullanıcı adı veya şifre yanlışsa
                                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Hata mesajı gösteriyoruz
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            



        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
                string connectionString = "Data Source=\"C:\\Users\\CASPER\\Desktop\\Yeni klasör (3)\\FitnessHealthApp\\FitnessHealthApp\\fitness.db\";Version=3;";

                string username = txtUsernameRegister.Text; // Kullanıcı adı textbox'ı
                string password = txtPasswordRegister.Text; // Şifre textbox'ı
                string name = txtName.Text; // İsim textbox'ı
                string age = txtAge.Text; // Yaş textbox'ı
                string weight = txtWeight.Text; // Kilo textbox'ı
                string height = txtHeight.Text; // Boy textbox'ı

                // Basit bir kontrol: Alanlar boş olmamalı
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(age) || string.IsNullOrEmpty(weight) || string.IsNullOrEmpty(height))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        // SQLite bağlantısını açıyoruz
                        using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                        {
                            conn.Open();

                            // SQL INSERT sorgusu
                            string query = "INSERT INTO users (username, password, name, age, weight, height) VALUES (@username, @password, @name, @age, @weight, @height)";

                            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                            {
                                // Parametreleri ekliyoruz
                                cmd.Parameters.AddWithValue("@username", username);
                                cmd.Parameters.AddWithValue("@password", password);
                                cmd.Parameters.AddWithValue("@name", name);
                                cmd.Parameters.AddWithValue("@age", age);
                                cmd.Parameters.AddWithValue("@weight", weight);
                                cmd.Parameters.AddWithValue("@height", height);

                                // Sorguyu çalıştırıyoruz
                                int result = cmd.ExecuteNonQuery();

                                // Kayıt başarılı mı kontrolü
                                if (result > 0)
                                {
                                    MessageBox.Show("Kayıt başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Kayıt başarısız oldu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Hata mesajı gösteriyoruz
                        MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Kayıt işleminden sonra Form3'e geçiş yapılabilir
                Form3 form3 = new Form3();
                form3.Show();
            






        }

        private void tabPage1_Click(object sender, EventArgs e)
        {


        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
           
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPasswordRegister_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
