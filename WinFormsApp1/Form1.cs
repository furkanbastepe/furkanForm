namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // Kontrolleri sınıf düzeyinde tanımlıyoruz
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblUsername;
        private Label lblPassword;
        private Button btnLogin;

        public Form1()
        {
            InitializeComponent();
            SetupCustomControls(); // Kontrolleri oluşturan metodu çağırıyoruz
        }

        private void SetupCustomControls()
        {
            // Form ayarları
            this.Text = "Kullanıcı Girişi";
            this.Size = new System.Drawing.Size(300, 200);

            // Kullanıcı Adı Etiketi
            lblUsername = new Label() { Text = "Kullanıcı Adı:", Left = 20, Top = 20, Width = 100 };
            
            // Kullanıcı Adı Kutusu
            txtUsername = new TextBox() { Left = 120, Top = 20, Width = 120 };

            // Şifre Etiketi
            lblPassword = new Label() { Text = "Şifre:", Left = 20, Top = 60, Width = 100 };

            // Şifre Kutusu
            txtPassword = new TextBox() { Left = 120, Top = 60, Width = 120, PasswordChar = '*' };

            // Giriş Butonu
            btnLogin = new Button() { Text = "Giriş Yap", Left = 120, Top = 100, Width = 120 };
            btnLogin.Click += (s, e) => {
                MessageBox.Show($"Hoş geldin, {txtUsername.Text}!");
            };

            // Kontrolleri forma ekle
            this.Controls.Add(lblUsername);
            this.Controls.Add(txtUsername);
            this.Controls.Add(lblPassword);
            this.Controls.Add(txtPassword);
            this.Controls.Add(btnLogin);
        }
    }
}