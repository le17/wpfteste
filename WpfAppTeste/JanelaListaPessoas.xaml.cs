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

namespace WpfAppTeste
{
    /// <summary>
    /// Interaction logic for JanelaListaPessoas.xaml
    /// </summary>
    public partial class JanelaListaPessoas : Window
    {
        public JanelaListaPessoas()
        {
            InitializeComponent();
            DataContext = new ViewModel.CadastroViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FormConsulta main = new FormConsulta();
            main.ShowDialog();
        }
    }
}
