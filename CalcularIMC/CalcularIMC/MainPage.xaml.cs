using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalcularIMC
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            IniciarEventos();
        }

        private void IniciarEventos()
        {
            BotonCalcular.Clicked += OnAlertYesNoClicked;
        }

        async void OnAlertYesNoClicked(object sender, EventArgs e)
        {
            int peso = Convert.ToInt32(Peso.Text);
            double altura = Convert.ToDouble(Altura.Text);
            double resultado = peso / (altura * altura);
            await DisplayAlert("IMC", "Su IMC es de :" + resultado, "OK");
        }
    }
}
