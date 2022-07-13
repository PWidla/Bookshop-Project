using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WpfBookshop
{
    /// <summary>
    ///  Interaction logic for MainWindow.xaml
    /// <param name="BooksList">Public variable containing list of books obtained from database</param>
    /// </summary>
    public partial class MainWindowAdmin : Window
    {
        public List<book> BooksList { get; set; }

        /// <summary>
        /// Cancel the columns I don't want to generate
        /// </summary>
        private void DG_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            string headername = e.Column.Header.ToString();

            if (headername == "wishlists")
            {
                e.Cancel = true;
            }
            if (headername == "bookID")
            {
                e.Cancel = true;
            }
            if (headername == "status")
            {
                e.Cancel = true;
            }

        }

        public MainWindowAdmin()
        {
            InitializeComponent();

            /// <summary>
            /// Connection to database. Fill datagrid with available books' data
            /// </summary>
            using (BOOKSHOPEntities context = new BOOKSHOPEntities())
            {
                BooksList =  (from c in context.books
                        where c.status == "available"
                        select c).ToList();

            }
            BooksGrid.ItemsSource = BooksList;
        }



        /// <summary>
        /// Change current window to window with posts data
        /// </summary>
        private void btn_Posts_Click(object sender, RoutedEventArgs e)
        {
            PostScreenAdmin postScreenAdmin = new PostScreenAdmin();
            this.Visibility = Visibility.Hidden;
            postScreenAdmin.Show();
        }

        /// <summary>
        /// Log out, come back to login screen.
        /// </summary>
        private void btn_LogOut_Click(object sender, RoutedEventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            this.Visibility = Visibility.Hidden;
            loginScreen.Show();
        }

        /// <summary>
        /// Change current window to window with reservations data
        /// </summary>
        private void btn_Wishlist_Click(object sender, RoutedEventArgs e)
        {
            WishlistWindow wishlistWindow = new WishlistWindow();
            this.Visibility = Visibility.Hidden;
            wishlistWindow.Show();
        }
    }
}

