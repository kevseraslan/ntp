namespace ReviseMee
{
    partial class FavoritesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFavorites;
        private System.Windows.Forms.Button btnBackToMenu;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FavoritesForm));
            this.flowLayoutPanelFavorites = new System.Windows.Forms.FlowLayoutPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.flowLayoutPanelFavorites.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelFavorites
            // 
            this.flowLayoutPanelFavorites.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanelFavorites.BackgroundImage")));
            this.flowLayoutPanelFavorites.Controls.Add(this.labelControl1);
            this.flowLayoutPanelFavorites.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelFavorites.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelFavorites.Name = "flowLayoutPanelFavorites";
            this.flowLayoutPanelFavorites.Size = new System.Drawing.Size(800, 450);
            this.flowLayoutPanelFavorites.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(349, 51);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Favori Sorularım";
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBackToMenu.Location = new System.Drawing.Point(10, 460);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(150, 40);
            this.btnBackToMenu.TabIndex = 1;
            this.btnBackToMenu.Text = "Ana Sayfaya Dön";
            this.btnBackToMenu.UseVisualStyleBackColor = false;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // FavoritesForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.flowLayoutPanelFavorites);
            this.Controls.Add(this.btnBackToMenu);
            this.Name = "FavoritesForm";
            this.Text = "Favori Sorularım";
            this.flowLayoutPanelFavorites.ResumeLayout(false);
            this.flowLayoutPanelFavorites.PerformLayout();
            this.ResumeLayout(false);


            this.ClientSize = new System.Drawing.Size(949, 620); // Sabit boyut
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; // Kenarlık yok
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; // Ortada başlasın
            this.Text = "FAVORİ SORULAR";
          

        }

        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
