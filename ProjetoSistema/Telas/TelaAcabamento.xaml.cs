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
            acabamento1.SetQuantidade(1);
            acabamento1.SetAviamentos("ncjndoo");
            acabamento1.SetNumeroDaOp(1);

            var acabamento2 = new Acabamento();
            acabamento2.SetQuantidade(2);
            acabamento2.SetAviamentos("jmfkngjhn");
            acabamento2.SetNumeroDaOp(2);


            Acabamentos.Add(acabamento2);
            Acabamentos.Add(acabamento2);

            BindingContext = this;
        }
    }
}
