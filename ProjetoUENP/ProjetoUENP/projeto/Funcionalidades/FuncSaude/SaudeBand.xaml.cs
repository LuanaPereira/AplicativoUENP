﻿using Newtonsoft.Json;
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

namespace ProjetoUENP.projeto.Funcionalidades.FuncSaude
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SaudeBand : ContentPage
	{
        public List<Saude> lista;

        public SaudeBand ()
		{
			InitializeComponent ();

            WebClient wc = new WebClient();

            try
            {
                String resultado = wc.DownloadString("https://app-uenp.firebaseio.com/saude/bandeirantes/.json");
                lista = JsonConvert.DeserializeObject<List<Saude>>(resultado);

                ListaSaude.ItemsSource = lista;
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
            Saude ligar = ListaSaude.SelectedItem as Saude;

            var phoneDialer = CrossMessaging.Current.PhoneDialer;
            if (phoneDialer.CanMakePhoneCall && !String.IsNullOrWhiteSpace(ligar.Telefone))
                phoneDialer.MakePhoneCall(ligar.Telefone);
        }
    }
}