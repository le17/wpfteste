using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for FormConsulta.xaml
    /// </summary>
    public partial class FormConsulta : Window
    {
        public FormConsulta()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
           
            string[] linhas = File.ReadAllLines(@"C:\Users\Frango\Desktop\testewpf\teste.txt", Encoding.UTF7);
            foreach (var linha in linhas)
            {
                txtlista.Text += " \n " + linha;
            }
        }
    }
}
