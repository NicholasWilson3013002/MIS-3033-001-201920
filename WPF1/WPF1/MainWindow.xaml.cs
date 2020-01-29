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
        }
        




        private void Tb1_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            
        }
        
        private void Tb2_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Tb3_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            string name = tb1.Text;
            string address = tb2.Text;
            int zip = Convert.ToInt32(tb3.Text);

            

        }
    }
}
