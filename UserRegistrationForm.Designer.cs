namespace ReviseMee
{
    partial class UserRegistrationForm
    {
        private DevExpress.XtraEditors.TextEdit textUserName;
        private DevExpress.XtraEditors.TextEdit textPassword;
        private DevExpress.XtraEditors.TextEdit textName;
        private DevExpress.XtraEditors.TextEdit textSurname;
        private DevExpress.XtraEditors.TextEdit textClass;
        private DevExpress.XtraEditors.TextEdit textYearOfBirth;
        private DevExpress.XtraEditors.TextEdit textArea;
        private DevExpress.XtraEditors.TextEdit textAim;
        private DevExpress.XtraEditors.TextEdit textEmail;
        private DevExpress.XtraEditors.TextEdit textPhone;
        private DevExpress.XtraEditors.TextEdit textGoogleAuthId;
        private DevExpress.XtraEditors.TextEdit textSecurityQuestion;
        private DevExpress.XtraEditors.SimpleButton btnRegister;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRegistrationForm));
            this.textUserName = new DevExpress.XtraEditors.TextEdit();
            this.textPassword = new DevExpress.XtraEditors.TextEdit();
            this.textName = new DevExpress.XtraEditors.TextEdit();
            this.textSurname = new DevExpress.XtraEditors.TextEdit();
            this.textClass = new DevExpress.XtraEditors.TextEdit();
            this.textYearOfBirth = new DevExpress.XtraEditors.TextEdit();
            this.textArea = new DevExpress.XtraEditors.TextEdit();
            this.textAim = new DevExpress.XtraEditors.TextEdit();
            this.textEmail = new DevExpress.XtraEditors.TextEdit();
            this.textPhone = new DevExpress.XtraEditors.TextEdit();
            this.textGoogleAuthId = new DevExpress.XtraEditors.TextEdit();
            this.textSecurityQuestion = new DevExpress.XtraEditors.TextEdit();
            this.btnRegister = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.textUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textClass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textYearOfBirth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textArea.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textGoogleAuthId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSecurityQuestion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // textUserName
            // 
            this.behaviorManager1.SetBehaviors(this.textUserName, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.Behaviors.Common.FileIconBehavior.Create(typeof(DevExpress.XtraEditors.Behaviors.FileIconBehaviorSourceForTextEdit), DevExpress.Utils.Behaviors.Common.FileIconSize.Small, null, null)))});
            this.textUserName.EditValue = "";
            this.textUserName.Location = new System.Drawing.Point(537, 34);
            this.textUserName.Name = "textUserName";
            this.textUserName.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textUserName.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.textUserName.Properties.Appearance.Options.UseBackColor = true;
            this.textUserName.Properties.Appearance.Options.UseForeColor = true;
            this.textUserName.Properties.NullText = "Kullanıcı Adı";
            this.textUserName.Size = new System.Drawing.Size(200, 22);
            this.textUserName.TabIndex = 0;
            this.textUserName.EditValueChanged += new System.EventHandler(this.textUserName_EditValueChanged);
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(537, 67);
            this.textPassword.Name = "textPassword";
            this.textPassword.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textPassword.Properties.Appearance.Options.UseBackColor = true;
            this.textPassword.Properties.NullText = "Şifre";
            this.textPassword.Properties.UseSystemPasswordChar = true;
            this.textPassword.Size = new System.Drawing.Size(200, 22);
            this.textPassword.TabIndex = 1;
            // 
            // textName
            // 
            this.textName.EditValue = "";
            this.textName.Location = new System.Drawing.Point(537, 97);
            this.textName.Name = "textName";
            this.textName.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textName.Properties.Appearance.Options.UseBackColor = true;
            this.textName.Properties.NullText = "Ad";
            this.textName.Size = new System.Drawing.Size(200, 22);
            this.textName.TabIndex = 2;
            // 
            // textSurname
            // 
            this.textSurname.EditValue = "";
            this.textSurname.Location = new System.Drawing.Point(537, 127);
            this.textSurname.Name = "textSurname";
            this.textSurname.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textSurname.Properties.Appearance.Options.UseBackColor = true;
            this.textSurname.Properties.NullText = "Soyad";
            this.textSurname.Size = new System.Drawing.Size(200, 22);
            this.textSurname.TabIndex = 3;
            // 
            // textClass
            // 
            this.textClass.EditValue = "";
            this.textClass.Location = new System.Drawing.Point(537, 157);
            this.textClass.Name = "textClass";
            this.textClass.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textClass.Properties.Appearance.Options.UseBackColor = true;
            this.textClass.Properties.NullText = "Sınıf";
            this.textClass.Size = new System.Drawing.Size(200, 22);
            this.textClass.TabIndex = 4;
            // 
            // textYearOfBirth
            // 
            this.textYearOfBirth.EditValue = "";
            this.textYearOfBirth.Location = new System.Drawing.Point(537, 187);
            this.textYearOfBirth.Name = "textYearOfBirth";
            this.textYearOfBirth.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textYearOfBirth.Properties.Appearance.Options.UseBackColor = true;
            this.textYearOfBirth.Properties.NullText = "Doğum Yılı";
            this.textYearOfBirth.Size = new System.Drawing.Size(200, 22);
            this.textYearOfBirth.TabIndex = 5;
            // 
            // textArea
            // 
            this.textArea.EditValue = "";
            this.textArea.Location = new System.Drawing.Point(537, 217);
            this.textArea.Name = "textArea";
            this.textArea.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textArea.Properties.Appearance.Options.UseBackColor = true;
            this.textArea.Properties.NullText = "Alan";
            this.textArea.Size = new System.Drawing.Size(200, 22);
            this.textArea.TabIndex = 6;
            // 
            // textAim
            // 
            this.textAim.EditValue = "";
            this.textAim.Location = new System.Drawing.Point(537, 247);
            this.textAim.Name = "textAim";
            this.textAim.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textAim.Properties.Appearance.Options.UseBackColor = true;
            this.textAim.Properties.NullText = "Hedef";
            this.textAim.Size = new System.Drawing.Size(200, 22);
            this.textAim.TabIndex = 7;
            // 
            // textEmail
            // 
            this.textEmail.EditValue = "";
            this.textEmail.Location = new System.Drawing.Point(537, 277);
            this.textEmail.Name = "textEmail";
            this.textEmail.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textEmail.Properties.Appearance.Options.UseBackColor = true;
            this.textEmail.Properties.NullText = "E-posta";
            this.textEmail.Size = new System.Drawing.Size(200, 22);
            this.textEmail.TabIndex = 8;
            // 
            // textPhone
            // 
            this.textPhone.EditValue = "";
            this.textPhone.Location = new System.Drawing.Point(537, 307);
            this.textPhone.Name = "textPhone";
            this.textPhone.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textPhone.Properties.Appearance.Options.UseBackColor = true;
            this.textPhone.Properties.NullText = "Telefon Numarası";
            this.textPhone.Size = new System.Drawing.Size(200, 22);
            this.textPhone.TabIndex = 9;
            // 
            // textGoogleAuthId
            // 
            this.textGoogleAuthId.EditValue = "";
            this.textGoogleAuthId.Location = new System.Drawing.Point(537, 337);
            this.textGoogleAuthId.Name = "textGoogleAuthId";
            this.textGoogleAuthId.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textGoogleAuthId.Properties.Appearance.Options.UseBackColor = true;
            this.textGoogleAuthId.Properties.NullText = "Google Kimliği (Opsiyonel)";
            this.textGoogleAuthId.Size = new System.Drawing.Size(200, 22);
            this.textGoogleAuthId.TabIndex = 10;
            // 
            // textSecurityQuestion
            // 
            this.textSecurityQuestion.EditValue = "";
            this.textSecurityQuestion.Location = new System.Drawing.Point(537, 367);
            this.textSecurityQuestion.Name = "textSecurityQuestion";
            this.textSecurityQuestion.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textSecurityQuestion.Properties.Appearance.Options.UseBackColor = true;
            this.textSecurityQuestion.Properties.NullText = "Güvenlik Sorusu (Anne Kızlık Soyadı)";
            this.textSecurityQuestion.Size = new System.Drawing.Size(200, 22);
            this.textSecurityQuestion.TabIndex = 11;
            // 
            // btnRegister
            // 
            this.btnRegister.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRegister.Appearance.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnRegister.Appearance.Options.UseFont = true;
            this.btnRegister.Appearance.Options.UseForeColor = true;
            this.btnRegister.Location = new System.Drawing.Point(643, 417);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(94, 29);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "Kayıt Ol";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(447, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 16);
            this.labelControl1.TabIndex = 13;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(466, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 16);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Şifre:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(466, 100);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(23, 16);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Ad:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(463, 133);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 16);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "SoyAd:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(466, 160);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(32, 16);
            this.labelControl5.TabIndex = 17;
            this.labelControl5.Text = "Sınıf:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(463, 190);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(66, 16);
            this.labelControl6.TabIndex = 18;
            this.labelControl6.Text = "Doğumyılı:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(463, 220);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(34, 16);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "Alan:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(463, 250);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(43, 16);
            this.labelControl8.TabIndex = 20;
            this.labelControl8.Text = "Hedef:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(463, 283);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(55, 16);
            this.labelControl9.TabIndex = 21;
            this.labelControl9.Text = "E-posta:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(421, 310);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(115, 16);
            this.labelControl10.TabIndex = 22;
            this.labelControl10.Text = "Telefon numarası:";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(475, 340);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(43, 16);
            this.labelControl11.TabIndex = 23;
            this.labelControl11.Text = "Google";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(432, 370);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(106, 16);
            this.labelControl12.TabIndex = 24;
            this.labelControl12.Text = "Güvenlik sorusu:";
            this.labelControl12.Click += new System.EventHandler(this.labelControl12_Click);
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(453, 40);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(81, 16);
            this.labelControl13.TabIndex = 25;
            this.labelControl13.Text = "Kullanıcı Adı:";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold);
            this.labelControl15.Appearance.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Appearance.Options.UseForeColor = true;
            this.labelControl15.Location = new System.Drawing.Point(27, 12);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(182, 60);
            this.labelControl15.TabIndex = 27;
            this.labelControl15.Text = "Üye Ol!";
            // 
            // UserRegistrationForm
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Appearance.Options.UseBackColor = true;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(764, 500);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.textClass);
            this.Controls.Add(this.textYearOfBirth);
            this.Controls.Add(this.textArea);
            this.Controls.Add(this.textAim);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textGoogleAuthId);
            this.Controls.Add(this.textSecurityQuestion);
            this.Controls.Add(this.btnRegister);
            this.Name = "UserRegistrationForm";
            ((System.ComponentModel.ISupportInitialize)(this.textUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textClass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textYearOfBirth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textArea.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textGoogleAuthId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSecurityQuestion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.ComponentModel.IContainer components;
    }
}
