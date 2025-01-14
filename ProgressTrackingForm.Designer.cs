namespace ReviseMee
{
    partial class ProgressTrackingForm
    {
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCharts;
        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.Label lblTitle;

        private void InitializeComponent()
        {
            this.flowLayoutPanelCharts = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanelCharts
            // 
            this.flowLayoutPanelCharts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelCharts.AutoScroll = true;
            this.flowLayoutPanelCharts.Location = new System.Drawing.Point(12, 50);
            this.flowLayoutPanelCharts.Name = "flowLayoutPanelCharts";
            this.flowLayoutPanelCharts.Size = new System.Drawing.Size(760, 360);
            this.flowLayoutPanelCharts.TabIndex = 0;
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBackToMenu.Location = new System.Drawing.Point(12, 420);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(120, 30);
            this.btnBackToMenu.TabIndex = 1;
            this.btnBackToMenu.Text = "Ana Menüye Dön";
            this.btnBackToMenu.UseVisualStyleBackColor = false;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitle.Location = new System.Drawing.Point(300, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(204, 33);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Gelişim Analiz";
            // 
            // ProgressTrackingForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.flowLayoutPanelCharts);
            this.Controls.Add(this.btnBackToMenu);
            this.Name = "ProgressTrackingForm";
            this.Text = "Gelişim Takibi";
            this.Load += new System.EventHandler(this.ProgressTrackingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
