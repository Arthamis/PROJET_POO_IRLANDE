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
    /// Interaction logic for SelectCat.xaml
    /// </summary>
    public partial class SelectCatER : Page
    {
        private NavigationService ns;
        public SelectCatER()
        {
            
            InitializeComponent();
        }

        private void On_Load(object sender, RoutedEventArgs e)
        {
            ns = this.NavigationService;
        }

        private void ER_Quest_Click(object sender, RoutedEventArgs e)
        {
            Quest_ER er = new Quest_ER();
            ns = this.NavigationService;
            ns.Navigate(er);
        }
    }
}
