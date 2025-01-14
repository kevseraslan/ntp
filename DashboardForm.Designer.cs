namespace ReviseMee
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.LabelControl label1;

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
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(150, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "Hoş Geldiniz!";
            // 
            // DashboardForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.label1);
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
        }
    }
}
