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
    }
    void CadClicked ( object sender EventArgs args)
    {
        var rest = await DisplayAlert ( "Cadastro","Você tem certeza que deseja cadastrar?","sim","não");
        if (resp == "sim")
        {

        }
         if (resp == "não")
        {
            
        }
    }
     void CancelClicked ( object sender EventArgs args)
    {
        var rest = await DisplayAlert ( "Cadastro","Você tem certeza que deseja cancelar?","sim" "não")
        if (resp == "sim")
        {

        }
         if (resp == "não")
        {

        }
    }
    void UnidadeClicked ( object sender EventArgs args)
    {
        string result = await DisplayPromptAsync("Cadastro de Unidade" "Nome:");
        {

        }
    }

}
