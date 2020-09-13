using System;

using System.Linq;

namespace WpfAppTeste.ViewModel
{
    public class CadastroViewModel : BaseNotifyPropertyChanged
    {
        public System.Collections.ObjectModel.ObservableCollection<Model.Cadastro> Pessoas { get; private set; }

        private Model.Cadastro _PessoaSelecionado;
        public Model.Cadastro PessoaSelecionado
        {
            get { return _PessoaSelecionado; }
            set
            {
                SetField(ref _PessoaSelecionado, value);
                Deletar.RaiseCanExecuteChanged();
                Editar.RaiseCanExecuteChanged();
            }
        }
        public CadastroViewModel()
        {
            Pessoas = new System.Collections.ObjectModel.ObservableCollection<Model.Cadastro>();
            Pessoas.Add(new Model.Cadastro()
            {

            });
        }

        public DeletarCommand Deletar { get; private set; } = new DeletarCommand();

        public class DeletarCommand : BaseCommand
        {
            public override bool CanExecute(object parameter)
            {
                var viewModel = parameter as CadastroViewModel;
                return viewModel != null && viewModel.PessoaSelecionado != null;
            }

            public override void Execute(object parameter)
            {
                var viewModel = (CadastroViewModel)parameter;
                viewModel.Pessoas.Remove(viewModel.PessoaSelecionado);
                viewModel.PessoaSelecionado = viewModel.Pessoas.FirstOrDefault();
            }
        }

        public EditarCommand Editar { get; private set; } = new EditarCommand();

        public class EditarCommand : BaseCommand
        {
            public override bool CanExecute(object parameter)
            {
                var viewModel = parameter as CadastroViewModel;
                return viewModel != null && viewModel.PessoaSelecionado != null;
            }

            public override void Execute(object parameter)
            {
                var viewModel = (CadastroViewModel)parameter;
                var clonePessoas = (Model.Cadastro)viewModel.PessoaSelecionado.Clone();
                var aw = new FormPessoas();
                aw.DataContext = clonePessoas;
                aw.ShowDialog();

                if (aw.DialogResult.HasValue && aw.DialogResult.Value)
                {
                    viewModel.PessoaSelecionado.DataNascimento = clonePessoas.DataNascimento;
                    viewModel.PessoaSelecionado.Nome = clonePessoas.Nome;
                    viewModel.PessoaSelecionado.Sobrenome = clonePessoas.Sobrenome;
                    viewModel.PessoaSelecionado.Cpf = clonePessoas.Cpf;
                    viewModel.PessoaSelecionado.Cep = clonePessoas.Cep;
                    viewModel.PessoaSelecionado.Endereco = clonePessoas.Endereco;
                    viewModel.PessoaSelecionado.Numero = clonePessoas.Numero;
                    viewModel.PessoaSelecionado.Complemento = clonePessoas.Complemento;
                    viewModel.PessoaSelecionado.Cidade = clonePessoas.Cidade;
                    viewModel.PessoaSelecionado.Estado = clonePessoas.Estado;

                }

            }
        }

        public NovoCommand Novo { get; private set; } = new NovoCommand();

        public class NovoCommand : BaseCommand
        {
            public override bool CanExecute(object parameter)
            {
                return parameter is CadastroViewModel;
            }

            public override void Execute(object parameter)
            {
                var viewModel = (CadastroViewModel)parameter;
                var pessoa = new Model.Cadastro();

                pessoa.DataNascimento = DateTime.Now;
                var maxID = 0;
                if (viewModel.Pessoas.Any())
                {
                    maxID = viewModel.Pessoas.Max(a => a.Id);
                }
                pessoa.Id = maxID + 1;

                var aw = new FormPessoas();
                aw.DataContext = pessoa;
                aw.ShowDialog();

                if (aw.DialogResult.HasValue && aw.DialogResult.Value)
                {
                    viewModel.Pessoas.Add(pessoa);
                    viewModel.PessoaSelecionado = pessoa;
                }


            }


        }
    }
}
