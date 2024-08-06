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
            fornecedor1.SetNome("jnfjdbg");
            fornecedor1.SetTipoDeMateria("ncjndoo");
            fornecedor1.SetTelefone("fdhbd");

            var fornecedor2 = new Fornecedor();
            fornecedor2.SetNome("bfdhfbh");
            fornecedor2.SetTipoDeMateria("jmfkngjhn");
            fornecedor2.SetTelefone("jduif");


            Fornecedores.Add(fornecedor1);
            Fornecedores.Add(fornecedor2);

            BindingContext = this;
        }
    }
}
