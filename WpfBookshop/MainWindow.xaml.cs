using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfBookshop
{
    /// <summary>
    ///  Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<book> BooksList { get; set; }
        private void DG_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            string headername = e.Column.Header.ToString();

            //Cancel the column you don't want to generate
            if (headername == "wishlists")
            {
                e.Cancel = true;
            }
            if (headername == "bookID")
            {
                // e.Column.Header = "First Name";
                e.Cancel = true;
            }
           
        }

        public MainWindow()
        {
            InitializeComponent();



            using (BOOKSHOPEntities context = new BOOKSHOPEntities())
            {
                BooksList = context.books.ToList();
            }
            BooksGrid.ItemsSource = BooksList;

        }

        private void btn_Reserve_Click(object sender, RoutedEventArgs e)
        {
            book b = (book)BooksGrid.SelectedItem;
            MessageBox.Show($"{b.bookID}");


        }
    }
}

