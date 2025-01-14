using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ReviseMee
{
    public partial class SolveQuestionForm : Form
    {
        private string connectionString = "Data Source=MSI\\SQLK;Initial Catalog=ReviseMe;Integrated Security=True;";

        public SolveQuestionForm()
        {
            InitializeComponent();
            LoadSolveQuestions();
        }

        private void LoadSolveQuestions()
        {
            flowLayoutPanelQuestions.Controls.Clear();

            string query = @"
                SELECT QuestionId, Content, PhotoPath, RepeatCount
                FROM Questions
                WHERE UserId = @UserId AND IsCompleted = 0 AND (
                    (RepeatCount = 0 AND Repeat1Date <= GETDATE()) OR
                    (RepeatCount = 1 AND Repeat2Date <= GETDATE()) OR
                    (RepeatCount = 2 AND Repeat3Date <= GETDATE())
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

                    AddQuestionToPanel(questionId, content, photoPath, repeatCount);
                }
            }
        }

        private void AddQuestionToPanel(int questionId, string content, string photoPath, int repeatCount)
        {
            Panel panel = new Panel
            {
                Size = new Size(220, 280),
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10),
                Tag = questionId // Soru ID'si saklanıyor
            };

            PictureBox pictureBox = new PictureBox
            {
                Size = new Size(200, 150),
                Location = new Point(10, 10),
                SizeMode = PictureBoxSizeMode.Zoom,
                ImageLocation = !string.IsNullOrEmpty(photoPath) && System.IO.File.Exists(photoPath) ? photoPath : null,
                Tag = questionId
            };

            Label lblContent = new Label
            {
                Text = content,
                Location = new Point(10, 170),
                Size = new Size(200, 40),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Tahoma", 9, FontStyle.Regular)
            };

            Label lblRepeatPhase = new Label
            {
                Text = $"Tekrar {repeatCount + 1}",
                Location = new Point(10, 220),
                AutoSize = true,
                Font = new Font("Tahoma", 8, FontStyle.Italic)
            };

            // Görsele tıklama olayı
            pictureBox.Click += (s, e) => OpenQuestionDetails(questionId);

            panel.Controls.Add(pictureBox);
            panel.Controls.Add(lblContent);
            panel.Controls.Add(lblRepeatPhase);

            flowLayoutPanelQuestions.Controls.Add(panel);
        }

        private void OpenQuestionDetails(int questionId)
        {
            // Soru detay sayfasını açma
            QuestionDetailsForm detailsForm = new QuestionDetailsForm(questionId);
            detailsForm.ShowDialog();

            // Soru tamamlandıysa işlemler
            MarkQuestionAsCompleted(questionId);
            LoadSolveQuestions(); // Listeyi yenile
        }

        private void MarkQuestionAsCompleted(int questionId)
        {
            string query = @"
                UPDATE Questions
                SET RepeatCount = RepeatCount + 1,
                    IsCompleted = CASE WHEN RepeatCount + 1 >= 3 THEN 1 ELSE 0 END
                WHERE QuestionId = @QuestionId AND UserId = @UserId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@QuestionId", questionId);
                cmd.Parameters.AddWithValue("@UserId", UserSession.UserId);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
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