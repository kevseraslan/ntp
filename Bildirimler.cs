using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ReviseMee
{
    public partial class Bildirimler : Form
    {
        private string connectionString = "Data Source=MSI\\SQLK;Initial Catalog=ReviseMe;Integrated Security=True;";

        public Bildirimler()
        {
            InitializeComponent();
            this.Text = "Bugünün Soruları";
            LoadNotifications();
        }

        private void LoadNotifications()
        {
            // FlowLayoutPanel'deki tüm kontrolleri temizle
            flowLayoutPanelBildirimler.Controls.Clear();

            string query = @"
                SELECT QuestionId, Content, PhotoPath, RepeatCount
                FROM Questions
                WHERE IsCompleted = 0 AND UserId = @UserId AND (
                    (RepeatCount = 0 AND CAST(Repeat1Date AS DATE) = CAST(GETDATE() AS DATE)) OR
                    (RepeatCount = 1 AND CAST(Repeat2Date AS DATE) = CAST(GETDATE() AS DATE)) OR
                    (RepeatCount = 2 AND CAST(Repeat3Date AS DATE) = CAST(GETDATE() AS DATE))
                )";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@UserId", UserSession.UserId);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int questionId = (int)reader["QuestionId"];
                    string content = reader["Content"].ToString();
                    string photoPath = reader["PhotoPath"]?.ToString();
                    int repeatCount = (int)reader["RepeatCount"];

                    string repeatInfo = $"Tekrar {repeatCount + 1}";

                    // Soru kartını ekle
                    AddNotificationToPanel(questionId, content, photoPath, repeatInfo);
                }
            }
        }

        private void AddNotificationToPanel(int questionId, string content, string photoPath, string repeatInfo)
        {
            Panel panel = new Panel
            {
                Size = new Size(220, 300),
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10),
                Tag = questionId
            };

            PictureBox pictureBox = new PictureBox
            {
                Size = new Size(200, 150),
                Location = new Point(10, 10),
                SizeMode = PictureBoxSizeMode.Zoom,
                ImageLocation = !string.IsNullOrEmpty(photoPath) && System.IO.File.Exists(photoPath) ? photoPath : null,
                Tag = questionId
            };

            pictureBox.Click += (s, e) => OpenQuestionDetails((int)pictureBox.Tag);

            Label lblRepeatInfo = new Label
            {
                Text = repeatInfo,
                Location = new Point(10, 170),
                Size = new Size(200, 30),
                AutoSize = false,
                TextAlign = ContentAlignment.TopLeft,
                Font = new Font("Tahoma", 9, FontStyle.Regular)
            };

            Label lblContent = new Label
            {
                Text = content,
                Location = new Point(10, 210),
                Size = new Size(200, 60),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Tahoma", 10, FontStyle.Bold)
            };

            panel.Controls.Add(pictureBox);
            panel.Controls.Add(lblRepeatInfo);
            panel.Controls.Add(lblContent);

            flowLayoutPanelBildirimler.Controls.Add(panel);
        }

        private void OpenQuestionDetails(int questionId)
        {
            QuestionDetailsForm detailsForm = new QuestionDetailsForm(questionId);
            detailsForm.Show();
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
