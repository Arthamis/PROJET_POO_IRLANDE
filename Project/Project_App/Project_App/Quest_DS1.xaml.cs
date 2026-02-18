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

namespace Project_App
{
    /// <summary>
    /// Interaction logic for Quest_DS1.xaml
    /// </summary>
    public partial class Quest_DS1 : Page
    {
        NavigationService ns;
        public Quest_DS1()
        {
            InitializeComponent();
        }

        private void DS1_Quest1_Click(object sender, RoutedEventArgs e)
        {
            DS1_Quest1 ds = new DS1_Quest1();
            ns = NavigationService;
            ns.Navigate(ds);
        }

        private void DS1_Quest2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DS1_Quest3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DS1_Quest4_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
