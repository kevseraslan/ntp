using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ReviseMee
{
    public partial class FavoritesForm : Form
    {
        private string connectionString = "Data Source=MSI\\SQLK;Initial Catalog=ReviseMe;Integrated Security=True;";

        public FavoritesForm()
        {
            InitializeComponent();
            ConfigureFlowLayoutPanel();
            LoadFavorites();
            this.WindowState = FormWindowState.Normal; // Tam ekranı kapat
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Sabit boyut
            this.StartPosition = FormStartPosition.CenterScreen; // Ortada başlasın
            this.MaximizeBox = false; // Tam ekran yapma butonunu devre dışı bırak
            this.Size = new System.Drawing.Size(949, 620);
        }

        private void ConfigureFlowLayoutPanel()
        {
            flowLayoutPanelFavorites.AutoScroll = true;
            flowLayoutPanelFavorites.WrapContents = false;
            flowLayoutPanelFavorites.FlowDirection = FlowDirection.TopDown;
        }

        private void LoadFavorites()
        {
            flowLayoutPanelFavorites.Controls.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        F.FavoriteId, 
                        Q.PhotoPath, 
                        C.Name AS CategoryName, 
                        Q.Content 
                    FROM Favorites F
                    INNER JOIN Questions Q ON F.QuestionId = Q.QuestionId
                    INNER JOIN Categories C ON Q.CategoryId = C.CategoryId
                    WHERE F.UserId = @UserId"; // Kullanıcıya özel filtre

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@UserId", UserSession.UserId); // Giriş yapan kullanıcının ID'si

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    AddFavoriteToPanel(
                        (int)reader["FavoriteId"],
                        reader["PhotoPath"].ToString(),
                        reader["CategoryName"].ToString(),
                        reader["Content"].ToString());
                }
            }

            if (flowLayoutPanelFavorites.Controls.Count == 0)
            {
                MessageBox.Show("Henüz favori eklemediniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddFavoriteToPanel(int favoriteId, string photoPath, string categoryName, string questionContent)
        {
            Panel panel = new Panel
            {
                Size = new Size(400, 150),
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10),
                Tag = favoriteId // Panelin Tag özelliğine FavoriteId'yi bağla
            };

            PictureBox pictureBox = new PictureBox
            {
                Size = new Size(100, 100),
                Location = new Point(10, 10),
                SizeMode = PictureBoxSizeMode.StretchImage,
                ImageLocation = photoPath
            };

            Label lblCategory = new Label
            {
                Text = $"Ders: {categoryName}",
                Location = new Point(120, 10),
                Font = new Font("Tahoma", 10, FontStyle.Bold),
                AutoSize = true
            };

            Label lblContent = new Label
            {
                Text = $"Soru: {questionContent}",
                Location = new Point(120, 40),
                Font = new Font("Tahoma", 9),
                AutoSize = true,
                MaximumSize = new Size(250, 60)
            };

            Button btnRemove = new Button
            {
                Text = "Favorilerden Kaldır",
                Location = new Point(120, 80),
                Size = new Size(150, 30),
                Tag = favoriteId // Butonun Tag özelliğine FavoriteId'yi bağla
            };

            btnRemove.Click += BtnRemove_Click;

            panel.Controls.Add(pictureBox);
            panel.Controls.Add(lblCategory);
            panel.Controls.Add(lblContent);
            panel.Controls.Add(btnRemove);
            flowLayoutPanelFavorites.Controls.Add(panel);
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                int favoriteId = (int)btn.Tag;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Favorites WHERE FavoriteId = @FavoriteId";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@FavoriteId", favoriteId);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Soru favorilerden kaldırıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Favoriler listesini yeniden yükle
                LoadFavorites();
            }
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
