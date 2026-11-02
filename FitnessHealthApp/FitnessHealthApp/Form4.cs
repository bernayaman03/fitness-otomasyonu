using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FitnessHealthApp
{
    public partial class Form4 : Form
    {
        private string connectionString = "Data Source=\"C:\\Users\\CASPER\\Desktop\\Yeni klasör (3)\\FitnessHealthApp\\FitnessHealthApp\\fitness.db\";Version=3;";

        private int userId = 1;  // Bu, giriş yapan kullanıcının ID'si olacak
        private SQLiteConnection conn;

        public Form4()
        {
            InitializeComponent();
        }

        private void OpenConnection()
        {
            conn = new SQLiteConnection(connectionString);
            conn.Open();
        }

        private void CloseConnection()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        // Verileri yükleyip grafiği güncelleyen metod
        private void LoadColumnChart()
        {
            string query = @"
            SELECT Region, COUNT(*) AS ExerciseCount 
            FROM activities 
            GROUP BY Region"; // Veritabanından bölge ve hareket sayısını al

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open(); // Veritabanına bağlan

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        chart1.Series.Clear(); // Eski verileri temizle
                        Series series = new Series("Regions") { ChartType = SeriesChartType.Column }; // Çubuk grafik tipi

                        while (reader.Read())
                        {
                            string region = reader["Region"].ToString();
                            int count = Convert.ToInt32(reader["ExerciseCount"]);
                            series.Points.AddXY(region, count); // Grafik için veri ekle
                        }

                        chart1.Series.Add(series); // Grafik serisini ekle
                    }
                }
            }
        }

        // Verileri yükleme butonuna bağlanacak olay
        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadColumnChart(); // Veriyi yükleyip grafiği güncelle
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Başlangıçta herhangi bir işlem yapılmaz
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            // Grafik tıklama olayını boş bırakabiliriz, şu anda kullanmıyoruz.
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
