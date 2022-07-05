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
    /// Logika interakcji dla klasy RegisterScreen.xaml
    /// </summary>
    public partial class RegisterScreen : Window
    {
        public RegisterScreen()
        {
            InitializeComponent();
        }

        private void OpenLoginScreen(object sender, RoutedEventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            this.Visibility = Visibility.Hidden;
            loginScreen.Show();
        }

        private void btnSubmitRegister_Click(object sender, RoutedEventArgs e)
        {
            using (BOOKSHOPEntities context = new BOOKSHOPEntities())
            {
                if (context.users.Any(x => x.username == txtUsername.Text))
                {
                    MessageBox.Show("This username is already used.");
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
