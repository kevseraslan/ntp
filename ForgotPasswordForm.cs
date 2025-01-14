using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ReviseMee
{
    public partial class ForgotPasswordForm : XtraForm
    {
        private string userName;
        private string connectionString = "Data Source=MSI\\SQLK;Initial Catalog=ReviseMe;Integrated Security=True;";

        public ForgotPasswordForm(string userName)
        {
            InitializeComponent();
            this.userName = userName;

            // Formu tam ekran yerine ekran ortasında açalım
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;

            // Resize olayına bağlan
            this.Resize += ForgotPasswordForm_Resize;
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {
            lblSecurityPrompt.Text = "Anne kızlık soyadınızı girin:";
            UpdateLayout(); // İlk açılışta yerleşimi güncelle
        }

        private void ForgotPasswordForm_Resize(object sender, EventArgs e)
        {
            UpdateLayout();
        }

        private void UpdateLayout()
        {
            // Arka plan görseli tam ekran uyumlu olsun
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // lblSecurityPrompt sağa hizalanmış yerleşimi
            lblSecurityPrompt.Left = this.ClientSize.Width - lblSecurityPrompt.Width - 20;
            lblSecurityPrompt.Top = this.ClientSize.Height / 4;

            // txtSecurityAnswer sağa hizalanmış yerleşimi
            txtSecurityAnswer.Width = this.ClientSize.Width / 3;
            txtSecurityAnswer.Left = this.ClientSize.Width - txtSecurityAnswer.Width - 20;
            txtSecurityAnswer.Top = lblSecurityPrompt.Bottom + 20;

            // btnSubmitAnswer sağa hizalanmış yerleşimi
            btnSubmitAnswer.Width = txtSecurityAnswer.Width / 2;
            btnSubmitAnswer.Left = this.ClientSize.Width - btnSubmitAnswer.Width - 20;
            btnSubmitAnswer.Top = txtSecurityAnswer.Bottom + 20;

            // txtNewPassword sağa hizalanmış yerleşimi
            txtNewPassword.Width = this.ClientSize.Width / 3;
            txtNewPassword.Left = this.ClientSize.Width - txtNewPassword.Width - 20;
            txtNewPassword.Top = btnSubmitAnswer.Bottom + 40;

            // btnUpdatePassword sağa hizalanmış yerleşimi
            btnUpdatePassword.Width = txtNewPassword.Width / 2;
            btnUpdatePassword.Left = this.ClientSize.Width - btnUpdatePassword.Width - 20;
            btnUpdatePassword.Top = txtNewPassword.Bottom + 20;
        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            string securityAnswer = txtSecurityAnswer.Text.Trim();

            if (string.IsNullOrEmpty(securityAnswer))
            {
                XtraMessageBox.Show("Lütfen güvenlik sorusunu yanıtlayın!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidateSecurityAnswer(userName, securityAnswer))
            {
                XtraMessageBox.Show("Güvenlik sorusu doğru yanıtlandı. Yeni şifre oluşturabilirsiniz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Güvenlik sorusu cevabı yanlış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateSecurityAnswer(string userName, string securityAnswer)
        {
            bool isValid = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE UserName = @UserName AND SecurityQuestion = @SecurityAnswer";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", userName);
                command.Parameters.AddWithValue("@SecurityAnswer", securityAnswer);

                connection.Open();
                int count = (int)command.ExecuteScalar();
                isValid = count > 0;
            }

            return isValid;
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            string newPassword = txtNewPassword.Text.Trim();

            if (string.IsNullOrEmpty(newPassword))
            {
                XtraMessageBox.Show("Yeni şifre boş olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (UpdatePassword(userName, newPassword))
            {
                XtraMessageBox.Show("Şifre başarıyla güncellendi. Giriş ekranına yönlendiriliyorsunuz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Şifre güncellenirken bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool UpdatePassword(string userName, string newPassword)
        {
            bool isUpdated = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Users SET PasswordHash = @PasswordHash WHERE UserName = @UserName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", userName);
                command.Parameters.AddWithValue("@PasswordHash", HashPassword(newPassword));

                connection.Open();
                isUpdated = command.ExecuteNonQuery() > 0;
            }

            return isUpdated;
        }

        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        private void lblNewPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtSecurityAnswer_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
