using System.Linq;
using System.Windows;


namespace WpfBookshop
{
    /// <summary>
    /// Interaction logic for LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
        /// <summary>
        /// Public variable to store data of current logged user
        /// <param name="LoggedUser">Public variable containing username of current logged user</param>
        /// </summary>
        public string LoggedUser;
        public LoginScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Change current window to window where user can register a new account
        /// </summary>
        private void OpenRegisterScreen(object sender, RoutedEventArgs e)
        {
            RegisterScreen registerScreen = new RegisterScreen();
            this.Visibility = Visibility.Hidden;
            registerScreen.Show();
        }

        /// <summary>
        /// Logic of logging in. Checking if user exists in database. If he doesn't, user gets a message informing that he entered incorrect data. If he does, window with list of books opens. If entered data correspond to the administrator's data, admin's version of window with books' list opens.
        /// </summary>
        public void btnSubmitLogin_Click(object sender, RoutedEventArgs e)
        {
            using (BOOKSHOPEntities context = new BOOKSHOPEntities())
            {
                if (context.users.Any(x => x.username == txtUsername.Text && x.password == txtPassword.Password))
                {
                    MessageBox.Show("You logged in successfully.");
                    if (txtUsername.Text == "admin")
                    {
                        MainWindowAdmin mainScreen = new MainWindowAdmin();
                        this.Visibility = Visibility.Hidden;
                        mainScreen.Show();
                    }
                    else
                    {
                        int id  = context.users.Where(x => x.username == txtUsername.Text && x.password == txtPassword.Password).Select(x => x.userID).First();
                        MainWindow mainScreen = new MainWindow(id);
                        this.Visibility = Visibility.Hidden;
                        mainScreen.Show();
                    }
                    LoggedUser = txtUsername.Text;

                }
                else
                {
                    MessageBox.Show("Incorrect username or password. Try once again.");
                }
            }
        }
    }
}
