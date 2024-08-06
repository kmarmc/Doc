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
            corte1.SetQuantidade(1);
            corte1.SetCortador("ncjndoo");
            corte1.SetNumeroDaOp(1);

            var corte2 = new Corte();
            corte2.SetQuantidade(2);
            corte2.SetCortador("jmfkngjhn");
            corte2.SetNumeroDaOp(2);


            Cortes.Add(corte1);
            Cortes.Add(corte2);
            
            BindingContext = this;

    }
    }

}
