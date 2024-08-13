using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using Modelos;

namespace ProjetoSistema
{
    public partial class TelaPedidos : ContentPage
    {
        public ObservableCollection<Pedido> Pedidos { get; set; }

        public TelaPedidos()
        {
            InitializeComponent();

           
            Pedidos = new ObservableCollection<Pedido>();
            var pedido1 = new Pedido();
            pedido1.Quantidade = 1;
            pedido1.Cliente = "ncjndoo";
            pedido1.NumeroDaOp = 1;

            var pedido2 = new Pedido();
            pedido2.Quantidade = 2;
            pedido2.Cliente = "jmfkngjhn";
            pedido2.NumeroDaOp = 2;


            Pedidos.Add(pedido1);
            Pedidos.Add(pedido2);

            BindingContext = this;
    }
}
}
