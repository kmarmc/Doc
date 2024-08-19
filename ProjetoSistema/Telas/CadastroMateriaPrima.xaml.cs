using System;
using Microsoft.Maui.Controls;

namespace ProjetoSistema
{
    public partial class CadastroDeMateriaPrima : ContentPage
    {
        public CadastroDeMateriaPrima()
        {
            InitializeComponent();
        }

        // Event handlers can be added here for button clicks if needed.
    
     async void CadClicked ( object sender, EventArgs args)
    {
        var resp = await DisplayAlert ( "Cadastro","Você tem certeza que deseja cadastrar?","sim","não");
        if (resp)
        {

        }
    }
   async void CancelClicked ( object sender, EventArgs args)
    {
        var resp = await DisplayAlert ( "Cadastro","Você tem certeza que deseja cancelar?","sim", "não");
        if (resp)
        {
            
        }
    }
    async void UnidadeClicked ( object sender, EventArgs args)
    {
        string result = await DisplayPromptAsync("Cadastro de Unidade", "Nome:");
        {

        }
    }
    private void Voltar(object sender, EventArgs args)
    {
        if (Application.Current != null)
        Application.Current.MainPage = new TelaInicial();
    }
    }
}
