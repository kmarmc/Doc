using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using Modelos;

namespace ProjetoSistema
{
    public partial class TelaBordado : ContentPage
    {
        public ObservableCollection<Bordado> Bordados { get; set; }

        public TelaBordado()
        {
            InitializeComponent();

            Bordados = new ObservableCollection<Bordado>();
            var bordado1 = new Bordado();
            bordado1.SetQuantidade(1);
            bordado1.SetLinhas("ncjndoo");
            bordado1.SetNumeroDaOp(1);

            var bordado2 = new Bordado();
            bordado2.SetQuantidade(2);
            bordado2.SetLinhas("jmfkngjhn");
            bordado2.SetNumeroDaOp(2);


            Bordados.Add(bordado1);
            Bordados.Add(bordado2);

            BindingContext = this;
        }
    }
}
