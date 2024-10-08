using System;
using Controles;
using Microsoft.Maui.Controls;
using Modelos;

namespace ProjetoSistema
{
    public partial class CadastroPedidos : ContentPage
    {
        public Pedido pedido { get; set; }
        ControlePedido controlePedido = new ControlePedido(); 
        
        public CadastroPedidos()
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
            private async void DeletarPedido(object sender, EventArgs e)
        {
            if (pedido == null || pedido.Id < 1)
                await DisplayAlert("Erro", "Nenhum pedido   para excluir", "ok");
            else if (await DisplayAlert("Deletar", "Você tem certeza que deseja deletar?", "Sim", "Não"))
            {
                controlePedido.Apagar(pedido.Id);
                Application.Current.MainPage = new TelaCliente();
            }
        }
       
protected override void OnAppearing()
  {
    base.OnAppearing();

    if (pedido != null)
    {
      IdLabel.Text        = pedido.Id.ToString();
      NomeEntry.Text      = pedido.Nome;
      EnderecoEntry.Text      = pedido.Endereco;
       EmailEntry.Text      = pedido.Email;
       ProdutoEntry.Text      = pedido.Produto;   
      TelefoneEntry.Text  = pedido.Telefone;
    }
  }
   
        protected async void SalvarPedido(object sender, EventArgs e)
        {
            if (await VerificarDados())
            {
                var pedido = new Pedidos();
            if (!String.IsNullOrEmpty(IdLabel.Text))
                pedido.Id = int.Parse(IdLabel.Text);
            else
            pedido .Id = 0;
            pedido.Nome = NomeEntry.Text;
            pedido.Endereco = EnderecoEntry.Text;
            pedido.Email = EmailEntry.Text;
            pedido.Telefone = TelefoneEntry.Text;
            pedido.Produto = ProdutoEntry.Text;
            pedido.ValorUnidade = decimal.Parse (ValorUnidadeEntry.Text);
            pedido.Quantidade = int.Parse (NomeQuantidadeEntry.Text);
            pedido.ValorTotal = int.Parse (ValorTotalEntry.Text);            
            controlePedido.CriarOuAtualizar(pedido);
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
            else if (String.IsNullOrEmpty(ProdutoEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Produto é obrigatório", "OK");
                return false;
            }
            else if (String.IsNullOrEmpty(ValorUnidadeEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Valor é obrigatório", "OK");
                return false;
            }
            else if (String.IsNullOrEmpty(NomeQuantidadeEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Quantidade é obrigatório", "OK");
                return false;
            }
            else if (String.IsNullOrEmpty(ValorTotalEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Valor Total é obrigatório", "OK");
                return false;
            }

            else
                return true;
        }
    }

    internal class Pedidos : Pedido
    {
    }
}
