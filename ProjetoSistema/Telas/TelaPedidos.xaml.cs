using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace ProjetoSistema
{
    public partial class TelaPedidos : ContentPage
    {
        public ObservableCollection<Pedido> Pedidos { get; set; }

        public TelaPedidos()
        {
            InitializeComponent();

            Pedidos = new ObservableCollection<Pedido>
            {
                new Pedido { Cliente = "Cliente 1", NumeroDeOP = "12345", Quantidade = "10" },
                new Pedido { Cliente = "Cliente 2", NumeroDeOP = "67890", Quantidade = "20" },
                // Adicione mais pedidos conforme necessário
            };

            BindingContext = this;
        }
    }

    public class Pedido
    {
        public string Cliente { get; set; }
        public string NumeroDeOP { get; set; }
        public string Quantidade { get; set; }
    }
}
