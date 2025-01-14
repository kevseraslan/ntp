namespace ReviseMee
{
    partial class MenuRibbonForm
    {
        private System.ComponentModel.IContainer components = null;
         private System.Windows.Forms.WebBrowser webBrowser;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuRibbonForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnReminders = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnNotifications = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnFavorites = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAddQuestion = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSolveQuestions = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnProfile = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAI = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnProgress = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.flowLayoutPanelCourses = new System.Windows.Forms.FlowLayoutPanel();
            this.calendarControl1 = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.timeEdit1 = new DevExpress.XtraEditors.TimeEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnChatBot = new System.Windows.Forms.Button();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(949, 620); // Sabit boyut
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; // Kenarlık yok
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; // Ortada başlasın
            this.Text = "Ana Menü";
            this.Appearance.BackColor = System.Drawing.Color.MediumPurple; // Arka plan rengi
            this.Appearance.Options.UseBackColor = true;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barBtnReminders,
            this.barBtnNotifications,
            this.barBtnFavorites,
            this.barBtnAddQuestion,
            this.barBtnSolveQuestions,
            this.barBtnProfile,
            this.barBtnAI,
            this.barBtnProgress});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 11;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1445, 178);
            // 
            // barBtnReminders
            // 
            this.barBtnReminders.Caption = "Hatırlatıcılar";
            this.barBtnReminders.Id = 1;
            this.barBtnReminders.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnReminders.ImageOptions.Image")));
            this.barBtnReminders.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnReminders.ImageOptions.LargeImage")));
            this.barBtnReminders.Name = "barBtnReminders";
            this.barBtnReminders.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnReminders_ItemClick);
            // 
            // barBtnNotifications
            // 
            this.barBtnNotifications.Caption = "Bildirimler";
            this.barBtnNotifications.Id = 2;
            this.barBtnNotifications.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnNotifications.ImageOptions.Image")));
            this.barBtnNotifications.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnNotifications.ImageOptions.LargeImage")));
            this.barBtnNotifications.Name = "barBtnNotifications";
            this.barBtnNotifications.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnNotifications_ItemClick);
            // 
            // barBtnFavorites
            // 
            this.barBtnFavorites.Caption = "Favori Sorular";
            this.barBtnFavorites.Id = 3;
            this.barBtnFavorites.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnFavorites.ImageOptions.Image")));
            this.barBtnFavorites.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnFavorites.ImageOptions.LargeImage")));
            this.barBtnFavorites.Name = "barBtnFavorites";
            this.barBtnFavorites.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnFavorites_ItemClick);
            // 
            // barBtnAddQuestion
            // 
            this.barBtnAddQuestion.Caption = "Soru Ekle";
            this.barBtnAddQuestion.Id = 4;
            this.barBtnAddQuestion.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnAddQuestion.ImageOptions.Image")));
            this.barBtnAddQuestion.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnAddQuestion.ImageOptions.LargeImage")));
            this.barBtnAddQuestion.Name = "barBtnAddQuestion";
            this.barBtnAddQuestion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAddQuestion_ItemClick);
            // 
            // barBtnSolveQuestions
            // 
            this.barBtnSolveQuestions.Caption = "Soruları Çöz";
            this.barBtnSolveQuestions.Id = 5;
            this.barBtnSolveQuestions.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnSolveQuestions.ImageOptions.Image")));
            this.barBtnSolveQuestions.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnSolveQuestions.ImageOptions.LargeImage")));
            this.barBtnSolveQuestions.Name = "barBtnSolveQuestions";
            this.barBtnSolveQuestions.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSolveQuestions_ItemClick);
            // 
            // barBtnProfile
            // 
            this.barBtnProfile.Caption = "Profilim";
            this.barBtnProfile.Id = 6;
            this.barBtnProfile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnProfile.ImageOptions.Image")));
            this.barBtnProfile.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnProfile.ImageOptions.LargeImage")));
            this.barBtnProfile.Name = "barBtnProfile";
            this.barBtnProfile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnProfile_ItemClick);
            // 
            // barBtnAI
            // 
            this.barBtnAI.Caption = "Yapay Zeka";
            this.barBtnAI.Id = 7;
            this.barBtnAI.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnAI.ImageOptions.Image")));
            this.barBtnAI.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnAI.ImageOptions.LargeImage")));
            this.barBtnAI.Name = "barBtnAI";
            this.barBtnAI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAI_ItemClick);
            // 
            // barBtnProgress
            // 
            this.barBtnProgress.Caption = "Gelişim Takibi";
            this.barBtnProgress.Id = 8;
            this.barBtnProgress.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnProgress.ImageOptions.Image")));
            this.barBtnProgress.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnProgress.ImageOptions.LargeImage")));
            this.barBtnProgress.Name = "barBtnProgress";
            this.barBtnProgress.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnProgress_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6,
            this.ribbonPageGroup7,
            this.ribbonPageGroup8,
            this.ribbonPageGroup9});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Ana Menü";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnNotifications);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "İşlemler";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnReminders);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barBtnSolveQuestions);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barBtnAddQuestion);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barBtnFavorites);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.barBtnAI);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "ribbonPageGroup6";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ribbonPageGroup7.ImageOptions.SvgImage")));
            this.ribbonPageGroup7.ItemLinks.Add(this.barBtnProgress);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "ribbonPageGroup7";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.barBtnProfile);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "ribbonPageGroup8";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup9.ImageOptions.Image")));
            this.ribbonPageGroup9.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ribbonPageGroup9.ImageOptions.SvgImage")));
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.Text = "ribbonPageGroup9";
            // 
            // flowLayoutPanelCourses
            // 
            this.flowLayoutPanelCourses.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelCourses.Location = new System.Drawing.Point(12, 173);
            this.flowLayoutPanelCourses.Name = "flowLayoutPanelCourses";
            this.flowLayoutPanelCourses.Size = new System.Drawing.Size(631, 408);
            this.flowLayoutPanelCourses.TabIndex = 1;
            this.flowLayoutPanelCourses.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelCourses_Paint);
            // 
            // calendarControl1
            // 
            this.calendarControl1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calendarControl1.Location = new System.Drawing.Point(1145, 97);
            this.calendarControl1.Name = "calendarControl1";
            this.calendarControl1.Size = new System.Drawing.Size(278, 270);
            this.calendarControl1.TabIndex = 4;
            // 
            // timeEdit1
            // 
            this.timeEdit1.EditValue = new System.DateTime(2025, 1, 13, 0, 0, 0, 0);
            this.timeEdit1.Location = new System.Drawing.Point(1155, 69);
            this.timeEdit1.MenuManager = this.ribbonControl1;
            this.timeEdit1.Name = "timeEdit1";
            this.timeEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEdit1.Size = new System.Drawing.Size(244, 22);
            this.timeEdit1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(1180, 453);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(203, 46);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "REVİSE ME";
            // 
            // btnChatBot
            // 
            this.btnChatBot.Location = new System.Drawing.Point(989, 142);
            this.btnChatBot.Name = "btnChatBot";
            this.btnChatBot.Size = new System.Drawing.Size(150, 36);
            this.btnChatBot.TabIndex = 0;
            this.btnChatBot.Text = "ChatBot";
            this.btnChatBot.UseVisualStyleBackColor = true;
            this.btnChatBot.Click += new System.EventHandler(this.btnChatBot_Click);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Profilim";
            this.barButtonItem1.Id = 6;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1004, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 83);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // MenuRibbonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(1445, 645);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnChatBot);
            this.Controls.Add(this.calendarControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.timeEdit1);
            this.Controls.Add(this.flowLayoutPanelCourses);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "MenuRibbonForm";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Ana Menü";
            this.Load += new System.EventHandler(this.MenuRibbonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barBtnReminders;
        private DevExpress.XtraBars.BarButtonItem barBtnNotifications;
        private DevExpress.XtraBars.BarButtonItem barBtnFavorites;
        private DevExpress.XtraBars.BarButtonItem barBtnAddQuestion;
        private DevExpress.XtraBars.BarButtonItem barBtnSolveQuestions;
        private DevExpress.XtraBars.BarButtonItem barBtnProfile;
        private DevExpress.XtraBars.BarButtonItem barBtnAI;
        private System.Windows.Forms.Button btnChatBot;
        private DevExpress.XtraBars.BarButtonItem barBtnProgress;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCourses;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraEditors.Controls.CalendarControl calendarControl1;
        private DevExpress.XtraEditors.TimeEdit timeEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
