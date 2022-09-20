using Nombredetuproyecto.VistaModelo;
using ProyectoXF.Modelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProyectoXF.VistaModelo
{
   public class VMPagina2: BaseViewModel
    {

        //Propiedades
        #region Propiedades
        private string _num1;
        private string _num2;
        private string _resultado;
        private string _tipoUser;


        public List<MUsuario> usuarios { get; set; }

        #endregion

        //Construtor
        #region Constructor
        public VMPagina2(INavigation navigation)
        {
            //con esto le decimos que el constructor se comportara como una pagina de navegacion
            //que puede ir hacia adelante o hacia atras
            Navigation = navigation;

            Llenar();

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

        public string TipoUser
        {
            get { return _tipoUser; }
            set { SetValue(ref _tipoUser, value); }
        }

        public string SeleccionarTipoUser
        {
            get { return _tipoUser; }
            set { SetValue(ref _tipoUser, value);

                TipoUser = _tipoUser;
            }
        }


        #endregion

        //Procesos
        #region Procesos
        public void Volver()
        {


            Navigation.PopAsync();

        }

        public void Llenar()
        {

            usuarios = new List<MUsuario> {


                new MUsuario{


                    Nombre="Jean Carlos",
                    
                    Imagen= "football.png" },

                new MUsuario{


                    Nombre="Carlos Morales",

                    Imagen= "rocket.png" },

                 new MUsuario{


                    Nombre="Frank Morales",

                    Imagen= "snail.png" },



             

            };




        }
        #endregion




        //Comandos
        #region Comandos

        public ICommand VolverCommand => new Command(() => Volver());
        public ICommand LlenarCommand => new Command(() => Llenar());
        // public ICommand AlertaCommand => new Command(async () => await Alerta());

        #endregion
    }
}
