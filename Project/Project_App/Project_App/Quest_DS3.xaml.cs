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
    /// Interaction logic for Quest_DS3.xaml
    /// </summary>
    public partial class Quest_DS3 : Page
    {
        NavigationService ns;
        public Quest_DS3()
        {
            InitializeComponent();
        }

        private void DS3_Quest1_Click(object sender, RoutedEventArgs e)
        {
            DS3_Quest1 er = new DS3_Quest1();
            ns = this.NavigationService;
            ns.Navigate(er);
        }

        private void DS3_Quest2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DS3_Quest3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DS3_Quest4_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
