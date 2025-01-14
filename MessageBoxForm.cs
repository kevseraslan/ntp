using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ReviseMee
{
    public partial class MessageBoxForm : Form
    {
        private string[] motivationalQuotes =
        {
   "Başarısızlık, yeniden ve daha zekice başlama fırsatından başka bir şey değildir. - Henry Ford",
            "Başarı, çok çalışmanın ve vazgeçmemenin sonucudur.",
            "Bir şeyin yapılamayacağını söyleyenlere aldırmayın. Onlar yapamaz.",
            "Hedeflerinizi yüksek tutun ve başarısızlıktan korkmayın.",
            "Başarı, cesur olanlar içindir.",
                "Hayal gücü bilgiden daha önemlidir.",
"Hata yapmamış bir insan, yeni bir şey denememiştir.",
"Başarının anahtarı merak etmeyi bırakmamaktır.",
"Eğer hayal edebiliyorsanız, yapabilirsiniz.",
"Tüm hayallerimiz gerçekleşebilir, eğer peşinden gitme cesaretimiz varsa.",
"İleriye bakarak noktaları birleştiremezsiniz; yalnızca geriye dönüp baktığınızda birleştirebilirsiniz.",
"En büyük başarılarınız en zor zamanlarınızda gelir.",
                "Düşüncelerinizi değiştirin ve dünyanızı değiştirin.",
"Sahip olmadığınız şeylere odaklanmayın; sahip olduklarınızla ne yapabileceğinizi düşünün.",
                "Başarısızlık, daha zekice başlama fırsatından başka bir şey değildir.",
"Bir işi yapabileceğinize inanıyorsanız, haklısınız. Yapamayacağınıza inanıyorsanız, yine haklısınız.",
                "Her şey imkansız gibi görünene kadar imkansızdır.",
"Hayatta en büyük zafer asla düşmemek değil, her düştüğünde ayağa kalkmaktır.",
                "Hayatta kaç kez başarısız olduğum için başardım.",
"Başarısızlık, daha iyi bir şey yapmanız gerektiğini söyleyen bir sinyaldir.",
                "Yirmi yıl sonra yaptığınız şeylerden çok yapmadığınız şeylerden pişman olacaksınız.",
"Cesur olun, hayalleri kovalamaktan korkmayın.",
                "Önemli olan yavaş gitmeniz değil, durmamaktır.",
"Başarıyı her gün yaptığınız şeylerde arayın.",
                "Yapabileceğiniz en iyi şey yapabileceğiniz kadarıyla başlamak.",
"Bir şey yapmak için cesaretiniz varsa, o şeyi yapabilirsiniz.",
                "Kimse sizin izniniz olmadan kendinizi değersiz hissettiremez.",
"Kendi gücünüzün farkına varın ve onu kullanın.",
                "Başarısızlık, hayatınızda ne kadar güçlü olduğunuzu öğrenmenin bir yoludur.",
"Hayatta en büyük engel, kendinize olan inancınızdır."


        };

        private Dictionary<string, List<string>> predefinedResponses = new Dictionary<string, List<string>>
        {
            { "merhaba", new List<string> { "Merhaba! Sana nasıl yardımcı olabilirim?", "Merhaba! Bugün nasılsın?", "Selam! Bir sorunuz mu var?" } },
            { "nasılsın", new List<string> { "Ben bir yapay zekayım, duygularım yok ama teşekkür ederim! Siz nasılsınız?", "Gayet iyi! Siz nasılsınız?", "Her zamanki gibi harikayım! Peki ya siz?" } },
            { "teşekkürler", new List<string> { "Rica ederim! Başka bir sorunuz var mı?", "Ne demek, her zaman buradayım.", "Her zaman yardımcı olmaktan mutluluk duyarım!" } },
            { "yardım", new List<string> { "Tabii! Nasıl bir konuda yardım istiyorsunuz?", "Elimden geleni yaparım! Hangi konuda yardıma ihtiyacınız var?", "Size nasıl yardımcı olabilirim?" } }
        };

        private List<string> defaultResponses = new List<string>
        {
            "Bu konuda daha fazla bilgi edinmeye çalışın, başarı gelecektir!",
            "İlginç bir soru! Daha fazla bilgi sağlayabilir misiniz?",
            "Bunu tam anlayamadım ama daha fazla bilgi verirseniz yardımcı olabilirim.",
            "Bu konuda emin değilim ama araştırmaya değer!"
        };

        public MessageBoxForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal; // Tam ekranı kapat
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Sabit boyut
            this.StartPosition = FormStartPosition.CenterScreen; // Ortada başlasın
            this.MaximizeBox = false; // Tam ekran yapma butonunu devre dışı bırak
            this.Size = new System.Drawing.Size(949, 620);
        }

        private void MessageBoxForm_Load(object sender, EventArgs e)
        {
            ShowRandomMotivationalQuote();
        }

        private void ShowRandomMotivationalQuote()
        {
            Random random = new Random();
            int index = random.Next(motivationalQuotes.Length);
            lblMotivationalQuote.Text = motivationalQuotes[index];
        }

        private void txtUserInput_GotFocus(object sender, EventArgs e)
        {
            if (txtUserInput.Text == "Sorunuzu buraya yazın...")
            {
                txtUserInput.Text = "";
                txtUserInput.ForeColor = Color.Black;
            }
        }

        private void txtUserInput_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserInput.Text))
            {
                txtUserInput.Text = "Sorunuzu buraya yazın...";
                txtUserInput.ForeColor = Color.Gray;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string userQuestion = txtUserInput.Text.ToLower();

            if (string.IsNullOrWhiteSpace(userQuestion) || userQuestion == "sorunuzu buraya yazın...")
            {
                txtResponse.Text = "Lütfen geçerli bir soru giriniz.";
                return;
            }

            string response = GenerateResponse(userQuestion);
            txtResponse.Text = $"Soru: {userQuestion}\nCevap: {response}";
        }

        private string GenerateResponse(string userQuestion)
        {
            // Anahtar kelimeye göre yanıt üret
            foreach (var key in predefinedResponses.Keys)
            {
                if (userQuestion.Contains(key))
                {
                    var responses = predefinedResponses[key];
                    Random random = new Random();
                    int index = random.Next(responses.Count);
                    return responses[index];
                }
            }

            // Eğer eşleşen bir anahtar kelime bulunamazsa varsayılan yanıt döner
            Random defaultRandom = new Random();
            int defaultIndex = defaultRandom.Next(defaultResponses.Count);
            return defaultResponses[defaultIndex];
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            // Ana menünün açık olup olmadığını kontrol et
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is MenuRibbonForm)
                {
                    openForm.Show(); // Zaten açık olan ana menüyü göster
                    this.Close(); // Mevcut formu kapat
                    return; // Yeni bir form oluşturmadan çık
                }
            }

            // Eğer ana menü formu açık değilse yeni bir tane oluştur
            MenuRibbonForm menuForm = new MenuRibbonForm();
            menuForm.Show();
            this.Close();
        }

    }
}
