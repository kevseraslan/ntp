using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ReviseMee
{
    public partial class QuestionListForm : Form
    {
        private string connectionString = "Data Source=MSI\\SQLK;Initial Catalog=ReviseMe;Integrated Security=True;";
        private string courseName;

        public QuestionListForm(string courseName, int userId)
        {
            InitializeComponent();
            this.courseName = courseName;
            UserSession.UserId = userId;
        }


        private void QuestionListForm_Load(object sender, EventArgs e)
        {
            int questionCount = GetTotalQuestionCount(courseName); // Toplam soru sayısını al
            lblCourseName.Text = $"Ders: {courseName} - Toplam Soru: {questionCount}";
            flowLayoutPanelQuestions.AutoScroll = true; // Kaydırma çubuğunu etkinleştir
            LoadQuestions();
        }

        private void LoadQuestions()
        {
            flowLayoutPanelQuestions.Controls.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT Q.QuestionId, Q.Content, Q.PhotoPath
                    FROM Questions Q
                    INNER JOIN Categories C ON Q.CategoryId = C.CategoryId
                    WHERE C.Name = @CourseName AND Q.UserId = @UserId"; // Kullanıcıya özel filtre

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CourseName", courseName);
                command.Parameters.AddWithValue("@UserId", UserSession.UserId); // Oturumdaki kullanıcı

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int questionId = (int)reader["QuestionId"];
                    string content = reader["Content"].ToString();
                    string photoPath = reader["PhotoPath"]?.ToString();

                    // Görsel için PictureBox oluştur
                    PictureBox pictureBox = new PictureBox
                    {
                        Size = new Size(150, 150),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Image = !string.IsNullOrEmpty(photoPath) && System.IO.File.Exists(photoPath)
                            ? Image.FromFile(photoPath)
                            : null,
                        Tag = questionId // Her görsele soru ID'sini bağla
                    };

                    // PictureBox tıklama olayını bağla
                    pictureBox.Click += (s, args) => ShowQuestionDetails(questionId);

                    // Soru içeriğini göstermek için bir Label ekle
                    Label lblContent = new Label
                    {
                        Text = content,
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Size = new Size(150, 40)
                    };

                    // Görsel ve metni bir Panel içinde gruplandır
                    Panel panel = new Panel
                    {
                        Size = new Size(150, 200),
                        Margin = new Padding(10)
                    };
                    panel.Controls.Add(pictureBox);
                    panel.Controls.Add(lblContent);
                    lblContent.Location = new Point(0, 160); // Label'i görselin altına yerleştir

                    flowLayoutPanelQuestions.Controls.Add(panel); // Paneli FlowLayout'a ekle
                }
            }
        }

        private int GetTotalQuestionCount(string courseName)
        {
            int count = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT COUNT(*) 
                    FROM Questions Q
                    INNER JOIN Categories C ON Q.CategoryId = C.CategoryId
                    WHERE C.Name = @CourseName AND Q.UserId = @UserId"; // Kullanıcıya özel filtre

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CourseName", courseName);
                command.Parameters.AddWithValue("@UserId", UserSession.UserId); // Oturumdaki kullanıcı

                connection.Open();
                count = (int)command.ExecuteScalar();
            }

            return count;
        }

        private void ShowQuestionDetails(int questionId)
        {
            // Soru detaylarını göstermek için yeni bir form aç
            QuestionDetailsForm detailsForm = new QuestionDetailsForm(questionId);
            detailsForm.ShowDialog();
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            // Ana menüye geri dön
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is MenuRibbonForm)
                {
                    openForm.Show(); // Zaten açık olan ana menüyü göster
                    this.Close(); // Mevcut formu kapat
                    return;
                }
            }

            // Eğer ana menü formu açık değilse yeni bir tane oluştur
            MenuRibbonForm menuForm = new MenuRibbonForm();
            menuForm.Show();
            this.Close();
        }


    }
}
