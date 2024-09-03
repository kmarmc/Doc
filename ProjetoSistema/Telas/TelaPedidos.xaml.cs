using System.Collections.ObjectModel;
using Controles;
using Microsoft.Maui.Controls;
using Modelos;

namespace ProjetoSistema
{

    public partial class TelaPedidos : ContentPage
    {
        Controles.ControlePedido controlePedido = new Controles.ControlePedido();
        public ObservableCollection<Pedido> Pedidos { get; set; }

        public TelaPedidos()
        {
            InitializeComponent();
            ListaPedidos.ItemsSource = controlePedido.LerTodos();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            ListaPedidos.ItemsSource = controlePedido.LerTodos();
        }
        void SelecionarLista(object sender, SelectedItemChangedEventArgs e)
        {
              var page = new CadastroPedidos();
              page.pedido = e.SelectedItem as Pedido;
              Application.Current.MainPage = page;
        }
        private void Voltar(object sender, EventArgs args)
        {
            if (Application.Current != null)
                Application.Current.MainPage = new TelaInicial();
        }
        private void Cadastrar(object sender, EventArgs args)
        {
            if (Application.Current != null)
                Application.Current.MainPage = new CadastroPedidos();
        }
    }
}

