namespace ReviseMee
{
    partial class QuestionForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.ComboBox cmbDifficulty;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.PictureBox picQuestionImage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.Label lblQuestionTitle; // "Soru Hakkında" etiketi

        // Dispose metodunu unutmuyoruz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionForm));
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.cmbDifficulty = new System.Windows.Forms.ComboBox();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.picQuestionImage = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.lblQuestionTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picQuestionImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategory.Location = new System.Drawing.Point(56, 245);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(74, 17);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmbCategory.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(136, 245);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(200, 24);
            this.cmbCategory.TabIndex = 1;
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDifficulty.Location = new System.Drawing.Point(2, 275);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(128, 17);
            this.lblDifficulty.TabIndex = 2;
            this.lblDifficulty.Text = "Zorluk Derecesi:";
            this.lblDifficulty.Click += new System.EventHandler(this.lblDifficulty_Click);
            // 
            // cmbDifficulty
            // 
            this.cmbDifficulty.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmbDifficulty.FormattingEnabled = true;
            this.cmbDifficulty.Items.AddRange(new object[] {
            "Kolay",
            "Orta",
            "Zor"});
            this.cmbDifficulty.Location = new System.Drawing.Point(136, 275);
            this.cmbDifficulty.Name = "cmbDifficulty";
            this.cmbDifficulty.Size = new System.Drawing.Size(200, 24);
            this.cmbDifficulty.TabIndex = 3;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSelectImage.Location = new System.Drawing.Point(136, 305);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(200, 30);
            this.btnSelectImage.TabIndex = 5;
            this.btnSelectImage.Text = "Görsel Seç";
            this.btnSelectImage.UseVisualStyleBackColor = false;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // picQuestionImage
            // 
            this.picQuestionImage.Location = new System.Drawing.Point(136, 351);
            this.picQuestionImage.Name = "picQuestionImage";
            this.picQuestionImage.Size = new System.Drawing.Size(200, 100);
            this.picQuestionImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQuestionImage.TabIndex = 6;
            this.picQuestionImage.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSave.Location = new System.Drawing.Point(188, 457);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 30);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(36, 217);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(300, 22);
            this.txtQuestion.TabIndex = 4;
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBackToMenu.Location = new System.Drawing.Point(314, 483);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(140, 30);
            this.btnBackToMenu.TabIndex = 8;
            this.btnBackToMenu.Text = "Ana Sayfaya Dön";
            this.btnBackToMenu.UseVisualStyleBackColor = false;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // lblQuestionTitle
            // 
            this.lblQuestionTitle.AutoSize = true;
            this.lblQuestionTitle.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblQuestionTitle.Location = new System.Drawing.Point(32, 193);
            this.lblQuestionTitle.Name = "lblQuestionTitle";
            this.lblQuestionTitle.Size = new System.Drawing.Size(141, 21);
            this.lblQuestionTitle.TabIndex = 9;
            this.lblQuestionTitle.Text = "Soru Hakkında:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(136, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 192);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // QuestionForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(466, 515);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblQuestionTitle);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.picQuestionImage);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.cmbDifficulty);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtQuestion);
            this.Name = "QuestionForm";
            this.Text = "Soru Ekle";
            this.Load += new System.EventHandler(this.QuestionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picQuestionImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();

            this.ClientSize = new System.Drawing.Size(949, 620); // Sabit boyut
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; // Kenarlık yok
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; // Ortada başlasın
            this.Text = "FAVORİ SORULAR";

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
