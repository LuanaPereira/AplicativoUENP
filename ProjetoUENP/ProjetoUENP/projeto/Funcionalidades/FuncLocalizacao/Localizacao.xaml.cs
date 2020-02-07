using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetoUENP.projeto.Funcionalidades.FuncLocalizacao
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Localizacao : ContentPage
	{
		public Localizacao ()
		{
			InitializeComponent ();
		}
        private async void LocalizacaoCP(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Funcionalidades.FuncLocalizacao.LocalizacaoCP());
        }
        private async void LocalizacaoJacare(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Funcionalidades.FuncLocalizacao.LocalizacaoJacare());
        }
        private async void LocalizacaoCLM(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Funcionalidades.FuncLocalizacao.LocalizacaoBand());
        }
    }
}