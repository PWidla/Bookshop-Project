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
        /// <summary>
        /// Cancel the columns I don't want to generate
        /// </summary>
        private void DG_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            string headername = e.Column.Header.ToString();
            
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

        /// <summary>
        /// Public variables to store accessible data
        /// <param name="PostsList">Public variable containing list of posts obtained from database</param>
        /// <param name="IDofUser">Public variable containing ID of current logged user</param>
        /// </summary>
        public int IDofUser;
        public List<post> PostsList = new List<post>();


        public PostScreen(int IDuser)
        {
            IDofUser = IDuser;
            InitializeComponent();

            /// <summary>
            /// Connect to database and get data, then fill datagrid of posts with it
            /// </summary>
            using (BOOKSHOPEntities context = new BOOKSHOPEntities())
            {
                PostsList = context.posts.ToList();
            }
            PostsGrid.ItemsSource = PostsList;
        }

        /// <summary>
        /// Log out, come back to login screen
        /// </summary>
        private void btn_LogOut_Click(object sender, RoutedEventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            this.Visibility = Visibility.Hidden;
            loginScreen.Show();
        }

        /// <summary>
        /// Goes back to window with list of books
        /// </summary>
        private void Go_back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainScreen = new MainWindow(IDofUser);
            this.Visibility = Visibility.Hidden;
            mainScreen.Show();
        }
    }
}
