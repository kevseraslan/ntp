namespace ReviseMee
{
    partial class QuestionListForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelQuestions;

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
            this.lblCourseName = new System.Windows.Forms.Label();
            this.flowLayoutPanelQuestions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCourseName
            // 
            this.lblCourseName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCourseName.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblCourseName.Location = new System.Drawing.Point(0, 0);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(914, 40);
            this.lblCourseName.TabIndex = 0;
            this.lblCourseName.Text = "Ders: ";
            this.lblCourseName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelQuestions
            // 
            this.flowLayoutPanelQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelQuestions.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutPanelQuestions.Name = "flowLayoutPanelQuestions";
            this.flowLayoutPanelQuestions.Size = new System.Drawing.Size(914, 360);
            this.flowLayoutPanelQuestions.TabIndex = 1;
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBackToMain.Location = new System.Drawing.Point(0, 400);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(914, 50);
            this.btnBackToMain.TabIndex = 2;
            this.btnBackToMain.Text = "Ana Sayfaya Dön";
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // QuestionListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 450);
            this.Controls.Add(this.flowLayoutPanelQuestions);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.lblCourseName);
            this.Name = "QuestionListForm";
            this.Text = "Sorular";
            this.Load += new System.EventHandler(this.QuestionListForm_Load);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnBackToMain;
    }
}
