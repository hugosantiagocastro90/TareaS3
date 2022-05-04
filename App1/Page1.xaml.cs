using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = "";
            string validar = validarInicio(txtusuario.Text, txtContrasena.Text);
            if (validar == "Error")
            {
                DisplayAlert("Usuario o Contraseña", validar, "Continuar");
            }
            else
            {
                usuario = txtusuario.Text;
                Navigation.PushAsync(new MainPage());
            }
        }
            private string validarInicio(string usuario, string pass)
            {
                string validacion = "";
                if (usuario == "santiago2022" && pass == "uisrael2022")
                {
                    validacion = "";

                }
                else
                {
                    validacion = "Error";
                }
                return validacion;
            }
      
    }
}