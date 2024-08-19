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
            costura1.Quantidade = 1;
            costura1.NumeroDaOp = 123;
            costura1.Aviamentos = "aksjldaskjdlkasjd";

            var costura2 = new Costura();
            costura2.Quantidade = 2;
            costura2.NumeroDaOp = 321;
            costura2.Aviamentos = "aksjldaskjdlkasjd";


            Costuras.Add(costura1);
            Costuras.Add(costura2);



            BindingContext = this;
        }
         private void Voltar(object sender, EventArgs args)
    {
        if (Application.Current != null)
        Application.Current.MainPage = new TelaInicial();
    }
    }
}
