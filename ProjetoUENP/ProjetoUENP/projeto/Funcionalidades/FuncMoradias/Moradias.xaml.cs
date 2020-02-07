using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetoUENP.projeto.Funcionalidades.FuncMoradias
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Moradias : ContentPage
	{
        public int id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public Moradias ()
		{
			InitializeComponent ();
            this.BindingContext = this;
            this.IsBusy = false;
        }
        private async void MoradiasCP(object sender, EventArgs args)
        {
            this.IsBusy = true;
            await DandoUmTempo(3000);
            await Navigation.PushAsync(new Funcionalidades.FuncMoradias.MoradiasCP());
            this.IsBusy = false;
        }
        private async void MoradiasJacare(object sender, EventArgs args)
        {
            this.IsBusy = true;
            await DandoUmTempo(3000);
            await Navigation.PushAsync(new Funcionalidades.FuncMoradias.MoradiasJacare());
            this.IsBusy = false;
        }
        private async void MoradiasCLM(object sender, EventArgs args)
        {
            this.IsBusy = true;
            await DandoUmTempo(3000);
            await Navigation.PushAsync(new Funcionalidades.FuncMoradias.MoradiasBand());
            this.IsBusy = false;
        }
        async Task DandoUmTempo(int valor)
        {
            await Task.Delay(valor);
        }
    }
}