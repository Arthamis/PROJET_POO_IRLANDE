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
    /// Interaction logic for SelectGame.xaml
    /// </summary>
    public partial class SelectGame : Page
    {
        private NavigationService ns;
        public SelectGame()
        {
            InitializeComponent();
        }

       

        private void On_Load(object sender, RoutedEventArgs e)
        {
            ns = this.NavigationService;

        }

        private void ER_Click(object sender, RoutedEventArgs e)
        {
            SelectCatER ER = new SelectCatER();
 
            ns.Navigate(ER);

        }

        private void DS1_Click(object sender, RoutedEventArgs e)
        {
            SelectCatDS1R DS1 = new SelectCatDS1R();
            ns.Navigate(DS1);
        }

        private void DS3_Click(object sender, RoutedEventArgs e)
        {
            SelectCatDS3 DS3 = new SelectCatDS3();
   
            ns.Navigate(DS3);
        }

        private void LOTF_Click(object sender, RoutedEventArgs e)
        {
            SelectCatLOTF LOTF = new SelectCatLOTF();
         
            ns.Navigate(LOTF);
        }
    }
}
