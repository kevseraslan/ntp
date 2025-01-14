namespace ReviseMee
{
    partial class ForgotPasswordForm
    {
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.LabelControl lblSecurityPrompt; // Güvenlik sorusu etiketi

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordForm));
            this.lblSecurityPrompt = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnUpdatePassword = new DevExpress.XtraEditors.SimpleButton();
            this.txtNewPassword = new DevExpress.XtraEditors.TextEdit();
            this.btnSubmitAnswer = new DevExpress.XtraEditors.SimpleButton();
            this.txtSecurityAnswer = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSecurityAnswer.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSecurityPrompt
            // 
            this.lblSecurityPrompt.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblSecurityPrompt.Appearance.Options.UseFont = true;
            this.lblSecurityPrompt.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblSecurityPrompt.Location = new System.Drawing.Point(543, 126);
            this.lblSecurityPrompt.Name = "lblSecurityPrompt";
            this.lblSecurityPrompt.Size = new System.Drawing.Size(234, 21);
            this.lblSecurityPrompt.TabIndex = 0;
            this.lblSecurityPrompt.Text = "Anne kızlık soyadınızı girin:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(364, 51);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Şifremi Unuttum!";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(543, 293);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(152, 21);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Yeni şifre oluştur:";
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdatePassword.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdatePassword.Appearance.Options.UseFont = true;
            this.btnUpdatePassword.Appearance.Options.UseForeColor = true;
            this.btnUpdatePassword.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdatePassword.ImageOptions.Image")));
            this.btnUpdatePassword.Location = new System.Drawing.Point(639, 373);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(166, 30);
            this.btnUpdatePassword.TabIndex = 2;
            this.btnUpdatePassword.Text = "Şifreyi Güncelle";
            this.btnUpdatePassword.Click += new System.EventHandler(this.btnUpdatePassword_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(543, 327);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Properties.Appearance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtNewPassword.Properties.Appearance.Options.UseBackColor = true;
            this.txtNewPassword.Properties.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(262, 22);
            this.txtNewPassword.TabIndex = 1;
            // 
            // btnSubmitAnswer
            // 
            this.btnSubmitAnswer.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSubmitAnswer.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnSubmitAnswer.Appearance.Options.UseFont = true;
            this.btnSubmitAnswer.Appearance.Options.UseForeColor = true;
            this.btnSubmitAnswer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSubmitAnswer.ImageOptions.Image")));
            this.btnSubmitAnswer.Location = new System.Drawing.Point(639, 205);
            this.btnSubmitAnswer.Name = "btnSubmitAnswer";
            this.btnSubmitAnswer.Size = new System.Drawing.Size(166, 30);
            this.btnSubmitAnswer.TabIndex = 2;
            this.btnSubmitAnswer.Text = "Yanıtı Gönder";
            this.btnSubmitAnswer.Click += new System.EventHandler(this.btnSubmitAnswer_Click);
            // 
            // txtSecurityAnswer
            // 
            this.txtSecurityAnswer.Location = new System.Drawing.Point(543, 163);
            this.txtSecurityAnswer.Name = "txtSecurityAnswer";
            this.txtSecurityAnswer.Properties.Appearance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtSecurityAnswer.Properties.Appearance.Options.UseBackColor = true;
            this.txtSecurityAnswer.Properties.NullText = "Cevabınızı Girin...";
            this.txtSecurityAnswer.Size = new System.Drawing.Size(267, 22);
            this.txtSecurityAnswer.TabIndex = 1;
            this.txtSecurityAnswer.EditValueChanged += new System.EventHandler(this.txtSecurityAnswer_EditValueChanged);
            // 
            // ForgotPasswordForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.Ivory;
            this.Appearance.Options.UseBackColor = true;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(817, 653);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnUpdatePassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.btnSubmitAnswer);
            this.Controls.Add(this.txtSecurityAnswer);
            this.Controls.Add(this.lblSecurityPrompt);
            this.Name = "ForgotPasswordForm";
            this.Text = "Şifremi Unuttum:";
            this.Load += new System.EventHandler(this.ForgotPasswordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSecurityAnswer.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnUpdatePassword;
        private DevExpress.XtraEditors.TextEdit txtNewPassword;
        private DevExpress.XtraEditors.SimpleButton btnSubmitAnswer;
        private DevExpress.XtraEditors.TextEdit txtSecurityAnswer;
    }
}
