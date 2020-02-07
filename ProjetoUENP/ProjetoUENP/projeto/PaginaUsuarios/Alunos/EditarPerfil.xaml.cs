using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetoUENP.projeto.PaginaUsuarios.Alunos
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EditarPerfil : ContentPage
	{
		public EditarPerfil ()
		{
			InitializeComponent ();

		}

        public async void EditarInfo(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Alunos.EditarInformarcoes());
        }

        public async void MudarSenha(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Alunos.MudarSenha());
        }
    }
}