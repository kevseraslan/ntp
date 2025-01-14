namespace ReviseMee
{
    partial class ReminderForm
    {
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelReminders;
        private System.Windows.Forms.Button btnBackToMenu;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReminderForm));
            this.flowLayoutPanelReminders = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanelReminders
            // 
            this.flowLayoutPanelReminders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelReminders.AutoScroll = true;
            this.flowLayoutPanelReminders.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanelReminders.Name = "flowLayoutPanelReminders";
            this.flowLayoutPanelReminders.Size = new System.Drawing.Size(760, 400);
            this.flowLayoutPanelReminders.TabIndex = 0;
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
            // ReminderForm
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.flowLayoutPanelReminders);
            this.Name = "ReminderForm";
            this.Text = "Hatırlatıcılar";
            this.ResumeLayout(false);

        }
    }
}
