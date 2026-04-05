namespace Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
            this.Hide(); // hide login form
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox2.Text;
            string password = textBox1.Text;
            string filePath = "users.txt";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("No users found! Please signup first.");
                return;
            }

            bool loginSuccess = false;

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts[0] == username && parts[1] == password)
                {
                    loginSuccess = true;
                    break;
                }
            }

            if (loginSuccess)
            {
                // Open MainForm if login is successful
                Main mainForm = new Main();
                mainForm.Show();
                this.Hide(); // Hide login form
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
