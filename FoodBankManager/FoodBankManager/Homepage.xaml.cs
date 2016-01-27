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

namespace FoodBankManager
{
    /// <summary>
    /// Interaction logic for Homepage.xaml
    /// </summary>
    public partial class Homepage : Page
    {
        public Homepage()
        {
            InitializeComponent();
        }




        private void bttnHelp_Click(object sender, RoutedEventArgs e)
        {
            if (helpLabels.Visibility == Visibility.Hidden)
            {
                helpAdd_Items.Visibility = Visibility.Visible;
                helpRemove_Items.Visibility = Visibility.Visible;
                helpStats.Visibility = Visibility.Visible;
                helpMap.Visibility = Visibility.Visible;
                helpLabels.Visibility = Visibility.Visible; 
            }
            else
            {
                helpAdd_Items.Visibility = Visibility.Hidden;
                helpRemove_Items.Visibility = Visibility.Hidden;
                helpStats.Visibility = Visibility.Hidden;
                helpMap.Visibility = Visibility.Hidden;
                helpLabels.Visibility = Visibility.Hidden;
            }
        }

        private void bttnRemove_Items_Click(object sender, RoutedEventArgs e)
        {
            Withdraw w = new Withdraw();
            this.NavigationService.Navigate(w);
        }
    }
}
