using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetoUENP.projeto.PaginaPrincipal
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PaginaInicial : ContentPage
	{
		public PaginaInicial ()
		{
			InitializeComponent ();
		}
        private async void MudarUENP(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Funcionalidades.A_UENP());
        }
        private async void MudarNoticias(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Funcionalidades.Noticias());
        }
        private async void MudarEventos(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Funcionalidades.Eventos());
        }
        private async void MudarProfessores(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Funcionalidades.FuncProfessores.Professores());
        }
        private async void MudarCursos(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Funcionalidades.FuncCursos.Cursos());
        }
        private async void MudarSaude(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Funcionalidades.FuncSaude.Saude());
        }
        private async void MudarAlimentacao(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Funcionalidades.FuncAlimentacao.Alimentacao());
        }
        private async void MudarMoradias(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Funcionalidades.FuncMoradias.Moradias());
        }
        private async void MudarTransporte(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Funcionalidades.FuncTransporte.Transporte());
        }
        private async void MudarLocalizacao(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Funcionalidades.FuncLocalizacao.Localizacao());
        }private async void MudarEditais(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Funcionalidades.Editais());
        }
    }
}