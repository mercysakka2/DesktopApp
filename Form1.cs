using Microsoft.VisualBasic.ApplicationServices;

namespace DesktopApp
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string enteredUsername = txtUser.Text;
            string enteredPassword = txtPass.Text;

            // Check if the entered username and password are correct
            if (enteredUsername == "admin" && enteredPassword == "12345")
            {
                MessageBox.Show("Login berhasil! Selamat datang di Asisten Kesehatan.", "Login Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // If correct, show the main form
                HomePage home = new HomePage();
                home.Show();

                // Hide login form
                this.Hide();
            }
            else
            {
                // If incorrect, show an error message
                MessageBox.Show("Username atau password salah. Silakan coba lagi.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
