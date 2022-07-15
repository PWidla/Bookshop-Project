using System.Linq;
using System.Windows;

namespace WpfBookshop
{
    /// <summary>
    /// Interaction logic for RegisterScreen.xaml
    /// </summary>
    public partial class RegisterScreen : Window
    {
        public RegisterScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Change current window to window where user can log in
        /// </summary>
        private void OpenLoginScreen(object sender, RoutedEventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            this.Visibility = Visibility.Hidden;
            loginScreen.Show();
        }

        // <summary>
        /// Logic for registering new user
        /// </summary>
        private void btnSubmitRegister_Click(object sender, RoutedEventArgs e)
        {
            using (BOOKSHOPEntities context = new BOOKSHOPEntities())
            {
                if (context.users.Any(x => x.username == txtUsername.Text))
                {
                    MessageBox.Show("This username is already used.");
                }
                else if (string.IsNullOrWhiteSpace(txtUsername.Text) == true || string.IsNullOrWhiteSpace(txtPassword.Password) == true)
                {
                    MessageBox.Show("Neither login nor password can be empty.");
                }
                else
                {
                    context.users.Add(new user { username = txtUsername.Text, password = txtPassword.Password, role = "Client" });
                    MessageBox.Show("You have been successfully registered. Now you can log in.");
                    context.SaveChanges();
                }
            }
        }
    }
}
