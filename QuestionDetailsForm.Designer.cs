namespace ReviseMee
{
    partial class QuestionDetailsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblQuestionContent;
        private System.Windows.Forms.PictureBox pictureBoxQuestion;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnSaveNote;
        private System.Windows.Forms.Button btnAddToFavorites;
        private System.Windows.Forms.Button btnSkipQuestion;
        private System.Windows.Forms.Button btnDeleteQuestion;
        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.TextBox txtSavedNote; // Daha önce kaydedilen notlar için alan
        private System.Windows.Forms.Label lblSavedNotes; // "Notlarım" başlığı için label

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionDetailsForm));
            this.lblQuestionContent = new System.Windows.Forms.Label();
            this.pictureBoxQuestion = new System.Windows.Forms.PictureBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnSaveNote = new System.Windows.Forms.Button();
            this.btnAddToFavorites = new System.Windows.Forms.Button();
            this.btnSkipQuestion = new System.Windows.Forms.Button();
            this.btnDeleteQuestion = new System.Windows.Forms.Button();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.txtSavedNote = new System.Windows.Forms.TextBox();
            this.lblSavedNotes = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuestionContent
            // 
            this.lblQuestionContent.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblQuestionContent.Location = new System.Drawing.Point(23, 20);
            this.lblQuestionContent.Name = "lblQuestionContent";
            this.lblQuestionContent.Size = new System.Drawing.Size(869, 100);
            this.lblQuestionContent.TabIndex = 0;
            this.lblQuestionContent.Text = "Soru İçeriği";
            // 
            // pictureBoxQuestion
            // 
            this.pictureBoxQuestion.Location = new System.Drawing.Point(23, 56);
            this.pictureBoxQuestion.Name = "pictureBoxQuestion";
            this.pictureBoxQuestion.Size = new System.Drawing.Size(776, 311);
            this.pictureBoxQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxQuestion.TabIndex = 1;
            this.pictureBoxQuestion.TabStop = false;
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtNote.Location = new System.Drawing.Point(23, 400);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(342, 100);
            this.txtNote.TabIndex = 2;
            // 
            // btnSaveNote
            // 
            this.btnSaveNote.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSaveNote.Location = new System.Drawing.Point(23, 520);
            this.btnSaveNote.Name = "btnSaveNote";
            this.btnSaveNote.Size = new System.Drawing.Size(187, 40);
            this.btnSaveNote.TabIndex = 3;
            this.btnSaveNote.Text = "Notu Kaydet";
            this.btnSaveNote.UseVisualStyleBackColor = false;
            this.btnSaveNote.Click += new System.EventHandler(this.btnSaveNote_Click);
            // 
            // btnAddToFavorites
            // 
            this.btnAddToFavorites.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAddToFavorites.Location = new System.Drawing.Point(267, 520);
            this.btnAddToFavorites.Name = "btnAddToFavorites";
            this.btnAddToFavorites.Size = new System.Drawing.Size(188, 40);
            this.btnAddToFavorites.TabIndex = 4;
            this.btnAddToFavorites.Text = "Favorilere Ekle";
            this.btnAddToFavorites.UseVisualStyleBackColor = false;
            this.btnAddToFavorites.Click += new System.EventHandler(this.btnAddToFavorites_Click);
            // 
            // btnSkipQuestion
            // 
            this.btnSkipQuestion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSkipQuestion.Location = new System.Drawing.Point(528, 520);
            this.btnSkipQuestion.Name = "btnSkipQuestion";
            this.btnSkipQuestion.Size = new System.Drawing.Size(171, 40);
            this.btnSkipQuestion.TabIndex = 5;
            this.btnSkipQuestion.Text = "Soru Atla";
            this.btnSkipQuestion.UseVisualStyleBackColor = false;
            this.btnSkipQuestion.Click += new System.EventHandler(this.btnSkipQuestion_Click);
            // 
            // btnDeleteQuestion
            // 
            this.btnDeleteQuestion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDeleteQuestion.Location = new System.Drawing.Point(721, 520);
            this.btnDeleteQuestion.Name = "btnDeleteQuestion";
            this.btnDeleteQuestion.Size = new System.Drawing.Size(171, 40);
            this.btnDeleteQuestion.TabIndex = 6;
            this.btnDeleteQuestion.Text = "Soruyu Sil";
            this.btnDeleteQuestion.UseVisualStyleBackColor = false;
            this.btnDeleteQuestion.Click += new System.EventHandler(this.btnDeleteQuestion_Click);
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBackToMenu.Location = new System.Drawing.Point(966, 520);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(171, 40);
            this.btnBackToMenu.TabIndex = 7;
            this.btnBackToMenu.Text = "Ana Menüye Dön";
            this.btnBackToMenu.UseVisualStyleBackColor = false;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // txtSavedNote
            // 
            this.txtSavedNote.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtSavedNote.Location = new System.Drawing.Point(457, 400);
            this.txtSavedNote.Multiline = true;
            this.txtSavedNote.Name = "txtSavedNote";
            this.txtSavedNote.ReadOnly = true;
            this.txtSavedNote.Size = new System.Drawing.Size(342, 100);
            this.txtSavedNote.TabIndex = 8;
            // 
            // lblSavedNotes
            // 
            this.lblSavedNotes.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblSavedNotes.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblSavedNotes.Location = new System.Drawing.Point(456, 377);
            this.lblSavedNotes.Name = "lblSavedNotes";
            this.lblSavedNotes.Size = new System.Drawing.Size(343, 20);
            this.lblSavedNotes.TabIndex = 9;
            this.lblSavedNotes.Text = "Notlarım";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(208, 520);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 52);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(457, 520);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 38);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(898, 520);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 42);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1143, 520);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 52);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(19, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Not Gir";
            // 
            // QuestionDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1256, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSavedNotes);
            this.Controls.Add(this.txtSavedNote);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.btnDeleteQuestion);
            this.Controls.Add(this.btnSkipQuestion);
            this.Controls.Add(this.btnAddToFavorites);
            this.Controls.Add(this.btnSaveNote);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.pictureBoxQuestion);
            this.Controls.Add(this.lblQuestionContent);
            this.Name = "QuestionDetailsForm";
            this.Text = "Soru Detayları";
            this.Load += new System.EventHandler(this.QuestionDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
    }
}
