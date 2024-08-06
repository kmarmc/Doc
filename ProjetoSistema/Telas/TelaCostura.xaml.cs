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

            Costuras = new ObservableCollection<Costura>();
            var costura1 = new Costura();
            costura1.SetQuantidade(1);
            costura1.SetNumeroDaOp(123);
            costura1.SetAviamentos("aksjldaskjdlkasjd");

            var costura2 = new Costura();
            costura2.SetQuantidade(2);
            costura2.SetNumeroDaOp(321);
            costura2.SetAviamentos("aksjldaskjdlkasjd");


            Costuras.Add(costura1);
            Costuras.Add(costura2);



            BindingContext = this;
        }
    }
}
