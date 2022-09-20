using ProyectoXF.Vistas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoXF
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //le decimos que vamos a navegar entre paginas(toolbar) y que la pagina de inicio sera Menu Principal
            MainPage = new NavigationPage(new MenuPrincipal());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
