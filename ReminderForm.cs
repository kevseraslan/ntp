using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ReviseMee
{
    public partial class ReminderForm : Form
    {
        private string connectionString = "Data Source=MSI\\SQLK;Initial Catalog=ReviseMe;Integrated Security=True;";

        public ReminderForm()
        {
            InitializeComponent();
            this.Text = "Sorular";
            LoadReminders();
        }

        private void LoadReminders()
        {
            flowLayoutPanelReminders.Controls.Clear();


            string query = @"
                SELECT QuestionId, Content, PhotoPath, Repeat1Date, Repeat2Date, Repeat3Date, RepeatCount 
                FROM Questions
                WHERE IsCompleted = 0 AND UserId = @UserId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@UserId", UserSession.UserId); // Kullanıcının UserId'sini ekle
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int questionId = (int)reader["QuestionId"];
                    string content = reader["Content"].ToString();
                    string photoPath = reader["PhotoPath"]?.ToString();
                    int repeatCount = (int)reader["RepeatCount"];

                    // Tekrar tarihi ve aşama bilgisi
                    string repeatInfo = GetRepeatInfo(reader, repeatCount);

                    // Soruyu görsel olarak ekle
                    AddQuestionToPanel(questionId, content, photoPath, repeatInfo);
                }
            }
        }

        private string GetRepeatInfo(SqlDataReader reader, int repeatCount)
        {
            DateTime? repeatDate = null;

            if (repeatCount == 0 && !DBNull.Value.Equals(reader["Repeat1Date"]))
                repeatDate = Convert.ToDateTime(reader["Repeat1Date"]);
            else if (repeatCount == 1 && !DBNull.Value.Equals(reader["Repeat2Date"]))
                repeatDate = Convert.ToDateTime(reader["Repeat2Date"]);
            else if (repeatCount == 2 && !DBNull.Value.Equals(reader["Repeat3Date"]))
                repeatDate = Convert.ToDateTime(reader["Repeat3Date"]);

            string dateInfo = repeatDate.HasValue ? repeatDate.Value.ToString("g") : "Belirsiz";
            return $"Tarih: {dateInfo}\nAşama: Tekrar {repeatCount + 1}";
        }

        private void AddQuestionToPanel(int questionId, string content, string photoPath, string repeatInfo)
        {
            // Panel oluştur
            Panel panel = new Panel
            {
                Size = new Size(220, 300),
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10),
                Tag = questionId // Soru ID'sini tut
            };

            // PictureBox ekle
            PictureBox pictureBox = new PictureBox
            {
                Size = new Size(200, 150),
                Location = new Point(10, 10),
                SizeMode = PictureBoxSizeMode.Zoom,
                ImageLocation = !string.IsNullOrEmpty(photoPath) && System.IO.File.Exists(photoPath) ? photoPath : null,
                Tag = questionId
            };

            // PictureBox'a tıklama olayı bağla
            pictureBox.Click += (s, e) => OpenQuestionDetails((int)pictureBox.Tag);

            // Label (tekrar bilgisi için)
            Label lblRepeatInfo = new Label
            {
                Text = repeatInfo,
                Location = new Point(10, 170),
                Size = new Size(200, 60),
                AutoSize = false,
                TextAlign = ContentAlignment.TopLeft,
                Font = new Font("Tahoma", 9, FontStyle.Regular)
            };

            // Label (soru içeriği)
            Label lblContent = new Label
            {
                Text = content,
                Location = new Point(10, 240),
                Size = new Size(200, 40),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Tahoma", 10, FontStyle.Bold)
            };

            // Panel içine ekle
            panel.Controls.Add(pictureBox);
            panel.Controls.Add(lblRepeatInfo);
            panel.Controls.Add(lblContent);

            // FlowLayoutPanel'e ekle
            flowLayoutPanelReminders.Controls.Add(panel);
        }

        private void OpenQuestionDetails(int questionId)
        {
            // Soru detaylarını aç
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
