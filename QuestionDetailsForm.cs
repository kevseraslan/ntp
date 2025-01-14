using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ReviseMee
{
    public partial class QuestionDetailsForm : Form
    {
        private string connectionString = "Data Source=MSI\\SQLK;Initial Catalog=ReviseMe;Integrated Security=True;";
        private int questionId;
        private int nextQuestionId;

        public QuestionDetailsForm(int questionId)
        {
            InitializeComponent();
            this.questionId = questionId;
        }

        private void QuestionDetailsForm_Load(object sender, EventArgs e)
        {
            LoadQuestionDetails();
            LoadNote();
            CheckIfFavorite(); // Favorilere eklenip eklenmediğini kontrol et
        }

        private void LoadQuestionDetails()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Content, PhotoPath FROM Questions WHERE QuestionId = @QuestionId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@QuestionId", questionId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    lblQuestionContent.Text = reader["Content"].ToString();

                    string photoPath = reader["PhotoPath"]?.ToString();
                    if (!string.IsNullOrEmpty(photoPath) && System.IO.File.Exists(photoPath))
                    {
                        pictureBoxQuestion.Image = Image.FromFile(photoPath);
                    }
                    else
                    {
                        pictureBoxQuestion.Image = null; // Görsel yoksa boş bırak
                    }
                }
            }
            LoadNextQuestionId();
        }

        private void LoadNextQuestionId()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT TOP 1 QuestionId 
                    FROM Questions 
                    WHERE QuestionId > @CurrentQuestionId 
                    ORDER BY QuestionId ASC";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CurrentQuestionId", questionId);

                connection.Open();
                object result = command.ExecuteScalar();
                nextQuestionId = result != null ? (int)result : -1;
            }
        }

        private void LoadNote()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Content FROM Notes WHERE QuestionId = @QuestionId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@QuestionId", questionId);

                connection.Open();
                object result = command.ExecuteScalar();
                txtSavedNote.Text = result?.ToString() ?? ""; // Daha önce kaydedilen notu göster
            }
        }

        private void CheckIfFavorite()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Favorites WHERE UserId = @UserId AND QuestionId = @QuestionId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", UserSession.UserId); // Oturumdaki kullanıcı
                command.Parameters.AddWithValue("@QuestionId", questionId);

                connection.Open();
                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    btnAddToFavorites.Text = "Favorilere Eklendi";
                    btnAddToFavorites.Enabled = false;
                }
            }
        }

        private void SaveNote()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    IF EXISTS (SELECT 1 FROM Notes WHERE QuestionId = @QuestionId)
                        UPDATE Notes SET Content = @Content WHERE QuestionId = @QuestionId
                    ELSE
                        INSERT INTO Notes (QuestionId, Content) VALUES (@QuestionId, @Content)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@QuestionId", questionId);
                command.Parameters.AddWithValue("@Content", txtNote.Text.Trim());

                connection.Open();
                command.ExecuteNonQuery();
            }

            MessageBox.Show("Not başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadNote(); // Not kaydedildikten sonra güncelle
        }

        private void btnSaveNote_Click(object sender, EventArgs e)
        {
            SaveNote();
        }

        private void btnAddToFavorites_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Favorites (UserId, QuestionId) VALUES (@UserId, @QuestionId)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", UserSession.UserId); // Kullanıcı ID'si
                command.Parameters.AddWithValue("@QuestionId", questionId);

                connection.Open();
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Soru favorilere eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnAddToFavorites.Text = "Favorilere Eklendi";
                    btnAddToFavorites.Enabled = false; // Butonu devre dışı bırak
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627) // Aynı kayıt zaten varsa
                    {
                        MessageBox.Show("Bu soru zaten favorilere eklenmiş.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Favorilere ekleme sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSkipQuestion_Click(object sender, EventArgs e)
        {
            if (nextQuestionId != -1)
            {
                QuestionDetailsForm nextForm = new QuestionDetailsForm(nextQuestionId);
                this.Hide();
                nextForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Daha fazla soru yok!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "Bu soruyu silmek istediğinizden emin misiniz?",
                "Soru Sil",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                DeleteQuestion();
            }
        }

        private void DeleteQuestion()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Questions WHERE QuestionId = @QuestionId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@QuestionId", questionId);

                connection.Open();
                command.ExecuteNonQuery();
            }

            MessageBox.Show("Soru başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
