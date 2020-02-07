using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetoUENP.projeto.Funcionalidades.FuncCursos
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Cursos : ContentPage
	{
		public Cursos ()
		{
			InitializeComponent ();
		}
        private async void MudarAdministracao(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Funcionalidades.FuncCursos.Administracao());
        }
        private async void MudarAgronomia(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Funcionalidades.FuncCursos.Agronomia());
        }
        private async void MudarBiologia(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Funcionalidades.FuncCursos.Biologia());
        }
        private async void MudarContabeis(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Funcionalidades.FuncCursos.Contabeis());
        }
        private async void MudarComputacao(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Funcionalidades.FuncCursos.CienciaDaComputacao());
        }
        private async void MudarEconomia(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Funcionalidades.FuncCursos.Economia());
        }
        private async void MudarDireito(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Funcionalidades.FuncCursos.Direito());
        }
        private async void MudarEdFisica(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Funcionalidades.FuncCursos.EdFisica());
        }
        private async void MudarEnfermagem(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Funcionalidades.FuncCursos.Enfermagem());
        }
        private async void MudarFilosofia(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Funcionalidades.FuncCursos.Filosofia());
        }
        private async void MudarFisioterapia(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Funcionalidades.FuncCursos.Fisioterapia());
        }
        private async void MudarGeografia(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Funcionalidades.FuncCursos.Geografia());
        }
        private async void MudarHistoria(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Funcionalidades.FuncCursos.Historia());
        }
        private async void MudarLetras(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Funcionalidades.FuncCursos.Letras());
        }
        private async void MudarMatematica(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Funcionalidades.FuncCursos.Matematica());
        }
        private async void MudarVeterinaria(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Funcionalidades.FuncCursos.Veterinaria());
        }
        private async void MudarOdontologia(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Funcionalidades.FuncCursos.Odontologia());
        }
        private async void MudarPedagogia(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Funcionalidades.FuncCursos.Pedagogia());
        }
        private async void MudarSI(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Funcionalidades.FuncCursos.SI());
        }
        private async void MudarLicenciaturaComputacao(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Funcionalidades.FuncCursos.Computacao());
        }
    }
}