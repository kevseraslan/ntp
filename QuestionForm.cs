using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ReviseMee
{
    public partial class QuestionForm : Form
    {
        private string connectionString = "Data Source=MSI\\SQLK;Initial Catalog=ReviseMe;Integrated Security=True;";

        public QuestionForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal; // Tam ekranı kapat
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Sabit boyut
            this.StartPosition = FormStartPosition.CenterScreen; // Ortada başlasın
            this.MaximizeBox = false; // Tam ekran yapma butonunu devre dışı bırak
            this.Size = new System.Drawing.Size(949, 620);
        }

        private void QuestionForm_Load(object sender, EventArgs e)
        {
            btnSave.Visible = false;
            LoadCategories();
            LoadUserQuestions(); // Kullanıcıya özel soruları yükle
        }

        private void LoadCategories()
        {
            cmbCategory.Items.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Name FROM Categories";
                SqlCommand cmd = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string categoryName = reader["Name"].ToString();
                        if (!cmbCategory.Items.Contains(categoryName))
                        {
                            cmbCategory.Items.Add(categoryName);
                        }
                    }
                }
            }
        }

        private void LoadUserQuestions()
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Content FROM Questions WHERE UserId = @UserId";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@UserId", UserSession.UserId); // Kullanıcının ID'si

                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                    }
                }
            }
        }

        private int GetCategoryIdByName(string categoryName)
        {
            int categoryId = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT CategoryId FROM Categories WHERE Name = @CategoryName";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@CategoryName", categoryName);

                connection.Open();
                categoryId = (int)cmd.ExecuteScalar();
            }
            return categoryId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string questionContent = txtQuestion.Text;
            string category = cmbCategory.SelectedItem?.ToString();
            string difficulty = cmbDifficulty.SelectedItem?.ToString();
            string photoPath = picQuestionImage.ImageLocation;

            if (string.IsNullOrEmpty(questionContent) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(difficulty))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int categoryId = GetCategoryIdByName(category);

            try
            {
                SaveQuestionData(questionContent, categoryId, difficulty, photoPath);
                MessageBox.Show("Soru başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUserQuestions(); // Sorular güncelleniyor
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveQuestionData(string questionContent, int categoryId, string difficulty, string photoPath)
        {
            string query = @"
                INSERT INTO Questions (Content, UserId, CategoryId, DifficultyLevel, PhotoPath, Repeat1Date, Repeat2Date, Repeat3Date, RepeatCount, IsCompleted) 
                VALUES (@Content, @UserId, @CategoryId, @DifficultyLevel, @PhotoPath, @Repeat1Date, @Repeat2Date, @Repeat3Date, 0, 0)";

            DateTime now = DateTime.Now;
            DateTime repeat1Date = now.AddDays(1);  // 1. tekrar
            DateTime repeat2Date = now.AddDays(10); // 2. tekrar
            DateTime repeat3Date = now.AddDays(25); // 3. tekrar

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Content", questionContent);
                cmd.Parameters.AddWithValue("@UserId", UserSession.UserId); // Oturumdaki kullanıcı
                cmd.Parameters.AddWithValue("@CategoryId", categoryId);
                cmd.Parameters.AddWithValue("@DifficultyLevel", difficulty);
                cmd.Parameters.AddWithValue("@PhotoPath", photoPath ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Repeat1Date", repeat1Date);
                cmd.Parameters.AddWithValue("@Repeat2Date", repeat2Date);
                cmd.Parameters.AddWithValue("@Repeat3Date", repeat3Date);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void txtQuestion_TextChanged(object sender, EventArgs e)
        {
            btnSave.Visible = !string.IsNullOrEmpty(txtQuestion.Text) && picQuestionImage.Image != null;
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picQuestionImage.ImageLocation = openFileDialog.FileName;
                btnSave.Visible = true;
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

        private void lblDifficulty_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
