using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using Modelos;

namespace ProjetoSistema
{
    public partial class TelaAcabamento : ContentPage
    {
        public ObservableCollection<Acabamento> Acabamentos { get; set; }

        public TelaAcabamento()
        {
            InitializeComponent();

           
               Acabamentos = new ObservableCollection<Acabamento>();
            var acabamento1 = new Acabamento();
            acabamento1.Quantidade = 1;
            acabamento1.Aviamentos = "ncjndoo";
            acabamento1.NumeroDaOp = 1;

            var acabamento2 = new Acabamento();
            acabamento2.Quantidade = 2;
            acabamento2.Aviamentos = "jmfkngjhn";
            acabamento2.NumeroDaOp = 2;


            Acabamentos.Add(acabamento2);
            Acabamentos.Add(acabamento2);

            BindingContext = this;
        }
    }
}
