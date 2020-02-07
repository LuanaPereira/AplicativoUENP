using Newtonsoft.Json;
using Plugin.Connectivity;
using Plugin.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetoUENP.projeto.Funcionalidades.FuncAlimentacao
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AlimentacaoBand : ContentPage
    {
        public List<Alimentacao> lista;

        public AlimentacaoBand ()
		{
			InitializeComponent ();

            WebClient wc = new WebClient();
            try
            {
                String resultado = wc.DownloadString("https://app-uenp.firebaseio.com/alimentacao/bandeirantes/.json");
                lista = JsonConvert.DeserializeObject<List<Alimentacao>>(resultado);
                
                ListaAlimentacao.ItemsSource = lista;
            }
            catch
            {
                if (CrossConnectivity.Current.IsConnected == false)
                {
                    Label Label = new Label { Text = "Aparelho não conectado a internet, verifique a conexão" };

                }
            }
        }
        public void Chamar(object sender, EventArgs e)
        {
            Alimentacao ligar = ListaAlimentacao.SelectedItem as Alimentacao;
           
            var phoneDialer = CrossMessaging.Current.PhoneDialer;
            if (phoneDialer.CanMakePhoneCall && !String.IsNullOrWhiteSpace(ligar.Telefone))
               phoneDialer.MakePhoneCall(ligar.Telefone);
        }
    }
}