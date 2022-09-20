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
    public partial class MenuPrincipal : ContentPage
    {
        public MenuPrincipal()
        {
            InitializeComponent();

            //ENLAZAMOS LA CLASE DE VIEWMODELS CON EL FRONT
            BindingContext = new VMMenuPrincipal(Navigation);
        }
    }
}