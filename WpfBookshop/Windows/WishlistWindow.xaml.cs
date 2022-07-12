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
    /// Logika interakcji dla klasy WishlistWindow.xaml
    /// </summary>
    /// 


    public partial class WishlistWindow : Window
    {
        public List<wishlist> ListOfWishes;
        public List<string> DataSourceWishes;


        public WishlistWindow()
        {

            InitializeComponent();

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

        private void Go_back_Click(object sender, RoutedEventArgs e)
        {
            MainWindowAdmin mainScreen = new MainWindowAdmin();
            this.Visibility = Visibility.Hidden;
            mainScreen.Show();
        }
    }
}
