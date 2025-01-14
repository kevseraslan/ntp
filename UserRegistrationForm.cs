using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ReviseMee
{
    public partial class UserRegistrationForm : XtraForm
    {
        public UserRegistrationForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan bilgiler
            string userName = textUserName.Text.Trim();
            string password = textPassword.Text.Trim();
            string name = textName.Text.Trim();
            string surname = textSurname.Text.Trim();
            string userClass = textClass.Text.Trim();
            string yearOfBirth = textYearOfBirth.Text.Trim();
            string area = textArea.Text.Trim();
            string aim = textAim.Text.Trim();
            string email = textEmail.Text.Trim();
            string phone = textPhone.Text.Trim();
            string googleAuthId = textGoogleAuthId.Text.Trim();
            string securityQuestion = textSecurityQuestion.Text.Trim();

            // Gerekli alanların kontrolü
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email))
            {
                XtraMessageBox.Show("Zorunlu alanları doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SaveUser(userName, password, name, surname, userClass, yearOfBirth, area, aim, email, phone, googleAuthId, securityQuestion);
                XtraMessageBox.Show("Kayıt başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoginForm loginForm = new LoginForm(); // Giriş sayfası formu oluştur
                loginForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Kayıt sırasında hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveUser(string userName, string password, string name, string surname, string userClass,
                              string yearOfBirth, string area, string aim, string email, string phone,
                              string googleAuthId, string securityQuestion)
        {
            string connectionString = "Data Source=MSI\\SQLK;Initial Catalog=ReviseMe;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Users (UserName, PasswordHash, Name, Surname, Class, YearOfBirth, Area, Aim, Email, PhoneNumber, GoogleAuthId, SecurityQuestion)
                                 VALUES (@UserName, @PasswordHash, @Name, @Surname, @Class, @YearOfBirth, @Area, @Aim, @Email, @PhoneNumber, @GoogleAuthId, @SecurityQuestion)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", userName);
                    command.Parameters.AddWithValue("@PasswordHash", HashPassword(password));
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Surname", surname);
                    command.Parameters.AddWithValue("@Class", userClass);
                    command.Parameters.AddWithValue("@YearOfBirth", yearOfBirth);
                    command.Parameters.AddWithValue("@Area", area);
                    command.Parameters.AddWithValue("@Aim", aim);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@PhoneNumber", phone);
                    command.Parameters.AddWithValue("@GoogleAuthId", googleAuthId);
                    command.Parameters.AddWithValue("@SecurityQuestion", securityQuestion);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        private void textUserName_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl12_Click(object sender, EventArgs e)
        {

        }

    }
}