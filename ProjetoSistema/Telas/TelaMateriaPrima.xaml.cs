using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using Modelos;

namespace ProjetoSistema
{
    public partial class TelaMateriaPrima : ContentPage
    {
        public ObservableCollection<MateriaPrima> MateriaPrimas { get; set; }

        public TelaMateriaPrima()
        {
            InitializeComponent();

          MateriaPrimas = new ObservableCollection<MateriaPrima>();
            var materiaprima1 = new MateriaPrima();
            materiaprima1.IdMateria = 1;
            materiaprima1.Nome = "ncjndoo";
            materiaprima1.Quantidade = 1;

            var materiaprima2 = new MateriaPrima();
            materiaprima2.IdMateria = 2;
            materiaprima2.Nome = "jmfkngjhn";
            materiaprima2.Quantidade = 2;


            MateriaPrimas.Add(materiaprima1);
            MateriaPrimas.Add(materiaprima2);

            BindingContext = this;
        }
        private void Voltar(object sender, EventArgs args)
    {
        if (Application.Current != null)
        Application.Current.MainPage = new TelaInicial();
    }
    private void Cadastrar(object sender, EventArgs args)
    {
        if (Application.Current != null)
        Application.Current.MainPage = new CadastroDeMateriaPrima();
    }
    }
}
