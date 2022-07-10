using System.Linq;
using System.Windows;


namespace WpfBookshop
{
    /// <summary>
    /// Logika interakcji dla klasy LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
        public string LoggedUser { get; private set; }
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void OpenRegisterScreen(object sender, RoutedEventArgs e)
        {
            RegisterScreen registerScreen = new RegisterScreen();
            this.Visibility = Visibility.Hidden;
            registerScreen.Show();
        }

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
