using Nombredetuproyecto.VistaModelo;
using ProyectoXF.Vistas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProyectoXF.VistaModelo
{
   public  class VMPagina3 : BaseViewModel
    {

        //Propiedades
        #region Propiedades
        private string _num1;
        private string _num2;
 
        private DateTime _fecha;
        private string _resultadoFecha;
        
        #endregion

        //Construtor
        #region Constructor
        public VMPagina3(INavigation navigation)
        {
            //con esto le decimos que el constructor se comportara como una pagina de navegacion
            //que puede ir hacia adelante o hacia atras
            Navigation = navigation;
            Fecha = DateTime.Now;

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

        //es importante para que la fecha pueda cambiar en el label
        public string ResultadoFecha
        {
            get { return _resultadoFecha; }
            set { SetValue(ref _resultadoFecha, value); }
        }

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha= value;
                OnPropertyChanged(Fecha.ToString());
                ResultadoFecha = _fecha.ToString("dd/MM/yyy");
            } //cambia esta linea cuando son fechas

            //el onpropertychange notifica al frontent que hubo un cambio
            //se le pasa la fecha porque es el objeto que va estar cambiando
            
        }

        #endregion

        //Procesos
        #region Procesos
        public void Volver()
        {


            Navigation.PopAsync();

        }

       
        #endregion





        //Comandos
        #region Comandos

        public ICommand VolverCommand => new Command(() => Volver());
        // public ICommand AlertaCommand => new Command(async () => await Alerta());

        #endregion

    }
}
