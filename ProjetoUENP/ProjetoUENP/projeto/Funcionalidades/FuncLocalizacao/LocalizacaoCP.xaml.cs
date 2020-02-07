using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace ProjetoUENP.projeto.Funcionalidades.FuncLocalizacao
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LocalizacaoCP : ContentPage
	{
		public LocalizacaoCP ()
		{
			InitializeComponent ();
            var mapa = new Map(MapSpan.FromCenterAndRadius(new Position(-23.1745882, -50.6695808), Distance.FromKilometers(5)));
            mapa.MapType = MapType.Street;
            var cp = new Pin()
            {
                Position = new Position(-23.1745882, -50.6695808),
                Label = "UENP - Campus de Cornélio Procópio",
                Address = "Rodovia PR 160, Km 0, Cornélio Procópio - PR, 86300-000",
            };
            mapa.Pins.Add(cp);
            MapsConteiner.Children.Add(mapa);
        }
	}
}