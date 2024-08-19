using System;
using Microsoft.Maui.Controls;

namespace ProjetoSistema
{
    public partial class TelaSetores : ContentPage
    {
        public TelaSetores()
        {
            InitializeComponent();
        }
        private void Voltar(object sender, EventArgs args)
    {
        if (Application.Current != null)
        Application.Current.MainPage = new TelaInicial();
    }
    private void EntrarTelaCorte(object sender, EventArgs args)
    {
        if (Application.Current != null)
        Application.Current.MainPage = new TelaCorte();
    
    }
    private void EntrarTelaAlmoxarifado(object sender, EventArgs args)
    {
        if (Application.Current != null)
        Application.Current.MainPage = new TelaAlmoxarifado();
    
    }
    private void EntrarTelaCostura(object sender, EventArgs args)
    {
        if (Application.Current != null)
        Application.Current.MainPage = new TelaCostura();
    
    }
    private void EntrarTelaBordado(object sender, EventArgs args)
    {
        if (Application.Current != null)
        Application.Current.MainPage = new TelaBordado();
    
    }
     private void EntrarTelaAcabamento(object sender, EventArgs args)
    {
        if (Application.Current != null)
        Application.Current.MainPage = new TelaAcabamento();
    
    }
    private void EntrarTelaEstoque(object sender, EventArgs args)
    {
        if (Application.Current != null)
        Application.Current.MainPage = new TelaEstoque();
    
    }
}
}
