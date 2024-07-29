using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace ProjetoSistema
{
    public partial class TelaFornecedores : ContentPage
    {
        public ObservableCollection<Fornecedor> Fornecedores { get; set; }

        public TelaFornecedores()
        {
            InitializeComponent();

            Fornecedores = new ObservableCollection<Fornecedor>
            {
                // Exemplos de dados
                new Fornecedor { Nome = "Fornecedor 1", MateriaPrima = "Materia 1", Telefone = "123456789" },
                new Fornecedor { Nome = "Fornecedor 2", MateriaPrima = "Materia 2", Telefone = "987654321" }
            };

            BindingContext = this;
        }
    }

    public class Fornecedor
    {
        public string Nome { get; set; }
        public string MateriaPrima { get; set; }
        public string Telefone { get; set; }
    }
}
