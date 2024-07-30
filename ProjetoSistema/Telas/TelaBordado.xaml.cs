using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using Modelos;

namespace ProjetoSistema
{
    public partial class TelaBordado : ContentPage
    {
        public ObservableCollection<Bordado> Bordado { get; set; }

        public TelaBordado()
        {
            InitializeComponent();

            Costuras = new ObservableCollection<Bordado>
            {
                // Exemplos de dados
                new Bordado { QuantLote = "QuantLote  1", Linhas = "Linhas 1", NumeroDeOp = "123456789" },
                new Bordado { QuantLote  = "QuantLote  2", Linhas = "Linhas 2", NumeroDeOp = "987654321" }
            };

            BindingContext = this;
        }
    }
}
