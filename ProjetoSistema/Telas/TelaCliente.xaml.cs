using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using Modelos;
using ProjetoSistema.Modelos;

namespace ProjetoSistema
{
    public partial class TelaCliente : ContentPage
    {
        public ObservableCollection<Cliente> Cliente { get; set; }

        public TelaCliente()
        {
            InitializeComponent();

           Cliente = new ObservableCollection<Cliente>();
            var cliente1 = new Cliente();
            cliente1.Nome = "jnfjdbg";
            cliente1.Email = "ncjndoo";
            cliente1.Telefone = "fdhbd";

            var Cliente2 = new Cliente();
            Cliente2.Nome = "bfdhfbh";
            Cliente2.Email = "jmfkngjhn";
            Cliente2.Telefone = "jduif";


            Cliente.Add(cliente1);
            Cliente.Add(Cliente2);

            BindingContext = this;
        }
          private void Voltar(object sender, EventArgs args)
    {
        if (Application.Current != null)
        Application.Current.MainPage = new TelaInicial();
    }
    private void Cadastrar(object sender, EventArgs args)
    {
        if (Application.Current != null)
        Application.Current.MainPage = new CadastroCliente();
    }
    }
}
