using System;
using System.IO;

namespace WpfAppTeste.Model
{
    public class Cadastro : BaseNotifyPropertyChanged, ICloneable
    {

        private int _id;
        public int Id
        {
            get { return _id; }
            set { SetField(ref _id, value); }
        }

        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { SetField(ref _nome, value); }
        }

        private string _sobrenome;
        public string Sobrenome
        {
            get { return _sobrenome; }
            set { SetField(ref _sobrenome, value); }
        }

        private DateTime _dataNascimento;
        public DateTime DataNascimento
        {
            get { return _dataNascimento; }
            set { SetField(ref _dataNascimento, value); }
        }

        private string _cpf;
        public string Cpf
        {
            get { return _cpf; }
            set { SetField(ref _cpf, value); }
        }

        private string _cep;
        public string Cep
        {
            get { return _cep; }
            set { SetField(ref _cep, value); }
        }

        private string _endereco;
        public string Endereco
        {
            get { return _endereco; }
            set { SetField(ref _endereco, value); }
        }

        private int _numero;
        public int Numero
        {
            get { return _numero; }
            set { SetField(ref _numero, value); }
        }

        private string _complemento;
        public string Complemento
        {
            get { return _complemento; }
            set { SetField(ref _complemento, value); }
        }

        private string _cidade;
        public string Cidade
        {
            get { return _cidade; }
            set { SetField(ref _cidade, value); }
        }

        private string _estado;
        public string Estado
        {
            get { return _estado; }
            set { SetField(ref _estado, value); }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public void Cadastrar(string Nome, string Sobrenome, string Cpf, string DataNascimento, string Cep, string Endereco,
         string Numero, string Complemento, string Cidade, string Estado)
        {
            StreamWriter Arquivo;
            Arquivo = new StreamWriter(@"C:\Users\Frango\Desktop\testewpf\teste.txt");
            Arquivo.WriteLine("Nome: " + Nome.Trim());
            Arquivo.WriteLine("Sobrenome: " + Sobrenome.Trim());
            Arquivo.WriteLine("Cpf: " + Cpf.Trim());
            Arquivo.WriteLine("DataNascimento: " + DataNascimento.Trim());
            Arquivo.WriteLine(" Rua" + Endereco.Trim() + "," + Numero.Trim() + "/" + Complemento.Trim() + "-" + Cidade.Trim() + "/" + Estado.Trim() + "-" + Cep.Trim());
            Arquivo.Close();
        }
    }
}
