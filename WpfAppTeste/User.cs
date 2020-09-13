using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTeste
{
    public class User
    {
        #region Variables  
        string _userNome = string.Empty;
        string _sobrenome = string.Empty;
        string _endereco = string.Empty;
        string _complemento = string.Empty;
        int _numero;
        string _cidade = string.Empty;
        string _estado = string.Empty;

        #endregion

        #region Properties


        public string Nome
        {
            get
            {
                return _userNome;
            }
            set
            {
                _userNome = value;
            }
        }

        public string Sobrenome
        {
            get
            {
                return _sobrenome;
            }
            set
            {
                _sobrenome = value;
            }
        }

        public string Endereco
        {
            get
            {
                return _endereco;
            }
            set
            {
                _endereco = value;
            }
        }
        public int Numero
        {
            get
            {
                return _numero;
            }
            set
            {
                _numero = value;
            }
        }
        public string Complemento
        {
            get
            {
                return _complemento;
            }
            set
            {
                _complemento = value;
            }
        }
        public string Cidade
        {
            get
            {
                return _cidade;
            }
            set
            {
                _cidade = value;
            }
        }
        public string Estado
        {
            get
            {
                return _estado;
            }
            set
            {
                _estado = value;
            }
        }
        #endregion  
    }
}
    

