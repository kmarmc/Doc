using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using Modelos;

namespace ProjetoSistema
{
    public partial class TelaAlmoxarifado : ContentPage
    {
        public ObservableCollection<Almoxarifado> Almoxarifados { get; set; }

        public TelaAlmoxarifado()
        {
            InitializeComponent();

               Almoxarifados = new ObservableCollection<Almoxarifado>();
            var almoxarifado1 = new Almoxarifado();
            almoxarifado1.SetQuantidade(1);
            almoxarifado1.SetMateriaisEnvio("ncjndoo");
            almoxarifado1.SetNumeroDaOp(1);

            var almoxarifado2 = new Almoxarifado();
            almoxarifado2.SetQuantidade(2);
            almoxarifado2.SetMateriaisEnvio("jmfkngjhn");
            almoxarifado2.SetNumeroDaOp(2);


            Almoxarifados.Add(almoxarifado1);
            Almoxarifados.Add(almoxarifado2);

            BindingContext = this;
        }
    }
}
