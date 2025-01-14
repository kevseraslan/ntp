using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ReviseMee
{
    public partial class LoginForm : XtraForm
    {
        private string connectionString = "Data Source=MSI\\SQLK;Initial Catalog=ReviseMe;Integrated Security=True;";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(userName))
            {
                XtraMessageBox.Show("Lütfen kullanıcı adınızı girin!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                XtraMessageBox.Show("Lütfen şifrenizi girin!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (ValidateUser(userName, password, out int userId, out string email))
                {
                    XtraMessageBox.Show("Giriş başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Oturum bilgilerini sakla
                    UserSession.UserId = userId;
                    UserSession.UserName = userName;
                    UserSession.Email = email;

                    // Menüye yönlendirme
                    MenuRibbonForm menuRibbon= new MenuRibbonForm();
                    menuRibbon.Show();
                    this.Hide();
                }
                else
                {
                    XtraMessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Giriş sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateUser(string userName, string password, out int userId, out string email)
        {
            bool isValid = false;
            userId = 0;
            email = string.Empty;


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT UserId, Email FROM Users WHERE UserName = @UserName AND PasswordHash = @PasswordHash";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", userName);
                command.Parameters.AddWithValue("@PasswordHash", HashPassword(password));

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    userId = reader.GetInt32(0); // UserId
                    email = reader.GetString(1); // Email
                    isValid = true;
                }
            }

            return isValid;
        }


        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            UserRegistrationForm registrationForm = new UserRegistrationForm();
            registrationForm.Show();
            this.Hide();
        }
        private void labelControl2_Click(object sender, EventArgs e)
        {
            // Bu olayı ne yapmak istediğinize göre doldurun.
            MessageBox.Show("Label'a tıklandı!");
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text.Trim();

            if (string.IsNullOrEmpty(userName))
            {
                XtraMessageBox.Show("Lütfen kullanıcı adınızı girin!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm(userName);
            forgotPasswordForm.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde yapılacak işlemler (varsa)
        }
    }
}
