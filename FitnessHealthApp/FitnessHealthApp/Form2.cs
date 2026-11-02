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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace FitnessHealthApp
{
    public partial class Form2 : Form
    {
        private int userID;

        public Form2(int userID)
        {

            InitializeComponent();
            this.userID = userID;
        }

        private void btnSaveActivity_Click(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadUserActivities(); // Kullanıcı hareketlerini yükle
            

        }

        private List<string> tumHareketler = new List<string>();


        // Görsellerin yolu (proje dizinine göre düzenleyin)
        private Dictionary<string, string> kasGoruntuleri = new Dictionary<string, string>
    {
       { "Bacak", "C:\\Users\\CASPER\\Desktop\\Yeni klasör (3)\\bacak.png" },
    { "Kol", "C:\\Users\\CASPER\\Desktop\\Yeni klasör (3)\\kol.png" },
    { "Omuz", "C:\\Users\\CASPER\\Desktop\\Yeni klasör (3)\\omuz.png" },
   { "Sırt", "C:\\Users\\CASPER\\Desktop\\Yeni klasör (3)\\sırt.png" },
    { "Göğüs", "C:\\Users\\CASPER\\Desktop\\Yeni klasör (3)\\gogus.png" },
    { "Karın", "C:\\Users\\CASPER\\Desktop\\Yeni klasör (3)\\karın.png" },
    { "Full Body", "C:\\Users\\CASPER\\Desktop\\Yeni klasör (3)\\fullbody.png" }
    };

        // Sadece PictureBox'a görsel yükleme
        private void ResimYukle(string bolge)
        {
            if (kasGoruntuleri.ContainsKey(bolge))
            {
                pictureBox1.Image = Image.FromFile(kasGoruntuleri[bolge]);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        }



        private void btnBacak_Click(object sender, EventArgs e)
        {
            BolgeyiGoster("Bacak");
            tabControl1.SelectedTab = tabPage2;
        }

        private void btnKol_Click(object sender, EventArgs e)
        {
            BolgeyiGoster("Kol");
            tabControl1.SelectedTab = tabPage2;
        }

        private void btnOmuz_Click(object sender, EventArgs e)
        {
            BolgeyiGoster("Omuz");
            tabControl1.SelectedTab = tabPage2;
        }

        private void btnSırt_Click(object sender, EventArgs e)
        {
            BolgeyiGoster("Sırt");
            tabControl1.SelectedTab = tabPage2;
        }

        private void btnGogus_Click(object sender, EventArgs e)
        {
            BolgeyiGoster("Göğüs");
            tabControl1.SelectedTab = tabPage2;
        }

        private void btnKarın_Click(object sender, EventArgs e)
        {
            BolgeyiGoster("Karın");
            tabControl1.SelectedTab = tabPage2;
        }

        private void btnFull_Click(object sender, EventArgs e)
        {
            BolgeyiGoster("Full Body");
            tabControl1.SelectedTab = tabPage2;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void BolgeyiGoster(string bolge)
        {

            // ListView'i temizle
            listView1.Items.Clear();

            if (antrenmanlar.ContainsKey(bolge))
            {
                foreach (var hareket in antrenmanlar[bolge])
                {
                    ListViewItem item = new ListViewItem(hareket.Hareket);
                    item.SubItems.Add(hareket.Set);
                    item.SubItems.Add(hareket.Tekrar);

                    listView1.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Bu bölge için antrenman bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Görsel yükle
            if (kasGoruntuleri.ContainsKey(bolge))
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(kasGoruntuleri[bolge]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Görsel yüklenemedi: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private System.Windows.Forms.TextBox txtUsername;


        // Bölgelere göre antrenman programları
        private Dictionary<string, List<(string Hareket, string Set, string Tekrar)>> antrenmanlar = new Dictionary<string, List<(string, string, string)>>
{
    {
        "Bacak", new List<(string, string, string)>
        {
            ("Squat", "4 set", "12 tekrar"),
            ("Lunges", "3 set", "10 tekrar "),
            ("Romanian Deadlift", "3 set", "12 tekrar"),
            ("Step-Up", "3 set", "10 tekrar "),
            ("Calf Raise", "4 set", "15 tekrar"),
            ("Glute Bridge", "3 set", "12 tekrar")
        }
    },
    {
        "Kol", new List<(string, string, string)>
        {
            ("Biceps Curl", "3 set", "12 tekrar"),
            ("Hammer Curl", "3 set", "12 tekrar"),
            ("Concentration Curl", "3 set", "10 tekrar"),
            ("Triceps Dips", "3 set", "12 tekrar"),
            ("Overhead Triceps Extension", "3 set", "12 tekrar"),
            ("Close-Grip Push-Up", "3 set", "15 tekrar")
        }
    },
    {
        "Omuz", new List<(string, string, string)>
        {
            ("Overhead Press", "4 set", "12 tekrar"),
            ("Lateral Raise", "3 set", "12 tekrar"),
            ("Front Raise", "3 set", "12 tekrar"),
            ("Arnold Press", "3 set", "10 tekrar"),
            ("Face Pull", "3 set", "12 tekrar"),
            ("Upright Row", "3 set", "12 tekrar")
        }
    },
    {
        "Sırt", new List<(string, string, string)>
        {
            ("Pull-Up/Chin-Up", "4 set", "8-10 tekrar"),
            ("Bent-Over Row", "3 set", "12 tekrar"),
            ("Deadlift", "4 set", "10 tekrar"),
            ("T-Bar Row", "3 set", "12 tekrar"),
            ("Lat Pulldown", "3 set", "12 tekrar"),
            ("Superman Hold", "3 set", "30 saniye")
        }
    },
    {
        "Göğüs", new List<(string, string, string)>
        {
            ("Bench Press", "4 set", "12 tekrar"),
            ("Incline Bench Press", "3 set", "12 tekrar"),
            ("Chest Fly", "3 set", "12 tekrar"),
            ("Push-Up", "3 set", "15 tekrar"),
            ("Pec Deck", "3 set", "12 tekrar"),
            ("Dumbbell Pullover", "3 set", "12 tekrar")
        }
    },
    {
        "Karın", new List<(string, string, string)>
        {
            ("Plank", "3 set", "45 saniye"),
            ("Russian Twist", "3 set", "15 tekrar"),
            ("Leg Raise", "3 set", "12 tekrar"),
            ("Mountain Climber", "3 set", "30 saniye"),
            ("Bicycle Crunch", "3 set", "15 tekrar"),
            ("Flutter Kicks", "3 set", "30 saniye")
        }
    },
    {
        "Full Body", new List<(string, string, string)>
        {
            ("Burpee", "3 set", "10 tekrar"),
            ("Deadlift", "4 set", "10 tekrar"),
            ("Squat to Press", "3 set", "12 tekrar"),
            ("Pull-Up", "3 set", "8-10 tekrar"),
            ("Push-Up", "3 set", "15 tekrar"),
            ("Plank to Shoulder Tap", "3 set", "30 saniye")
        }
    }
};
        private void TumHareketleriGoster()
        {
            listView1.Items.Clear(); // Mevcut öğeleri temizle

            foreach (string hareket in tumHareketler.Distinct()) // Tekrarlı öğeleri filtrele
            {
                ListViewItem item = new ListViewItem(hareket);
                listView1.Items.Add(item);
            }
        }


        private void btnGeri_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            // Seçili hareketleri al
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                string hareket = item.Text; // Hareketin adını al
                tumHareketler.Add(hareket); // Genel listeye ekle
            }

            // Tab1'e geçiş yap
            tabControl1.SelectedTab = tabPage1;

            // Tab1'deki ListView'i güncelle
            TumHareketleriGoster();
        }

        private void LoadUserActivities()
        {
            listView1.Items.Clear(); // Mevcut öğeleri temizle

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=\"C:\\Users\\CASPER\\Desktop\\Yeni klasör (3)\\FitnessHealthApp\\FitnessHealthApp\\fitness.db\";Version=3;"))
            {
                conn.Open();

                // Kullanıcının hareketlerini al
                string query = "SELECT region, set_count, repetition FROM Activities WHERE user_id = @user_id";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user_id", userID);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string hareket = reader["region"].ToString();
                            string set = reader["set_count"].ToString();
                            string tekrar = reader["repetition"].ToString();

                            // ListView'e ekle
                            ListViewItem item = new ListViewItem(hareket);
                            item.SubItems.Add(set);
                            item.SubItems.Add(tekrar);
                            listView1.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void GetUserActivities(string userName)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=\"C:\\Users\\CASPER\\Desktop\\Yeni klasör (3)\\FitnessHealthApp\\FitnessHealthApp\\fitness.db\";Version=3;"))
            {
                conn.Open();
                string selectQuery = "SELECT * FROM activities WHERE user_name = @user_name";

                using (SQLiteCommand cmd = new SQLiteCommand(selectQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@user_name", userName);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                           
                            string activityName = reader["activity_name"].ToString();
                            string region = reader["region"].ToString();
                            string sets = reader["sets"].ToString();
                            string reps = reader["reps"].ToString();

                            // Aktiviteyi ekrana yazdırma veya başka bir işlem yapma
                            Console.WriteLine($"Activity: {activityName}, Region: {region}, Sets: {sets}, Reps: {reps}");
                        }
                    }
                }
            }
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {



                // Seçilen hareketleri al
                foreach (ListViewItem item in listView1.Items)
                {
                    string hareket = item.Text; // Hareketin adını al
                    string set = item.SubItems[1].Text; // Set bilgisi
                    string tekrar = item.SubItems[2].Text; // Tekrar bilgisi

                    // SQLite bağlantısı oluştur
                    using (SQLiteConnection conn = new SQLiteConnection("Data Source=\"C:\\Users\\CASPER\\Desktop\\Yeni klasör (3)\\FitnessHealthApp\\FitnessHealthApp\\fitness.db\";Version=3;"))
                    {
                        conn.Open();

                        // Veritabanına veri ekle
                        string query = "INSERT INTO activities (user_id, region, set_count, repetition) VALUES (@user_id, @region, @set_count, @repetition)";
                        using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@user_id", userID); // Kullanıcı ID'si
                            cmd.Parameters.AddWithValue("@region", hareket); // Hareket adı
                            cmd.Parameters.AddWithValue("@set_count", set); // Set sayısı
                            cmd.Parameters.AddWithValue("@repetition", tekrar); // Tekrar sayısı

                            cmd.ExecuteNonQuery(); // Veriyi kaydet
                        }
                    }
                }

                MessageBox.Show("Antrenman programı kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form4 form4 = new Form4();
            form4.Show();



        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}


