using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using System.Diagnostics;

namespace ReviseMee
{
    public partial class MenuRibbonForm : RibbonForm
    {
        private string connectionString = "Data Source=MSI\\SQLK;Initial Catalog=ReviseMe;Integrated Security=True;";

        public MenuRibbonForm()
        {
            InitializeComponent();
            LoadCourses();
            this.WindowState = FormWindowState.Normal; // Tam ekranı kapat
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Sabit boyut
            this.StartPosition = FormStartPosition.CenterScreen; // Ortada başlasın
            this.MaximizeBox = false; // Tam ekran yapma butonunu devre dışı bırak
            this.Size = new System.Drawing.Size(949, 620);
        }

        private void LoadCourses()
        {
            // FlowLayoutPanel'i temizle
            flowLayoutPanelCourses.Controls.Clear();

            string[] courses = { "Türk Dili ve Edebiyatı", "Tarih", "Coğrafya", "İngilizce", "Matematik", "Fizik", "Kimya", "Biyoloji" };

            foreach (var course in courses)
            {
                int questionCount = GetQuestionCountByCourse(course, UserSession.UserId);

                Button btn = new Button
                {
                    Text = $"{course}\nSoru Sayısı: {questionCount}",
                    Size = new Size(150, 100),
                    BackColor = Color.LightBlue,
                    Font = new Font("Tahoma", 10, FontStyle.Bold),
                    Margin = new Padding(10)
                };

                btn.Click += (s, e) => ShowQuestionsForCourse(course);
                flowLayoutPanelCourses.Controls.Add(btn);
            }
        }

        private void btnChatBot_Click(object sender, EventArgs e)
        {
            // ChatFabrika web sayfasını aç
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://app.chatfabrica.com/chatbot-iframe/c19d744f-df40-4ac2-abf1-8dd26d42824b",
                UseShellExecute = true
            });
        }
        private int GetQuestionCountByCourse(string courseName, int userId)
        {
            int count = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT COUNT(*) 
                    FROM Questions Q
                    INNER JOIN Categories C ON Q.CategoryId = C.CategoryId
                    WHERE C.Name = @CourseName AND Q.UserId = @UserId";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@CourseName", courseName);
                cmd.Parameters.AddWithValue("@UserId", userId);

                connection.Open();
                count = (int)cmd.ExecuteScalar();
            }

            return count;
        }

        private void ShowQuestionsForCourse(string courseName)
        {

            QuestionListForm questionListForm = new QuestionListForm(courseName, UserSession.UserId);
            questionListForm.ShowDialog();
        }

        // Event metotları
        private void barBtnReminders_ItemClick(object sender, ItemClickEventArgs e)
        {
            ReminderForm reminderForm = new ReminderForm();
            reminderForm.Show();
        }
        private void barBtnSolveQuestions_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SolveQuestionForm solveQuestionForm = new SolveQuestionForm();
            solveQuestionForm.Show();
        }


        private void barBtnNotifications_ItemClick(object sender, ItemClickEventArgs e)
        {
            Bildirimler bildirimlerForm = new Bildirimler();
            bildirimlerForm.Show();
        }

        private void barBtnFavorites_ItemClick(object sender, ItemClickEventArgs e)
        {
            FavoritesForm favoritesForm = new FavoritesForm();
            favoritesForm.Show();
        }

        private void barBtnAddQuestion_ItemClick(object sender, ItemClickEventArgs e)
        {
            QuestionForm questionForm = new QuestionForm();
            questionForm.Show();
        }

        private void barBtnAI_ItemClick(object sender, ItemClickEventArgs e)
        {
            // AI ile ilgili bir form oluşturun
            MessageBoxForm aiForm = new MessageBoxForm();
            aiForm.Show(); // Formu göster
        }


        private void barBtnProgress_ItemClick(object sender, ItemClickEventArgs e)
        {
            ProgressTrackingForm progressForm = new ProgressTrackingForm();
            progressForm.Show();
        }

        private void barBtnProfile_ItemClick(object sender, ItemClickEventArgs e)
        {
            ProfileForm profileForm = new ProfileForm(UserSession.UserId);
            profileForm.Show();
        }
        



        private void MenuRibbonForm_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void flowLayoutPanelCourses_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
