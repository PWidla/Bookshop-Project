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
        private void DG_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            string headername = e.Column.Header.ToString();

            //Cancel the column you don't want to generate
            if (headername == "postID")
            {
                e.Cancel = true;
            }

            if (headername == "body")
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
        }

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
                txtContent.Text = null;
                txtTitle.Text = null;

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
            using (BOOKSHOPEntities context = new BOOKSHOPEntities())
            {
                var itemToRemove = context.posts.Single(x => x.postID == p.postID);
                context.posts.Remove(itemToRemove);
                context.SaveChanges();
                PostsList = context.posts.ToList();
            }
            PostsGrid.ItemsSource = null;
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
            MainWindowAdmin mainScreen = new MainWindowAdmin();
            this.Visibility = Visibility.Hidden;
            mainScreen.Show();
        }
    }
}
