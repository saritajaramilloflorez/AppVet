using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppVet.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        
         public Menu()
        {
            InitializeComponent();

        }

        private void salir_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void RegistroEmTxt_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegistroEmp());
        }

        private void RegistroPaTxt_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegistroPac());
        }

        private void HistoriaTxt_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HistoriaClinica());
        }

        private void AjustesTxt_Clicked(object sender, EventArgs e)
        {

        }
    }
}