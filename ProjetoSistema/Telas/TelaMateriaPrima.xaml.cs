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
            materiaprima1.SetIdMateria(1);
            materiaprima1.SetNome("ncjndoo");
            materiaprima1.SetQuantidade(1);

            var materiaprima2 = new MateriaPrima();
            materiaprima2.SetIdMateria(2);
            materiaprima2.SetNome("jmfkngjhn");
            materiaprima2.SetQuantidade(2);


            MateriaPrimas.Add(materiaprima1);
            MateriaPrimas.Add(materiaprima2);

            BindingContext = this;
        }
    }
}
