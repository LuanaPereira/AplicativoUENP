using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetoUENP.projeto.Funcionalidades.FuncSaude
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Saude : ContentPage
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public Saude ()
		{
			InitializeComponent ();
            this.BindingContext = this;
            this.IsBusy = false;
        }
        private async void SaudeCP(object sender, EventArgs args)
        {
            this.IsBusy = true;
            await DandoUmTempo(3000);
            await Navigation.PushAsync(new Funcionalidades.FuncSaude.SaudeCP());
            this.IsBusy = false;
        }
        private async void SaudeJacare(object sender, EventArgs args)
        {
            this.IsBusy = true;
            await DandoUmTempo(3000);
            await Navigation.PushAsync(new Funcionalidades.FuncSaude.SaudeJacare());
            this.IsBusy = false;
        }
        private async void SaudeCLM(object sender, EventArgs args)
        {
            this.IsBusy = true;
            await DandoUmTempo(3000);
            await Navigation.PushAsync(new Funcionalidades.FuncSaude.SaudeBand());
            this.IsBusy = false;
        }
        async Task DandoUmTempo(int valor)
        {
            await Task.Delay(valor);
        }
    }
}