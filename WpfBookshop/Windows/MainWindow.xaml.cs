using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace WpfBookshop
{
    /// <summary>
    ///  Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Public variables to store accessible data
        /// <param name="IDofUser">Public variable containing ID of current logged user</param>
        /// <param name="BooksList">Public variable containing list of books obtained from database</param>
        /// </summary>
        public int IDofUser;
        public List<book> BooksList = new List<book>();


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

        public MainWindow(int IDuser)
        {
            InitializeComponent();

            IDofUser = IDuser;

            /// <summary>
            /// Connect to database and get data, then fill list with it
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
        /// Reserve button logic. Changing value of status of selected book and refreshing datagrid
        /// </summary>
        private void btn_Reserve_Click(object sender, RoutedEventArgs e)
        {
            book b = (book)BooksGrid.SelectedItem;
            MessageBox.Show($"You just reserved book named '{b.name}', you can collect it tomorrow between 9 A.M and 5 P.M in our bookshop! You can pay with cash only.");

            using (BOOKSHOPEntities context = new BOOKSHOPEntities())
            {
                context.wishlists.Add(new wishlist { IDuser = IDofUser, IDbook = b.bookID });
                var query = context.books.Single(u => u.bookID == b.bookID);
                query.status = "unavailable";
                context.SaveChanges();

                BooksList = (from c in context.books
                             where c.status == "available"
                             select c).ToList();
            }
            BooksGrid.ItemsSource = null;
            BooksGrid.ItemsSource = BooksList;
        }

        /// <summary>
        /// Change current window to window with posts data
        /// </summary>
        private void btn_Posts_Click(object sender, RoutedEventArgs e)
        {
            PostScreen postScreen = new PostScreen(IDofUser);
            this.Visibility = Visibility.Hidden;
            postScreen.Show();
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
    }
}

