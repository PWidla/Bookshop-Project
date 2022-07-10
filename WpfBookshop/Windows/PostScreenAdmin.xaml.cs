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
    public partial class PostScreenAdmin : Window
    {
        public List<post> PostsList { get; set; }
        public PostScreenAdmin()
        {
            InitializeComponent();

            using (BOOKSHOPEntities context = new BOOKSHOPEntities())
            {
                PostsList = context.posts.ToList();
            }
            PostsGrid.ItemsSource = PostsList;
        }

        private void btn_AddPost_Click(object sender, RoutedEventArgs e)
        {
            using (BOOKSHOPEntities context = new BOOKSHOPEntities())
            {
                context.posts.Add(new post { body = txtContent.Text, title = txtTitle.Text, dataPublished = DateTime.Now });
                MessageBox.Show("You have added a new post.");
                context.SaveChanges();
                PostsList = context.posts.ToList();
                PostsGrid.ItemsSource = null;
                PostsGrid.ItemsSource = PostsList;
            }
        }

        private void btn_RemovePost_Click(object sender, RoutedEventArgs e)
        {
            post p = (post)PostsGrid.SelectedItem;
            MessageBox.Show($"You just deleted a post.");
            PostsList.Remove(p);
            PostsGrid.ItemsSource = null;
            PostsGrid.ItemsSource = PostsList;
        }

        private void btn_LogOut_Click(object sender, RoutedEventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            this.Visibility = Visibility.Hidden;
            loginScreen.Show();
        }
    }
}
