using AppVet.Views;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppVet
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        private void btnIngresar_Clicked(object sender, EventArgs e)
        {
            string docum = Documentotxt.Text;
            string cont = Contraseñatxt.Text;

            if (docum == "43065" && cont == "123")
            {
                Navigation.PushAsync(new Admin());
            }
            else
            {
                if (docum == "1017" && cont == "789")
                {
                    Navigation.PushAsync(new Veterinario());

                }

                else
                {
                    if (docum == "1128" && cont == "567")
                    {
                        Navigation.PushAsync(new Vendedor());
                    }
                    else
                    {
                        DisplayAlert("Alerta", "Su documento o contraseña no son correctos", "ok");
                    }
                }
            }
        }              
            
        }
    }
