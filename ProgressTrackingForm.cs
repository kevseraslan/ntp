using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ReviseMee
{
    public partial class ProgressTrackingForm : Form
    {
        private string connectionString = "Data Source=MSI\\SQLK;Initial Catalog=ReviseMe;Integrated Security=True;";

        public ProgressTrackingForm()
        {
            InitializeComponent();
        }

        private void ProgressTrackingForm_Load(object sender, EventArgs e)
        {
            LoadChartsForAllCategories();
        }

        private void LoadChartsForAllCategories()
        {
            // Güncellenmiş ders listesi
            var categories = new[]
            {
                new { Id = 1, Name = "Matematik" },
                new { Id = 2, Name = "Fizik" },
                new { Id = 3, Name = "Kimya" },
                new { Id = 4, Name = "Biyoloji" },
                new { Id = 5, Name = "Türk Dili ve Edebiyat" },
                new { Id = 6, Name = "Tarih" },
                new { Id = 7, Name = "Coğrafya" },
                new { Id = 8, Name = "İngilizce" }
            };

            foreach (var category in categories)
            {
                // Eğer bu derse ait herhangi bir soru varsa grafiği yükle
                if (HasQuestionsInCategory(category.Id))
                {
                    LoadChartForCategory(category.Id, category.Name);
                }
            }
        }

        private bool HasQuestionsInCategory(int categoryId)
        {
            bool hasQuestions = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT COUNT(*) 
                    FROM Questions 
                    WHERE CategoryId = @CategoryId AND UserId = @UserId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CategoryId", categoryId);
                command.Parameters.AddWithValue("@UserId", UserSession.UserId);

                connection.Open();
                int questionCount = (int)command.ExecuteScalar();
                hasQuestions = questionCount > 0;
            }

            return hasQuestions;
        }

        private void LoadChartForCategory(int categoryId, string categoryName)
        {
            int[] completedCounts = GetCompletedCountsByRepeat(categoryId);
            int[] missedCounts = GetMissedCountsByRepeat(categoryId);

            // Yeni bir Chart oluştur
            Chart chart = new Chart
            {
                Size = new Size(600, 400),
                Dock = DockStyle.Top
            };

            ChartArea chartArea = new ChartArea("MainArea");
            chart.ChartAreas.Add(chartArea);
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.BackColor = Color.Transparent;
            chartArea.BorderWidth = 0;
            chartArea.BorderColor = Color.Transparent;
            chartArea.AxisX.LineColor = Color.Black;
            chartArea.AxisY.LineColor = Color.Black;
            chartArea.AxisX.LabelStyle.ForeColor = Color.Black;
            chartArea.AxisY.LabelStyle.ForeColor = Color.Black;

            // Mavi çizgi - Tamamlanan tekrar sayıları
            Series completedSeries = new Series("Tamamlanan Tekrarlar")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Blue,
                BorderWidth = 3,
                MarkerStyle = MarkerStyle.Circle, // İşaretçi şekli
                MarkerSize = 8, // İşaretçi boyutu
                MarkerColor = Color.Blue, // İşaretçi rengi
                MarkerBorderColor = Color.Black // İşaretçi kenarlık rengi
            };

            // Kırmızı çizgi - Kaçırılan tekrar sayıları
            Series missedSeries = new Series("Kaçırılan Tekrarlar")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Red,
                BorderWidth = 3,
                MarkerStyle = MarkerStyle.Circle, // İşaretçi şekli
                MarkerSize = 8, // İşaretçi boyutu
                MarkerColor = Color.Red, // İşaretçi rengi
                MarkerBorderColor = Color.Black
            };

            // Verileri ekle
            for (int i = 0; i < 3; i++)
            {
                completedSeries.Points.AddXY(i + 1, completedCounts[i]);
                missedSeries.Points.AddXY(i + 1, missedCounts[i]);
            }

            chart.Series.Add(completedSeries);
            chart.Series.Add(missedSeries);
            chart.Legends.Add(new Legend("Legend")
            {
                Docking = Docking.Bottom,
                Font = new Font("Tahoma", 10),
                IsDockedInsideChartArea = false
            });

            // Grafik ayarları
            chart.ChartAreas["MainArea"].AxisX.Title = "Tekrar Sayısı";
            chart.ChartAreas["MainArea"].AxisY.Title = "Soru Sayısı";
            chart.ChartAreas["MainArea"].AxisX.Interval = 1;
            chart.ChartAreas["MainArea"].AxisY.Interval = 1;
            chart.ChartAreas["MainArea"].AxisX.Minimum = 1;
            chart.ChartAreas["MainArea"].AxisX.Maximum = 3;

            // Grafik başlığı
            Title chartTitle = new Title($"{categoryName}", Docking.Top, new Font("Tahoma", 14, FontStyle.Bold), Color.Black);
            chart.Titles.Add(chartTitle);

            // Form'a ekle
            flowLayoutPanelCharts.Controls.Add(chart);
        }

        private int[] GetCompletedCountsByRepeat(int categoryId)
        {
            int[] completedCounts = new int[3]; // RepeatCount: 1, 2, 3

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        RepeatCount,
                        COUNT(*) AS QuestionCount
                    FROM Questions
                    WHERE CategoryId = @CategoryId
                    AND UserId=@UserId
                    GROUP BY RepeatCount
                    ORDER BY RepeatCount";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", UserSession.UserId);
                command.Parameters.AddWithValue("@CategoryId", categoryId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int repeatCount = reader.GetInt32(0); // RepeatCount
                    int questionCount = reader.GetInt32(1); // QuestionCount

                    if (repeatCount >= 1 && repeatCount <= 3)
                    {
                        completedCounts[repeatCount - 1] = questionCount;
                    }
                }
            }

            return completedCounts;
        }

        private int[] GetMissedCountsByRepeat(int categoryId)
        {
            int[] missedCounts = new int[3]; // RepeatCount: 0, 1, 2

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT
                        COUNT(CASE WHEN RepeatCount = 0 THEN 1 END) AS RepeatCount_0,
                        COUNT(CASE 
                                WHEN RepeatCount = 1 AND Repeat2Date <= GETDATE() AND IsCompleted = 0 THEN 1 
                             END) AS RepeatCount_1_Pending,
                        COUNT(CASE 
                                WHEN RepeatCount = 2 AND Repeat3Date <= GETDATE() AND IsCompleted = 0 THEN 1 
                             END) AS RepeatCount_2_Pending
                    FROM Questions
                    WHERE CategoryId = @CategoryId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CategoryId", categoryId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    missedCounts[0] = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    missedCounts[1] = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                    missedCounts[2] = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                }
            }

            return missedCounts;
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            // Ana menünün açık olup olmadığını kontrol et
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is MenuRibbonForm)
                {
                    openForm.Show(); // Zaten açık olan ana menüyü göster
                    this.Close(); // Mevcut formu kapat
                    return; // Yeni bir form oluşturmadan çık
                }
            }

            // Eğer ana menü formu açık değilse yeni bir tane oluştur
            MenuRibbonForm menuForm = new MenuRibbonForm();
            menuForm.Show();
            this.Close();
        }
    }
}
