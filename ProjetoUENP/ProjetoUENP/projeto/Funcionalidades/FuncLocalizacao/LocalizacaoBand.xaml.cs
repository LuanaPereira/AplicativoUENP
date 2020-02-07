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
	public partial class LocalizacaoBand : ContentPage
	{
		public LocalizacaoBand ()
		{
			InitializeComponent ();
            var mapa = new Map(MapSpan.FromCenterAndRadius(new Position(-23.1072577, -50.3612942), Distance.FromKilometers(5)));
             mapa.MapType = MapType.Street;
            var bandeirantes = new Pin()
            {
                Position = new Position(-23.1072577, -50.3612942),
                Label = "UENP Campus Luiz Meneghel",
                Address = "BR 369, Bandeirantes - PR 86360 - 000",
            };
            mapa.Pins.Add(bandeirantes);
            MapsConteiner.Children.Add(mapa);
        }
	}
}