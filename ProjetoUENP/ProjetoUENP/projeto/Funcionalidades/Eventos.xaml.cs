using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetoUENP.projeto.Funcionalidades
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Eventos : ContentPage
	{
		public Eventos ()
		{
			InitializeComponent ();
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