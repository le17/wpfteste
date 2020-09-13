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
using WpfAppTeste.Model;


namespace WpfAppTeste
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class FormPessoas : Window
    {
        public FormPessoas()
        {
            InitializeComponent();
        }


        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            
            DialogResult = true;
            Cadastro arquivoTXT = new Cadastro();
            arquivoTXT.Cadastrar(Txt_Nome.Text, Txt_Sobrenome.Text, Txt_Cpf.Text, Txt_Datanascimento.Text, Txt_Cep.Text, Txt_Endereco.Text, Txt_Numero.Text, Txt_Complemento.Text,
                Txt_Cidade.Text, Txt_Estado.Text);

            List<string> list = new List<string>();
            list.Add("Nome" + Txt_Nome);
            list.Add("Sobrenome" + Txt_Sobrenome);
            list.Add("CPF" + Txt_Cpf);
            list.Add("Data Nascimento" + Txt_Datanascimento);
            list.Add("CEP" + Txt_Cep);
            list.Add("Endereço" + Txt_Endereco);
            list.Add("Numero" + Txt_Numero);
            list.Add("Complemento" + Txt_Complemento);
            list.Add("Cidade" + Txt_Cidade);
            list.Add("Estado" + Txt_Estado);
            MessageBox.Show("Salvo com Sucesso!!");

            Txt_Nome.Clear();
            Txt_Sobrenome.Clear();
            Txt_Cpf.Clear();
            Txt_Cep.Clear();
            Txt_Endereco.Clear();
            Txt_Numero.Clear();
            Txt_Complemento.Clear();
            Txt_Cidade.Clear();
            Txt_Estado.Clear();
            
        }
    }
}
