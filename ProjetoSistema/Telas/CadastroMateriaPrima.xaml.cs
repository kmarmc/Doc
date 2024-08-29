using System;
using Controles;
using Microsoft.Maui.Controls;
using Modelos;

namespace ProjetoSistema
{
    public partial class CadastroDeMateriaPrima : ContentPage
    {
        public MateriaPrima materiaPrima { get; set; }
        ControleMateriaPrima controleMateriaPrima = new ControleMateriaPrima(); 

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
        private async void DeletarMateriaPrima(object sender, EventArgs e)
        {
            if (materiaPrima == null || materiaPrima.Id < 1)
                await DisplayAlert("Erro", "Nenhum materiaPrima   para excluir", "ok");
            else if (await DisplayAlert("Deletar", "Você tem certeza que deseja deletar?", "Sim", "Não"))
            {
                controleMateriaPrima.Apagar(materiaPrima.Id);
                Application.Current.MainPage = new TelaCliente();
            }
        }
        protected async void SalvarMateriaPrima(object sender, EventArgs e)
        {
            if (await VerificarDados())
            {
                var materiaPrima = new MateriaPrima();
            if (!String.IsNullOrEmpty(IdLabel.Text))
                materiaPrima.Id = int.Parse(IdLabel.Text);
            else
            materiaPrima .Id = 0;
            materiaPrima .Nome = NomeFornecedorEntry.Text;
            materiaPrima .Tipo = TipoDeMateriaEntry.Text;
            materiaPrima .Nome = NomeDaMateriaEntry.Text;
            materiaPrima .Valor = decimal.Parse(ValorDeMateriaEntry.Text);

            controleMateriaPrima.CriarOuAtualizar(materiaPrima  );
            await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
            }
        }
         private async Task<bool> VerificarDados()
        {

            if (String.IsNullOrEmpty(NomeFornecedorEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
                return false;
            }
            
            else if (String.IsNullOrEmpty(TipoDeMateriaEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Endereço é obrigatório", "OK");
                return false;
            }
            else if (String.IsNullOrEmpty(NomeDaMateriaEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Email é obrigatório", "OK");
                return false;
            }
            else if (String.IsNullOrEmpty(ValorDeMateriaEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Telefone é obrigatório", "OK");
                return false;
            }
            else
                return true;
        }

    }
}
