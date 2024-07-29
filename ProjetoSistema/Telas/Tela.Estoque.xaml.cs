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

            Estoques = new ObservableCollection<Estoque>
            {
                // Exemplos de dados
                new Estoque { QuantLote = "QuantLote  1", Cliente = "Cliente 1", NumeroDeOp = "123456789" },
                new Estoque { QuantLote  = "QuantLote  2", Cliente = "Cliente 2", NumeroDeOp = "987654321" }
            };

            BindingContext = this;
        }
    }

    public class Costura
    {
        public string QuantLote { get; set; }
        public string Cliente { get; set; }
        public string NumeroDeOp { get; set; }
    }
}
