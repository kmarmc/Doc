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
}
}
