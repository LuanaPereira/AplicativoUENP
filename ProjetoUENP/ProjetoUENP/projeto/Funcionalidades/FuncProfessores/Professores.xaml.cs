using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetoUENP.projeto.Funcionalidades.FuncProfessores
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Professores : ContentPage
	{
        public int id { get; set; }
        public string Nome { get; set; }
        public string Lattes { get; set; }
        public string Email { get; set; }

        public Professores ()
		{
			InitializeComponent ();

            this.BindingContext = this;
            this.IsBusy = false;
     
        }
        private async void ProfessoresCP(object sender, EventArgs args)
        {
            this.IsBusy = true;
            await DandoUmTempo(3000);
            await Navigation.PushAsync(new Funcionalidades.FuncProfessores.ProfessoresCP());
            this.IsBusy = false;
        }
        private async void ProfessoresJacare(object sender, EventArgs args)
        {
            this.IsBusy = true;
            await DandoUmTempo(3000);
            await Navigation.PushAsync(new Funcionalidades.FuncProfessores.ProfessoresJacare());
            this.IsBusy = false;

        }
        private async void ProfessoresCLM(object sender, EventArgs args)
        {
            this.IsBusy = true;
            await DandoUmTempo(3000);
            await Navigation.PushAsync(new Funcionalidades.FuncProfessores.ProfessoresBand());
            this.IsBusy = false;

        }
        async Task DandoUmTempo(int valor)
        {
            await Task.Delay(valor);
        }
    }
}