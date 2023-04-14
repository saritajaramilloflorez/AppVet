using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppVet.Views.Medico
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuMed : ContentPage
    {
        public MenuMed()
        {
            InitializeComponent();
        }

        private void salir1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void Historia1Txt_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HistoriaClinica());
        }

        private void RegistrarpacTxt_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegistroPac());
        }
    }
}