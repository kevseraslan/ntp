namespace ReviseMee
{
    partial class SplashScreenForm
    {
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.LabelControl lblReviseMe;
        private DevExpress.XtraEditors.LabelControl lblWelcome;
        private DevExpress.XtraEditors.SimpleButton btnStart;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreenForm));
            this.lblReviseMe = new DevExpress.XtraEditors.LabelControl();
            this.lblWelcome = new DevExpress.XtraEditors.LabelControl();
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // lblReviseMe
            // 
            this.lblReviseMe.Appearance.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold);
            this.lblReviseMe.Appearance.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblReviseMe.Appearance.Options.UseFont = true;
            this.lblReviseMe.Appearance.Options.UseForeColor = true;
            this.lblReviseMe.Appearance.Options.UseTextOptions = true;
            this.lblReviseMe.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblReviseMe.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblReviseMe.Location = new System.Drawing.Point(476, 54);
            this.lblReviseMe.Name = "lblReviseMe";
            this.lblReviseMe.Size = new System.Drawing.Size(400, 105);
            this.lblReviseMe.TabIndex = 0;
            this.lblReviseMe.Text = "Revise Me";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Appearance.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWelcome.Appearance.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblWelcome.Appearance.Options.UseFont = true;
            this.lblWelcome.Appearance.Options.UseForeColor = true;
            this.lblWelcome.Appearance.Options.UseTextOptions = true;
            this.lblWelcome.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblWelcome.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblWelcome.Location = new System.Drawing.Point(476, 185);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(400, 76);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Hoşgeldiniz!";
            // 
            // btnStart
            // 
            this.btnStart.Appearance.BackColor = System.Drawing.Color.MediumPurple;
            this.btnStart.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnStart.Appearance.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnStart.Appearance.Options.UseBackColor = true;
            this.btnStart.Appearance.Options.UseFont = true;
            this.btnStart.Appearance.Options.UseForeColor = true;
            this.btnStart.Location = new System.Drawing.Point(624, 419);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(124, 43);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Başla";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // SplashScreenForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.MediumPurple;
            this.Appearance.Options.UseBackColor = true;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(949, 620);
            this.Controls.Add(this.lblReviseMe);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreenForm_Load);
            this.ResumeLayout(false);

        }
    }
}
