using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Drawing;
namespace ReviseMee
{
    public partial class ProfileForm : XtraForm
    {
        private int currentUserId = UserSession.UserId; // Giriş yapan kullanıcının ID'si
        private string connectionString = "Data Source=MSI\\SQLK;Initial Catalog=ReviseMe;Integrated Security=True;";

        public ProfileForm(int userId)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal; // Tam ekranı kapat
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Sabit boyut
            this.StartPosition = FormStartPosition.CenterScreen; // Ortada başlasın
            this.MaximizeBox = false; // Tam ekran yapma butonunu devre dışı bırak
            this.Size = new System.Drawing.Size(949, 620);
            currentUserId = userId; // Kullanıcı ID'sini ayarla
        }


        private void ProfileForm_Load(object sender, EventArgs e)
        {
            LoadUserProfile(); // Kullanıcı bilgilerini yükle
        }


        private void LoadUserProfile()
        {
            string query = "SELECT * FROM Users WHERE UserId = @UserId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", currentUserId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // TextEdit kontrollerine kullanıcı bilgilerini yazdır
                        textEdits[0].Text = reader["UserName"].ToString();
                        textEdits[1].Text = reader["PasswordHash"].ToString();
                        textEdits[2].Text = reader["Name"].ToString();
                        textEdits[3].Text = reader["Surname"].ToString();
                        textEdits[4].Text = reader["Class"].ToString();
                        textEdits[5].Text = reader["YearOfBirth"].ToString();
                        textEdits[6].Text = reader["Area"].ToString();
                        textEdits[7].Text = reader["Aim"].ToString();
                        textEdits[8].Text = reader["Email"].ToString();
                        textEdits[9].Text = reader["PhoneNumber"].ToString();
                        textEdits[10].Text = reader["GoogleAuthId"].ToString();
                        textEdits[11].Text = reader["SecurityQuestion"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı bilgileri bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Veriler yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var button = sender as SimpleButton;
            int index = (int)button.Tag;

            // Düzenlenebilir hale getir
            textEdits[index].Properties.ReadOnly = false;

            // Buton metnini değiştir ve olay işleyiciyi güncelle
            button.Text = "Kaydet";
            button.Click -= EditButton_Click;
            button.Click += SaveButton_Click;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var button = sender as SimpleButton;
            int index = (int)button.Tag;

            // Sadece okunabilir yap
            textEdits[index].Properties.ReadOnly = true;

            // Buton metnini değiştir ve olay işleyiciyi güncelle
            button.Text = "Düzenle";
            button.Click -= SaveButton_Click;
            button.Click += EditButton_Click;

            // Veritabanını güncelle
            UpdateFieldInDatabase(index, textEdits[index].Text);
        }

        private void UpdateFieldInDatabase(int fieldIndex, string newValue)
        {
            string[] dbFields = {
                "UserName", "PasswordHash", "Name", "Surname", "Class",
                "YearOfBirth", "Area", "Aim", "Email", "PhoneNumber",
                "GoogleAuthId", "SecurityQuestion"
            };

            string fieldName = dbFields[fieldIndex];

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"UPDATE Users SET {fieldName} = @Value WHERE UserId = @UserId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Value", newValue);
                command.Parameters.AddWithValue("@UserId", currentUserId);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show($"{fieldName} bilgisi başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Kaydetme sırasında hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void BtnBackToMenu_Click(object sender, EventArgs e)
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is MenuRibbonForm)
                {
                    openForm.Show(); // Zaten açık olan ana menüyü göster
                    this.Close(); // Mevcut formu kapat
                    return;
                }
            }

            // Ana menüye dönmek için
            MenuRibbonForm mainMenu = new MenuRibbonForm();
            mainMenu.Show();
            this.Close();
        }

    }

}