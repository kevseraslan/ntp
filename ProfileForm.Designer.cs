namespace ReviseMee
{
    partial class ProfileForm
    {
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.PictureEdit pictureEditProfile;

        private DevExpress.XtraEditors.LabelControl[] labels;
        private DevExpress.XtraEditors.TextEdit[] textEdits;
        private DevExpress.XtraEditors.SimpleButton[] editButtons;
        private DevExpress.XtraEditors.SimpleButton btnBackToMenu;

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
            int labelX = 20;
            int inputX = 150;
            int buttonX = 470;
            int top = 20;
            int spacing = 40;

            string[] fields = {
                "Kullanıcı Adı", "Şifre", "Ad", "Soyad", "Sınıf",
                "Doğum Yılı", "Alan", "Hedef", "E-posta", "Telefon Numarası",
                "Google Kimlik", "Güvenlik Sorusu"
            };

            labels = new DevExpress.XtraEditors.LabelControl[fields.Length];
            textEdits = new DevExpress.XtraEditors.TextEdit[fields.Length];
            editButtons = new DevExpress.XtraEditors.SimpleButton[fields.Length];

            for (int i = 0; i < fields.Length; i++)
            {
                // Label
                labels[i] = new DevExpress.XtraEditors.LabelControl();
                labels[i].Location = new System.Drawing.Point(labelX, top);
                labels[i].Text = fields[i] + ":";
                labels[i].Size = new System.Drawing.Size(120, 22);
                this.Controls.Add(labels[i]);

                // TextEdit
                textEdits[i] = new DevExpress.XtraEditors.TextEdit();
                textEdits[i].Location = new System.Drawing.Point(inputX, top);
                textEdits[i].Size = new System.Drawing.Size(300, 22);
                textEdits[i].Properties.ReadOnly = true;
                this.Controls.Add(textEdits[i]);

                // Düzenle Butonu
                editButtons[i] = new DevExpress.XtraEditors.SimpleButton();
                editButtons[i].Location = new System.Drawing.Point(buttonX, top);
                editButtons[i].Size = new System.Drawing.Size(80, 22);
                editButtons[i].Text = "Düzenle";
                editButtons[i].Tag = i;
                editButtons[i].Click += EditButton_Click; // Olay işleyici bağlanıyor
                this.Controls.Add(editButtons[i]);

                top += spacing; // Sonraki alan için pozisyon
            }

            // Ana Sayfa Butonu
            btnBackToMenu = new DevExpress.XtraEditors.SimpleButton();
            btnBackToMenu.Location = new System.Drawing.Point(20, top + 20); // Sayfanın altına eklemek için uygun bir konum
            btnBackToMenu.Size = new System.Drawing.Size(120, 30);
            btnBackToMenu.Text = "Ana Sayfaya Dön";
            this.btnBackToMenu.Click += new System.EventHandler(this.BtnBackToMenu_Click);

            this.Controls.Add(btnBackToMenu);

            this.ClientSize = new System.Drawing.Size(600, top + 70); // Buton için yeterli alan sağlamak amacıyla formun yüksekliğini artır
            this.Text = "Profil Düzenleme";
            this.Load += new System.EventHandler(this.ProfileForm_Load);

            this.ClientSize = new System.Drawing.Size(949, 620); // Sabit boyut
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; // Kenarlık yok
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; // Ortada başlasın
            this.Text = "FAVORİ SORULAR";

        }
    }
}