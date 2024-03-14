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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Problema01.windows
{
    /// <summary>
    /// Interaction logic for IntroduTari.xaml
    /// </summary>
    public partial class IntroduTari : Window
    {
        public Tara Tara { get; private set; }
        public IntroduTari(Tara tara)
        {
            InitializeComponent();
            Tara = tara;
            DataContext = Tara;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string? denumire = btnAdd.Content.ToString();
            if (denumire == "Adaugă țara")
            {
                MessageBox.Show("Țara a fost adaugată cu succes!");
                this.DialogResult = true;
            } 
            else if (denumire == "Modifică țara")
            {
                MessageBox.Show("Țara a fost modificată cu succes!");
                this.DialogResult = true;
            }
        }
    }
}
