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
    /// Interaction logic for IntroduOrase.xaml
    /// </summary>
    public partial class IntroduOrase : Window
    {
        public Oras Oras { get; private set; }
        public IntroduOrase(Oras oras)
        {
            InitializeComponent();
            TaraOrasViewModel vm = new TaraOrasViewModel();
            Oras = oras;
            DataContext = Oras;
            cbTara.ItemsSource = vm.Tari;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string? denumire = btnAdd.Content.ToString();
            if (denumire == "Adaugă oraș")
            {
                MessageBox.Show("Orașul a fost adaugat cu succes!");
                this.DialogResult = true;
            } 
            else if (denumire == "Modifică orașul")
            {
                MessageBox.Show("Orașul a fost modificat cu succes!");
                this.DialogResult = true;
            }
        }
    }
}
