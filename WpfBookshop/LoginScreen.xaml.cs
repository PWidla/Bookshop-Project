using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfBookshop
{
    /// <summary>
    /// Logika interakcji dla klasy LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
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

        private void btnSubmitLogin_Click(object sender, RoutedEventArgs e)
        {
            using (BOOKSHOPEntities context = new BOOKSHOPEntities())
            {
                if (context.users.Any(x => x.username == txtUsername.Text && x.password == txtPassword.Password))
                {
                    MessageBox.Show("You logged in successfully.");
                    MainWindow mainScreen = new MainWindow();
                    this.Visibility = Visibility.Hidden;
                    mainScreen.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password. Try once again.");
                }
            }
        }
    }
}
