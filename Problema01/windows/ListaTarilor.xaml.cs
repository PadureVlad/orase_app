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
    /// Interaction logic for ListaTarilor.xaml
    /// </summary>
    public partial class ListaTarilor : Window
    {
        TaraOrasViewModel vm = new TaraOrasViewModel();
        public ListaTarilor()
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            var viewModel = DataContext as TaraOrasViewModel;
            if (viewModel != null && viewModel.EditCommandTari != null && viewModel.EditCommandTari.CanExecute(lvTari.SelectedItem))
            {
                viewModel.EditCommandTari.Execute(lvTari.SelectedItem);
                RefreshGrid();
            }
        }
        private void RefreshGrid()
        {
            DataContext = null;
            DataContext = vm;
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var viewModel = DataContext as TaraOrasViewModel;
            if (viewModel != null && viewModel.DeleteCommandTari != null && viewModel.DeleteCommandTari.CanExecute(lvTari.SelectedItem))
            {
                viewModel.DeleteCommandTari.Execute(lvTari.SelectedItem);
                RefreshGrid();
            }
        }
    }
}
