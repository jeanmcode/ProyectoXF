using Nombredetuproyecto.VistaModelo;
using ProyectoXF.Vistas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProyectoXF.VistaModelo
{
    public class VMMenuPrincipal : BaseViewModel
    {
        //Propiedades
        #region Propiedades
        private string _num1;
        private string _num2;
        private string _resultado;
        #endregion

        //Construtor
        #region Constructor
        public VMMenuPrincipal(INavigation navigation)
        {
            //con esto le decimos que el constructor se comportara como una pagina de navegacion
            //que puede ir hacia adelante o hacia atras
            Navigation = navigation;

        }
        #endregion

        //Objeto donde se utiliza BaseViewModel
        #region Objetos
        public string Num1
        {
            get { return _num1; }
            set { SetValue(ref _num1, value); }
        }

        public string Num2
        {
            get { return _num2; }
            set { SetValue(ref _num2, value); }
        }

        public string Resultado
        {
            get { return _resultado; }
            set { SetValue(ref _resultado, value); }
        }

        #endregion

        //Procesos
        #region Procesos
        public void NavPagina2()
        {
            //Para llamar a la pagina 2
            Navigation.PushAsync(new Pagina2());

        }


        public void NavPagina3()
        {
            Navigation.PushAsync(new Pagina3());
        }
        #endregion

     


        //Comandos
        #region Comandos

        public ICommand NavPagina2Command => new Command(() => NavPagina2());
        public ICommand NavPagina3Command => new Command(() => NavPagina3());
        // public ICommand AlertaCommand => new Command(async () => await Alerta());

        #endregion

    }
}
