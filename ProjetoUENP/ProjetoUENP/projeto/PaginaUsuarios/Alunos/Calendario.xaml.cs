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
	public partial class Calendario : ContentPage
	{
        public Calendario()
        {
            InitializeComponent();
            
        }

        public void ActionCarregando(object sender, EventArgs args)
        {
            Status.Text = "Carregando...";
        }
        public void ActionCarregado(object sender, EventArgs args)
        {
            Status.Text = "Carregado";
        }
    }
}