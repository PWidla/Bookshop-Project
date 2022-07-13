using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WpfBookshop
{
    /// <summary>
    /// Interaction logic for PostScreen.xaml
    /// </summary>
    public partial class PostScreenAdmin : Window
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

        /// <summary>
        /// Public list to store accessible data
        /// <param name="PostsList">Public variable containing list of posts obtained from database</param>
        /// </summary>
        public List<post> PostsList = new List<post>();

        public PostScreenAdmin()
        {
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
        /// Logic of adding new post 
        /// </summary>
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

        /// <summary>
        /// Logic of removing selected post 
        /// </summary>
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
            MainWindowAdmin mainScreen = new MainWindowAdmin();
            this.Visibility = Visibility.Hidden;
            mainScreen.Show();
        }
    }
}
