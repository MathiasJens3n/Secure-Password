namespace Secure_Password
{
    public partial class Form1 : Form
    {
        LoginManager loginManager;
        string username;
        string password;
        public Form1()
        {
            InitializeComponent();
            loginManager = new LoginManager();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            username = userNameTextBox.Text;
            password = passwordTextBox.Text;

            testTextBox.Text = loginManager.ValidatePassword(username,password);
        }

        private void CreateUserButton1_Click(object sender, EventArgs e)
        {
            username = userNameTextBox.Text;
            password = passwordTextBox.Text;


            testTextBox.Text = loginManager.CreateUser(username,password);
        }

    }
}