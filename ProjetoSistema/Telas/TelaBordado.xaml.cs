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
            bordado1.Quantidade = 1;
            bordado1.Linhas = "ncjndoo";
            bordado1.NumeroDaOp = 1;

            var bordado2 = new Bordado();
            bordado2.Quantidade = 2;
            bordado2.Linhas = "jmfkngjhn";
            bordado2.NumeroDaOp = 2;


            Bordados.Add(bordado1);
            Bordados.Add(bordado2);

            BindingContext = this;
        }
         private void Voltar(object sender, EventArgs args)
    {
        if (Application.Current != null)
        Application.Current.MainPage = new TelaInicial();
    }
    }
}
