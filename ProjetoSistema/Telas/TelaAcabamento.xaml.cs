using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using Modelos;

namespace ProjetoSistema
{
    public partial class TelaAcabamento : ContentPage
    {
        public ObservableCollection<Acabamento> Acabamento { get; set; }

        public TelaAcabamento()
        {
            InitializeComponent();

            Acabamento = new ObservableCollection<Acabamento>
            {
                // Exemplos de dados
                new Acabamento { QuantLote = "QuantLote  1", Aviamentos = "Aviamentos 1", NumeroDeOp = "123456789" },
                new Acabamento { QuantLote  = "QuantLote  2", Aviamentos = "Aviamentos 2", NumeroDeOp = "987654321" }
            };

            BindingContext = this;
        }
    }
}
