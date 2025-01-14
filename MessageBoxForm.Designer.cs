namespace ReviseMee
{
    partial class MessageBoxForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblMotivationalHeader; // Yeni eklenen etiket
        private System.Windows.Forms.Label lblMotivationalQuote;
        private System.Windows.Forms.Label lblChatPrompt;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox txtResponse;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxForm));
            this.lblMotivationalHeader = new System.Windows.Forms.Label();
            this.lblMotivationalQuote = new System.Windows.Forms.Label();
            this.lblChatPrompt = new System.Windows.Forms.Label();
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtResponse = new System.Windows.Forms.RichTextBox();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMotivationalHeader
            // 
            this.lblMotivationalHeader.AutoSize = true;
            this.lblMotivationalHeader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblMotivationalHeader.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblMotivationalHeader.Location = new System.Drawing.Point(20, 10);
            this.lblMotivationalHeader.Name = "lblMotivationalHeader";
            this.lblMotivationalHeader.Size = new System.Drawing.Size(253, 24);
            this.lblMotivationalHeader.TabIndex = 7;
            this.lblMotivationalHeader.Text = "Günün Motivasyon Sözü";
            // 
            // lblMotivationalQuote
            // 
            this.lblMotivationalQuote.AutoSize = true;
            this.lblMotivationalQuote.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Italic);
            this.lblMotivationalQuote.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblMotivationalQuote.Location = new System.Drawing.Point(20, 55);
            this.lblMotivationalQuote.Name = "lblMotivationalQuote";
            this.lblMotivationalQuote.Size = new System.Drawing.Size(350, 21);
            this.lblMotivationalQuote.TabIndex = 6;
            this.lblMotivationalQuote.Text = "Her gün yeni bir başlangıçtır! Hadi başlayalım!";
            // 
            // lblChatPrompt
            // 
            this.lblChatPrompt.AutoSize = true;
            this.lblChatPrompt.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblChatPrompt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblChatPrompt.Location = new System.Drawing.Point(16, 141);
            this.lblChatPrompt.Name = "lblChatPrompt";
            this.lblChatPrompt.Size = new System.Drawing.Size(191, 21);
            this.lblChatPrompt.TabIndex = 5;
            this.lblChatPrompt.Text = "Haydi sohbet edelim!";
            // 
            // txtUserInput
            // 
            this.txtUserInput.ForeColor = System.Drawing.Color.Gray;
            this.txtUserInput.Location = new System.Drawing.Point(20, 180);
            this.txtUserInput.Multiline = true;
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(600, 50);
            this.txtUserInput.TabIndex = 1;
            this.txtUserInput.Text = "Sorunuzu buraya yazın...";
            this.txtUserInput.GotFocus += new System.EventHandler(this.txtUserInput_GotFocus);
            this.txtUserInput.LostFocus += new System.EventHandler(this.txtUserInput_LostFocus);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(520, 236);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 30);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Gönder";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(20, 285);
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ReadOnly = true;
            this.txtResponse.Size = new System.Drawing.Size(600, 125);
            this.txtResponse.TabIndex = 3;
            this.txtResponse.Text = "";
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Location = new System.Drawing.Point(520, 420);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(100, 30);
            this.btnBackToMenu.TabIndex = 4;
            this.btnBackToMenu.Text = "Menüye Dön";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // MessageBoxForm


            this.ClientSize = new System.Drawing.Size(949, 620); // Sabit boyut
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; // Kenarlık yok
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; // Ortada başlasın
            this.Text = "FAVORİ SORULAR";

            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(628, 517);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtUserInput);
            this.Controls.Add(this.lblChatPrompt);
            this.Controls.Add(this.lblMotivationalQuote);
            this.Controls.Add(this.lblMotivationalHeader);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Name = "MessageBoxForm";
            this.Text = "Mesaj Kutusu";
            this.Load += new System.EventHandler(this.MessageBoxForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
