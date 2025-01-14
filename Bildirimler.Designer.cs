namespace ReviseMee
{
    partial class Bildirimler
    {
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBildirimler;
        private System.Windows.Forms.Button btnBackToMenu;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bildirimler));
            this.flowLayoutPanelBildirimler = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // flowLayoutPanelBildirimler
            // 
            this.flowLayoutPanelBildirimler.AutoScroll = true;
            this.flowLayoutPanelBildirimler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanelBildirimler.BackgroundImage")));
            this.flowLayoutPanelBildirimler.Location = new System.Drawing.Point(12, 50);
            this.flowLayoutPanelBildirimler.Name = "flowLayoutPanelBildirimler";
            this.flowLayoutPanelBildirimler.Size = new System.Drawing.Size(760, 362);
            this.flowLayoutPanelBildirimler.TabIndex = 0;
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBackToMenu.Location = new System.Drawing.Point(12, 420);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(100, 30);
            this.btnBackToMenu.TabIndex = 1;
            this.btnBackToMenu.Text = "Ana Menüye Dön";
            this.btnBackToMenu.UseVisualStyleBackColor = false;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(536, 40);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Hey,Bu Sorulara Bakma Zamanı!";
            // 
            // Bildirimler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(838, 461);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.flowLayoutPanelBildirimler);
            this.Controls.Add(this.btnBackToMenu);
            this.Name = "Bildirimler";
            this.Text = "Bildirimler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
