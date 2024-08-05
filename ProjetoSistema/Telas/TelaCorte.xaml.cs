using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using Modelos;

namespace ProjetoSistema
{
    public partial class TelaCorte : ContentPage
    {
        public ObservableCollection<Corte> Cortes { get; set; }

        public TelaCorte()
        {
            InitializeComponent();

            Corte = new ObservableCollection<Corte>
            {
                // Exemplos de dados
                new Corte { QuantLote = "QuantLote  1", Cortador = "Cortador 1", NumeroDeOp = "123456789" },
                new Corte { QuantLote  = "QuantLote  2", Cortador = "Cortador 2", NumeroDeOp = "987654321" }
            };

            BindingContext = this;
        }
    }
    
    void CortadorClicked ( object sender, EventArgs args)
    {
        string result = await DisplayPromptAsync("Cadastro de Cortador", "Nome:");
        {

        }
    }

}
