using Newtonsoft.Json;
using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetoUENP.projeto.Funcionalidades.FuncProfessores
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProfessoresBand : ContentPage
	{
        public List<Professores> lista;

        public ProfessoresBand ()
		{
			InitializeComponent ();

            WebClient wc = new WebClient();
            try
            {
                String resultado = wc.DownloadString("https://app-uenp.firebaseio.com/professores/CLM/.json");
                lista = JsonConvert.DeserializeObject<List<Professores>>(resultado);

                ListaProfessores.ItemsSource = lista;
            }
            catch
            {
                if (CrossConnectivity.Current.IsConnected == false)
                {
                    Label Label = new Label { Text = "Aparelho não conectado a internet, verifique a conexão" };

                }
            }
        }
	}
}