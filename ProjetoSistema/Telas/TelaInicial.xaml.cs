using System;
using Microsoft.Maui.Controls;

namespace ProjetoSistema
{
    public partial class TelaInicial : ContentPage
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void EntrarTelaPedido(object sender, EventArgs args)
    {
        if (Application.Current != null)
        Application.Current.MainPage = new TelaPedidos();
    }
     private void EntrarTelaMateriaPrima(object sender, EventArgs args)
    {
        if (Application.Current != null)
        Application.Current.MainPage = new TelaMateriaPrima();
    }
         private void EntrarProdutos(object sender, EventArgs args)
    {
        if (Application.Current != null)
        Application.Current.MainPage = new CadastroProduto();
    }

    private void EntrarTelaSetores(object sender, EventArgs args)
    {
        if (Application.Current != null)
        Application.Current.MainPage = new TelaSetores();
    }
    private void EntrarTelaCliente(object sender, EventArgs args)
    {
        if (Application.Current != null)
        Application.Current.MainPage = new TelaCliente();
    }
    private void EntrarTelaFornecedores(object sender, EventArgs args)
    {
        if (Application.Current != null)
        Application.Current.MainPage = new TelaFornecedores();
    }
    }
}