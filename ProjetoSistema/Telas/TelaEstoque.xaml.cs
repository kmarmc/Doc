using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using Modelos;

namespace ProjetoSistema
{
    public partial class TelaEstoque : ContentPage
    {
        public ObservableCollection<Estoque> Estoques { get; set; }

        public TelaEstoque()
        {
            InitializeComponent();

            Estoques = new ObservableCollection<Estoque>();
            var estoque1 = new Estoque();
            estoque1.Quantidade = 1;
            estoque1.Cliente = "ncjndoo";
            estoque1.NumeroDaOp = 1;

            var estoque2 = new Estoque();
            estoque2.Quantidade = 2;
            estoque2.Cliente = "jmfkngjhn";
            estoque2.NumeroDaOp = 2;


            Estoques.Add(estoque1);
            Estoques.Add(estoque2);

            BindingContext = this;
        }
    }
}
