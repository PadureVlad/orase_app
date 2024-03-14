using Problema01.Models;
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
    /// Interaction logic for ListaOraseLocuitori.xaml
    /// </summary>
    public partial class ListaOraseLocuitori : Window
    {
        OraseContext dbListOrase = new OraseContext();
        public ListaOraseLocuitori()
        {
            InitializeComponent();
            lvOrase.ItemsSource = dbListOrase.GetListaOraseLocuitori();
            lvOrase.Items.Refresh();
        }
    }
}
