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
            pedido1.SetQuantidade(1);
            pedido1.SetCliente("ncjndoo");
            pedido1.SetNumeroDaOp(1);

            var pedido2 = new Pedido();
            pedido2.SetQuantidade(2);
            pedido2.SetCliente("jmfkngjhn");
            pedido2.SetNumeroDaOp(2);


            Pedidos.Add(pedido1);
            Pedidos.Add(pedido2);

            BindingContext = this;
    }
}
}
