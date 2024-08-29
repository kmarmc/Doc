using System;
using Controles;
using Microsoft.Maui.Controls;
using ProjetoSistema.Modelos;

namespace ProjetoSistema
{
    public partial class CadastroFornecedor : ContentPage
    {
         public Fornecedor fornecedor { get; set; }
        ControleFornecedor controleFornecedor = new ControleFornecedor(); 
        public CadastroFornecedor()
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
   private void Voltar(object sender, EventArgs args)
    {
        if (Application.Current != null)
        Application.Current.MainPage = new TelaInicial();
    }
    private async void DeletarFornecedor(object sender, EventArgs e)
        {
            if (fornecedor == null || fornecedor.Id < 1)
                await DisplayAlert("Erro", "Nenhum fornecedor   para excluir", "ok");
            else if (await DisplayAlert("Deletar", "Você tem certeza que deseja deletar?", "Sim", "Não"))
            {
                controleFornecedor.Apagar(fornecedor.Id);
                Application.Current.MainPage = new TelaCliente();
            }
        }
        protected async void SalvarFornecedor(object sender, EventArgs e)
        {
            if (await VerificarDados())
            {
                var fornecedor = new Fornecedor();
            if (!String.IsNullOrEmpty(IdLabel.Text))
                fornecedor.Id = int.Parse(IdLabel.Text);
            else
                fornecedor .Id = 0;
            fornecedor .Nome = NomeEntry.Text;
            fornecedor .Endereco = EnderecoEntry.Text;
            fornecedor .Email = EmailEntry.Text;
            fornecedor .Telefone = TelefoneEntry.Text;

            controleFornecedor.CriarOuAtualizar(fornecedor  );
            await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
            }
        }
         private async Task<bool> VerificarDados()
        {

            if (String.IsNullOrEmpty(NomeEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
                return false;
            }
            
            else if (String.IsNullOrEmpty(EnderecoEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Endereço é obrigatório", "OK");
                return false;
            }
            else if (String.IsNullOrEmpty(EmailEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Email é obrigatório", "OK");
                return false;
            }
            else if (String.IsNullOrEmpty(TelefoneEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Telefone é obrigatório", "OK");
                return false;
            }
            else if (String.IsNullOrEmpty(TipoMateriaPrimaEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Tipo de Matéria-Prima é obrigatório", "OK");
                return false;
            }   
            else if (String.IsNullOrEmpty(ValorMateriaPrimaEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Valor de Matéria-Prima é obrigatório", "OK");
                return false;
            }            

            else
                return true;
        }
        
}
}
