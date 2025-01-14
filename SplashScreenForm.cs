using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ReviseMee
{
    public partial class SplashScreenForm : DevExpress.XtraEditors.XtraForm
    {
        public SplashScreenForm()
        {
            InitializeComponent();
        }

        private void SplashScreenForm_Load(object sender, EventArgs e)
        {
            // Başlık ve alt yazıyı ayarla
            lblReviseMe.Text = "Revise Me";
            lblWelcome.Text = "Hoşgeldiniz";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // LoginForm'a geçiş yapılacak
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide(); // Splash ekranını gizle
        }
    }
}
