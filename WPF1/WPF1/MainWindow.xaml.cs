//Nicholas Wilson
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            tb1.Text = string.Empty;
            tb2.Text = string.Empty;
            tb3.Text = string.Empty;
        }
        
        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            string Namy = tb1.Text;
            string Addy = tb2.Text;
            string Zipy = tb3.Text;  // equivalent to doing Console.ReadLine();
            int ZipCode;

            
            if (string.IsNullOrWhiteSpace(Namy) == true)
            {
                MessageBox.Show("You must enter your full name");
            }

            bool isInt = Int32.TryParse(Zipy, out ZipCode);
            if (isInt == false)
            {
                MessageBox.Show("Must enter integer value for ZipCode");
            }

            /* Create an instance of the EntryForm object using the empty construtor
                EntryForm ef = new EntryForm()
                ef.Address = addy;
                ef.Name = namy;
                ef.ZipCode = Zip;
            */

            // Create an instance of the EntryForm object 
            EntryForm ef = new EntryForm(Namy, Addy, ZipCode);



        }

        private void Tb1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
