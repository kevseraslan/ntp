namespace ReviseMee
{
    partial class SolveQuestionForm
    {
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelQuestions;
        private System.Windows.Forms.Button btnBackToMenu;

        private void InitializeComponent()
        {
            this.flowLayoutPanelQuestions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanelQuestions
            // 
            this.flowLayoutPanelQuestions.AutoScroll = true;
            this.flowLayoutPanelQuestions.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelQuestions.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelQuestions.Name = "flowLayoutPanelQuestions";
            this.flowLayoutPanelQuestions.Size = new System.Drawing.Size(784, 400);
            this.flowLayoutPanelQuestions.TabIndex = 0;
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBackToMenu.Location = new System.Drawing.Point(10, 420);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(120, 30);
            this.btnBackToMenu.TabIndex = 1;
            this.btnBackToMenu.Text = "Ana Menüye Dön";
            this.btnBackToMenu.UseVisualStyleBackColor = false;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // SolveQuestionForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.flowLayoutPanelQuestions);
            this.Name = "SolveQuestionForm";
            this.Text = "Soruları Çöz";
            this.ResumeLayout(false);

        }
    }
}
