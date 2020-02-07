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

namespace ProjetoUENP.projeto.Funcionalidades.FuncTransporte
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TransporteBand : ContentPage
	{
        public List<Transporte> lista;
        public TransporteBand ()
		{
			InitializeComponent ();

            WebClient wc = new WebClient();
            try
            {
                String resultado = wc.DownloadString("https://app-uenp.firebaseio.com/transporte/bandeirantes/.json");
                lista = JsonConvert.DeserializeObject<List<Transporte>>(resultado);

                ListaTransporte.ItemsSource = lista;
            }
            catch
            {
                if (CrossConnectivity.Current.IsConnected == false)
                {
                    DisplayAlert("Atenção","Verifique a conexão", "OK");

                }
            }
        }
        public void Chamar(object sender, EventArgs e)
        {
            Transporte ligar = ListaTransporte.SelectedItem as Transporte;

            var phoneDialer = CrossMessaging.Current.PhoneDialer;
            if (phoneDialer.CanMakePhoneCall && !String.IsNullOrWhiteSpace(ligar.Telefone))
                phoneDialer.MakePhoneCall(ligar.Telefone);
        }
    }
}