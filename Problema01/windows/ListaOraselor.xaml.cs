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
    /// Interaction logic for ListaOraselor.xaml
    /// </summary>
    public partial class ListaOraselor : Window
    {
        TaraOrasViewModel vm = new TaraOrasViewModel();
        public ListaOraselor()
        {
            InitializeComponent();
            DataContext = vm;
            RefreshGrid();
        }
        private void RefreshGrid()
        {
            DataContext = null;
            DataContext = vm;
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            var viewModel = DataContext as TaraOrasViewModel;
            if (viewModel != null && viewModel.EditCommandOrase != null && viewModel.EditCommandOrase.CanExecute(lvOrase.SelectedItem))
            {
                viewModel.EditCommandOrase.Execute(lvOrase.SelectedItem);
                RefreshGrid();
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var viewModel = DataContext as TaraOrasViewModel;
            if (viewModel != null && viewModel.DeleteCommandOrase != null && viewModel.DeleteCommandOrase.CanExecute(lvOrase.SelectedItem))
            {
                viewModel.DeleteCommandOrase.Execute(lvOrase.SelectedItem);
                RefreshGrid();
            }
        }
    }
}
