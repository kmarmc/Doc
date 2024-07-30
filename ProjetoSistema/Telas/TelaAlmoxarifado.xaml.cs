using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using Modelos;

namespace ProjetoSistema
{
    public partial class TelaAlmoxarifado : ContentPage
    {
        public ObservableCollection<Almoxarifado> Almoxarifado { get; set; }

        public TelaAlmoxarifado()
        {
            InitializeComponent();

            Almoxarifado = new ObservableCollection<Almoxarifado>
            {
                // Exemplos de dados
                new Almoxarifado { QuantLote = "QuantLote  1", AviamentosParaEnvio = "AviamentosParaEnvio 1", NumeroDeOp = "123456789" },
                new Almoxarifado { QuantLote  = "QuantLote  2", AviamentosParaEnvio = "AviamentosParaEnvio 2", NumeroDeOp = "987654321" }
            };

            BindingContext = this;
        }
    }
}
