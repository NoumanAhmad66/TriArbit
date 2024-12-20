using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using TriArbit_v1.Core;

namespace TriArbit_v1.AppServices
{
    /// <summary>
    /// Interaction logic for Opportunities.xaml
    /// </summary>
    public partial class Opportunities : UserControl
    {
        public OpHandler op;
        public Opportunities(OpHandler opportunities)
        {
            InitializeComponent();
            op = opportunities;
            dataGrid.ItemsSource = op.All;
        }
        /*
         private async void UpdateBTN_Click(object sender, RoutedEventArgs e)
         {
             await allPairs.UpdatePairs();
             //FetchOpportunities();
             dataGrid.ItemsSource = allPairs.tradingPairs;
         }
        */
    }
}
