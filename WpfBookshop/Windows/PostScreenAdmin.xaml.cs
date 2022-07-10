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
    /// Logika interakcji dla klasy PostScreen.xaml
    /// </summary>
    public partial class PostScreen : Window
    {
        public List<post> PostsList { get; set; }
        public PostScreen()
        {
            InitializeComponent();

            using (BOOKSHOPEntities context = new BOOKSHOPEntities())
            {
                PostsList = context.posts.ToList();
            }
            PostsGrid.ItemsSource = PostsList;
        }


    }
}
