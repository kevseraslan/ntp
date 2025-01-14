namespace ReviseMee
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.LabelControl lblLoginTitle;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.SimpleButton btnForgotPassword;
        private DevExpress.XtraEditors.SimpleButton btnCreateAccount; // Hesap Oluştur Butonu

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lblLoginTitle = new DevExpress.XtraEditors.LabelControl();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.btnForgotPassword = new DevExpress.XtraEditors.SimpleButton();
            this.btnCreateAccount = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold);
            this.lblLoginTitle.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblLoginTitle.Appearance.Options.UseFont = true;
            this.lblLoginTitle.Appearance.Options.UseForeColor = true;
            this.lblLoginTitle.Appearance.Options.UseTextOptions = true;
            this.lblLoginTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblLoginTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblLoginTitle.Location = new System.Drawing.Point(12, 28);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(464, 105);
            this.lblLoginTitle.TabIndex = 0;
            this.lblLoginTitle.Text = "Haydi Başlayalım!";
            // 
            // txtUsername
            // 
            this.behaviorManager1.SetBehaviors(this.txtUsername, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.Behaviors.Common.FileIconBehavior.Create(typeof(DevExpress.XtraEditors.Behaviors.FileIconBehaviorSourceForTextEdit), DevExpress.Utils.Behaviors.Common.FileIconSize.Small, ((System.Drawing.Image)(resources.GetObject("txtUsername.Behaviors"))), null)))});
            this.txtUsername.EditValue = "";
            this.txtUsername.Location = new System.Drawing.Point(607, 186);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Properties.Appearance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtUsername.Properties.Appearance.Options.UseBackColor = true;
            this.txtUsername.Properties.NullText = "Kullanıcı Adı";
            this.txtUsername.Size = new System.Drawing.Size(269, 22);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(607, 235);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtPassword.Properties.Appearance.Options.UseBackColor = true;
            this.txtPassword.Properties.NullText = "Şifre";
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(269, 22);
            this.txtPassword.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.BackColor = System.Drawing.Color.MediumPurple;
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnLogin.Appearance.Options.UseBackColor = true;
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.Appearance.Options.UseForeColor = true;
            this.btnLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.ImageOptions.Image")));
            this.btnLogin.Location = new System.Drawing.Point(751, 272);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(125, 43);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnForgotPassword
            // 
            this.btnForgotPassword.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnForgotPassword.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnForgotPassword.Appearance.Options.UseFont = true;
            this.btnForgotPassword.Appearance.Options.UseForeColor = true;
            this.btnForgotPassword.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnForgotPassword.ImageOptions.Image")));
            this.btnForgotPassword.Location = new System.Drawing.Point(568, 272);
            this.btnForgotPassword.Name = "btnForgotPassword";
            this.btnForgotPassword.Size = new System.Drawing.Size(176, 43);
            this.btnForgotPassword.TabIndex = 4;
            this.btnForgotPassword.Text = "Şifremi Unuttum";
            this.btnForgotPassword.Click += new System.EventHandler(this.btnForgotPassword_Click);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateAccount.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCreateAccount.Appearance.Options.UseFont = true;
            this.btnCreateAccount.Appearance.Options.UseForeColor = true;
            this.btnCreateAccount.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateAccount.ImageOptions.Image")));
            this.btnCreateAccount.Location = new System.Drawing.Point(684, 457);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(192, 36);
            this.btnCreateAccount.TabIndex = 5;
            this.btnCreateAccount.Text = "Hesap Oluştur";
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 16);
            this.labelControl1.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(522, 189);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 16);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Kullanıcı Adı";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(568, 234);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 16);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Şifre";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(569, 457);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(109, 16);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Hesabın Yok mu?";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(0, 0);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(0, 16);
            this.labelControl6.TabIndex = 11;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(642, 128);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(199, 32);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Hesabınıza erişmek için oturum\r\naçma bilgilerinizi girin.\r\n";
            // 
            // LoginForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.MediumPurple;
            this.Appearance.Options.UseBackColor = true;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(887, 620);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.btnForgotPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblLoginTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}
