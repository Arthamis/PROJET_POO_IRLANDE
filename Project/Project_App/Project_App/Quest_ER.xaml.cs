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
    /// Interaction logic for Quest_ER.xaml
    /// </summary>
    public partial class Quest_ER : Page
    {
        private NavigationService ns;
        public Quest_ER()
        {
            InitializeComponent();
        }

        private void ER_Quest1_Click(object sender, RoutedEventArgs e)
        {
            ER_Quest1 er = new ER_Quest1();
            ns = this.NavigationService;
            ns.Navigate(er);
        }

        private void ER_Quest2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ER_Quest3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ER_Quest4_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
