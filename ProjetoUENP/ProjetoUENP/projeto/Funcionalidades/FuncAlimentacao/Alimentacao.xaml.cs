using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetoUENP.projeto.Funcionalidades.FuncAlimentacao
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Alimentacao : ContentPage
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public Alimentacao ()
		{
			InitializeComponent ();
            this.BindingContext = this;
            this.IsBusy = false;
        }
        private async void AlimentacaoCP(object sender, EventArgs args)
        {
            this.IsBusy = true;
            await DandoUmTempo(3000);
            await Navigation.PushAsync(new Funcionalidades.FuncAlimentacao.AlimentacaoCP());
            this.IsBusy = false;
        }
        private async void AlimentacaoJacare(object sender, EventArgs args)
        {
            this.IsBusy = true;
            await DandoUmTempo(3000);
            await Navigation.PushAsync(new Funcionalidades.FuncAlimentacao.AlimentacaoJacare());
            this.IsBusy = false;
        }
        private async void AlimentacaoCLM(object sender, EventArgs args)
        {
            this.IsBusy = true;
            await DandoUmTempo(3000);
            await Navigation.PushAsync(new Funcionalidades.FuncAlimentacao.AlimentacaoBand());
            this.IsBusy = false;
        }
        async Task DandoUmTempo(int valor)
        {
            await Task.Delay(valor);
        }
    }
}