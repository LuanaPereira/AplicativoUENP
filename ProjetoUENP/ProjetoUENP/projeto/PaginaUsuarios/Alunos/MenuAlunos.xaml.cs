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
    public partial class MenuAlunos : MasterDetailPage
    {
        public MenuAlunos()
        {
            InitializeComponent();
        }
        private async void MudarPerfil(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new PaginaUsuarios.Alunos.EditarPerfil());
        }
        private async void MudarAgenda(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new PaginaUsuarios.Alunos.Agenda());
        }
        private async void MudarCalendario(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new PaginaUsuarios.Alunos.Calendario());
        }
        private async void MudarHorario(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new PaginaUsuarios.Alunos.Horario());
        }
        private async void MudarMaterias(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new PaginaUsuarios.Alunos.Materias());
        }
        private async void MudarSUAP(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new PaginaUsuarios.Alunos.SUAP());
        }
	}
}