using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using ProjetoSistema.Modelos;

namespace ProjetoSistema
{
    public partial class TelaFornecedores : ContentPage
    {
        public ObservableCollection<Fornecedor> Fornecedores { get; set; }

        public TelaFornecedores()
        {
            InitializeComponent();

           Fornecedores = new ObservableCollection<Fornecedor>();
            var fornecedor1 = new Fornecedor();
            fornecedor1.Nome = "jnfjdbg";
            fornecedor1.TipoDeMateria = "ncjndoo";
            fornecedor1.Telefone = "fdhbd";

            var fornecedor2 = new Fornecedor();
            fornecedor2.Nome = "bfdhfbh";
            fornecedor2.TipoDeMateria = "jmfkngjhn";
            fornecedor2.Telefone = "jduif";


            Fornecedores.Add(fornecedor1);
            Fornecedores.Add(fornecedor2);

            BindingContext = this;
        }
          private void Voltar(object sender, EventArgs args)
    {
        if (Application.Current != null)
        Application.Current.MainPage = new TelaInicial();
    }
    private void Cadastrar(object sender, EventArgs args)
    {
        if (Application.Current != null)
        Application.Current.MainPage = new CadastroFornecedor();
    }
    }
}
