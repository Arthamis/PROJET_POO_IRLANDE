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
    /// Interaction logic for Quest_LOTF.xaml
    /// </summary>
    public partial class Quest_LOTF : Page
    {
        NavigationService ns;
        public Quest_LOTF()
        {
            InitializeComponent();
        }

        private void LOTF_Quest1_Click(object sender, RoutedEventArgs e)
        {
            LOTF_Quest1 lotf = new LOTF_Quest1();
            ns = NavigationService;
            ns.Navigate(lotf);
        }

        private void LOTF_Quest2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LOTF_Quest3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LOTF_Quest4_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
