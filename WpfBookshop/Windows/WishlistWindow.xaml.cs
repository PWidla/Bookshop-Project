using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace WpfBookshop
{
    /// <summary>
    /// Interaction logic for WishlistWindow.xaml
    /// </summary>

    public partial class WishlistWindow : Window
    {
        /// <summary>
        /// Public variables to store accessible data
        /// <param name="DataSourceWishes">Public variable containing list of history of reserving books by users</param>
        /// <param name="ListOfWishes">Public variable containing list of wishes obtained from database</param>
        /// </summary>
        public List<wishlist> ListOfWishes;
        public List<string> DataSourceWishes;

        public WishlistWindow()
        {

            InitializeComponent();

            /// <summary>
            /// Connect to database and get data, then fill datagrid with history of reservations
            /// </summary>
            using (BOOKSHOPEntities context = new BOOKSHOPEntities())
            {
                ListOfWishes = context.wishlists.ToList();
                DataSourceWishes = new List<string>();

                foreach (var w in ListOfWishes)
                {
                    var wish = $"Username '{w.user.username}' ordered book '{w.book.name}'.";
                    this.DataSourceWishes.Add(wish);
                }
                lvDataBinding.ItemsSource = DataSourceWishes;
            }
        }

        /// <summary>
        /// Change current window to main window (with list of available books)
        /// </summary>
        private void Go_back_Click(object sender, RoutedEventArgs e)
        {
            MainWindowAdmin mainScreen = new MainWindowAdmin();
            this.Visibility = Visibility.Hidden;
            mainScreen.Show();
        }
    }
}
