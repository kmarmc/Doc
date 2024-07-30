using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using Modelos;

namespace ProjetoSistema
{
    public partial class TelaEstoque : ContentPage
    {
        public ObservableCollection<Estoque> Estoque { get; set; }

        public TelaEstoque()
        {
            InitializeComponent();

            Costuras = new ObservableCollection<Estoque>
            {
                // Exemplos de dados
                new Estoque { QuantCliente = "QuantCliente  1", Cliente = "Cliente 1", NumeroDeOp = "123456789" },
                new Estoque { QuantCliente  = "QuantCliente  2", Cliente = "Cliente 2", NumeroDeOp = "987654321" }
            };

            BindingContext = this;
        }
    }
}
