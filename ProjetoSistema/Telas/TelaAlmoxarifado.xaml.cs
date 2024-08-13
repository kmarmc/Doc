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
            almoxarifado1.Quantidade = 1;
            almoxarifado1.MateriaisEnvio = "ncjndoo";
            almoxarifado1.NumeroDaOp = 1;

            var almoxarifado2 = new Almoxarifado();
            almoxarifado2.Quantidade = 2;
            almoxarifado2.MateriaisEnvio = "jmfkngjhn";
            almoxarifado2.NumeroDaOp = 2;


            Almoxarifados.Add(almoxarifado1);
            Almoxarifados.Add(almoxarifado2);

            BindingContext = this;
        }
    }
}
