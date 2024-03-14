using Problema01.Models;
using Problema01.ViewModel;
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
using System.Windows.Shapes;

namespace Problema01.windows
{
    /// <summary>
    /// Interaction logic for ListaTariContinent.xaml
    /// </summary>
    public partial class ListaTariContinent : Window
    {
        OraseContext dbListTari = new OraseContext();
        public ListaTariContinent()
        {
            InitializeComponent();
            TaraOrasViewModel vm = new TaraOrasViewModel();
            var continenteUnice = vm.Tari.Select(t => t.Continent).Distinct();
            cbContinent.ItemsSource = continenteUnice;
        }

        private void btnDetermina_Click(object sender, RoutedEventArgs e)
        {
            string continent = cbContinent.Text.ToString();
            lvTari.ItemsSource = dbListTari.GetListaTariContinent(continent);
            lvTari.Items.Refresh();
        }
    }
}
