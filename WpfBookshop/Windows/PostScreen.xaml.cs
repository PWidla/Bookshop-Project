using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WpfBookshop
{
    /// <summary>
    /// Interaction logic for PostScreen.xaml
    /// </summary>
    public partial class PostScreen : Window
    {
        private void DG_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            string headername = e.Column.Header.ToString();

            /// <summary>
            ///  Canceling the columns I don't want to generate
            /// </summary>
            
            if (headername == "postID")
            {
                e.Cancel = true;
            }
            if (headername == "dataPublished")
            {
                e.Column.Header = "Date of publication";
            }
            if (headername == "title")
            {
                e.Column.Header = "Title";
            }
            if (headername == "body")
            {
                e.Cancel = true;
            }


        }

        public int IDofUser;
        public List<post> PostsList = new List<post>();
        public PostScreen(int IDuser)
        {
            IDofUser = IDuser;
            InitializeComponent();

            using (BOOKSHOPEntities context = new BOOKSHOPEntities())
            {
                PostsList = context.posts.ToList();
            }
            PostsGrid.ItemsSource = PostsList;
        }

        private void btn_LogOut_Click(object sender, RoutedEventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            this.Visibility = Visibility.Hidden;
            loginScreen.Show();
        }

        private void Go_back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainScreen = new MainWindow(IDofUser);
            this.Visibility = Visibility.Hidden;
            mainScreen.Show();
        }
    }
}
