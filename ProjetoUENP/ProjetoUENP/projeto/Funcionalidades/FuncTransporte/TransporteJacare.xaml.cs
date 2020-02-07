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
	public partial class TransporteJacare : ContentPage
	{
        public List<Transporte> lista;

        public TransporteJacare ()
		{
			InitializeComponent ();

            WebClient wc = new WebClient();
            try
            {
                String resultado = wc.DownloadString("https://app-uenp.firebaseio.com/transporte/jacarezinho/.json");
                lista = JsonConvert.DeserializeObject<List<Transporte>>(resultado);

                ListaTransporte.ItemsSource = lista;
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
            Transporte ligar = ListaTransporte.SelectedItem as Transporte;

            var phoneDialer = CrossMessaging.Current.PhoneDialer;
            if (phoneDialer.CanMakePhoneCall && !String.IsNullOrWhiteSpace(ligar.Telefone))
                phoneDialer.MakePhoneCall(ligar.Telefone);
        }
    }
}