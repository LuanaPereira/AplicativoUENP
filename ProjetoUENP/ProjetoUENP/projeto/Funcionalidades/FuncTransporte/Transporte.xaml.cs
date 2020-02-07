using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetoUENP.projeto.Funcionalidades.FuncTransporte
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Transporte : ContentPage
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public Transporte ()
		{
			InitializeComponent ();
            this.BindingContext = this;
            this.IsBusy = false;
        }
        private async void TransporteCP(object sender, EventArgs args)
        {
            this.IsBusy = true;
            await DandoUmTempo(3000);
            await Navigation.PushAsync(new Funcionalidades.FuncTransporte.TransporteCP());
            this.IsBusy = false;
        }
        private async void TransporteJacare(object sender, EventArgs args)
        {
            this.IsBusy = true;
            await DandoUmTempo(3000);
            await Navigation.PushAsync(new Funcionalidades.FuncTransporte.TransporteJacare());
            this.IsBusy = false;
        }
        private async void TransporteCLM(object sender, EventArgs args)
        {
            this.IsBusy = true;
            await DandoUmTempo(5000);
            await Navigation.PushAsync(new Funcionalidades.FuncTransporte.TransporteBand());
            this.IsBusy = false;
        }
        async Task DandoUmTempo(int valor)
        {
            await Task.Delay(valor);
        }
    }
}