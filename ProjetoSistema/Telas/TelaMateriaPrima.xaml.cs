using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using Modelos;

namespace ProjetoSistema
{
    public partial class TelaMateriaPrima : ContentPage
    {
        public ObservableCollection<MateriaPrima> MateriaPrima { get; set; }

        public TelaMateriaPrima()
        {
            InitializeComponent();

            MateriaPrima = new ObservableCollection<MateriaPrima>
            {
                new MateriaPrima { NumeroDaMateria = "NumeroDaMateria 1", NomeDaMateria = "12345", QuantidadeEmEstoque = "10" },
                new MateriaPrima { NumeroDaMateria = "NumeroDaMateria 2", NomeDaMateria = "67890", QuantidadeEmEstoque = "20" },
                // Adicione mais pedidos conforme necessário
            };

            BindingContext = this;
        }
    }

    public class MateriaPrima
    {
        public string NumeroDaMateria { get; set; }
        public string NomeDaMateria { get; set; }
        public string QuantidadeEmEstoque { get; set; }
    }
}
