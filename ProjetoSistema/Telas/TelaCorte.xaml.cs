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

          Cortes = new ObservableCollection<Corte>();
            var corte1 = new Corte();
            corte1.Quantidade = 1;
            corte1.Cortador = "ncjndoo";
            corte1.NumeroDaOp = 1;

            var corte2 = new Corte();
            corte2.Quantidade = 2;
            corte2.Cortador = "jmfkngjhn";
            corte2.NumeroDaOp = 2;


            Cortes.Add(corte1);
            Cortes.Add(corte2);
            
            BindingContext = this;
    }
     private void Voltar(object sender, EventArgs args)
    {
        if (Application.Current != null)
        Application.Current.MainPage = new TelaInicial();
    }
    }

}
