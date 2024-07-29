using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using Modelos;

namespace ProjetoSistema
{
    public partial class TelaCostura : ContentPage
    {
        public ObservableCollection<Costura> Costuras { get; set; }

        public TelaCostura()
        {
            InitializeComponent();

            Costuras = new ObservableCollection<Costura>
            {
                // Exemplos de dados
                new Costura { QuantLote = "QuantLote  1", Aviamentos = "Aviamentos 1", NumeroDeOp = "123456789" },
                new Costura { QuantLote  = "QuantLote  2", Aviamentos = "Aviamentos 2", NumeroDeOp = "987654321" }
            };

            BindingContext = this;
        }
    }
}
