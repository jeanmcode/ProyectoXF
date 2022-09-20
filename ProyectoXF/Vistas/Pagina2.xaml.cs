using ProyectoXF.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoXF.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina2 : ContentPage
    {
        public Pagina2()
        {
            InitializeComponent();

            //enlazamos con la logica y le pasamos Navigation para decirle que se comportara como una pagina
            //de navegacion
            BindingContext = new VMPagina2(Navigation);
        }
    }
}