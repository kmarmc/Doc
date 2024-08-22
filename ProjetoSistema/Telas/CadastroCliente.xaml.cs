using System;
using Controles;
using Microsoft.Maui.Controls;
using Modelos;

namespace ProjetoSistema
{
    public partial class CadastroCliente : ContentPage
    {
        public Cliente cliente { get; set; }
        ControleCliente controleCliente = new ControleCliente();

        public CadastroCliente()
        {
            InitializeComponent();
        }

   

        private void Voltar(object sender, EventArgs args)
        {
            if (Application.Current != null)
                Application.Current.MainPage = new TelaInicial();
        }
        private async void DeletarCliente(object sender, EventArgs e)
        {
            if (cliente == null || cliente.Id < 1)
                await DisplayAlert("Erro", "Nenhum cliente para excluir", "ok");
            else if (await DisplayAlert("Deletar", "Você tem certeza que deseja deletar?", "Sim", "Não"))
            {
                controleCliente.Apagar(cliente.Id);
                Application.Current.MainPage = new TelaCliente();
            }
        }
        protected async void SalvarCliente(object sender, EventArgs e)
        {
            if (await VerificarDados())
            {
                var cliente = new Cliente();
            if (!String.IsNullOrEmpty(IdLabel.Text))
                cliente.Id = int.Parse(IdLabel.Text);
            else
                cliente.Id = 0;
            cliente.Nome = NomeEntry.Text;
            cliente.Endereco = EnderecoEntry.Text;
            cliente.Email = EmailEntry.Text;
            cliente.Telefone = TelefoneEntry.Text;

            controleCliente.CriarOuAtualizar(cliente);
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
            else
                return true;
        }
        }
    }
