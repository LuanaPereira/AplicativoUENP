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
	public partial class LocalizacaoJacare : ContentPage
	{
		public LocalizacaoJacare ()
		{
			InitializeComponent ();
            Map mapa = new Map(MapSpan.FromCenterAndRadius(new Position(-23.1604204, -49.9741699), Distance.FromKilometers(2)));
            mapa.MapType = MapType.Street;
            var jacarezinho = new Pin()
            {
                Position = new Position(-23.1604204, -49.9741699),
                Label = "REITORIA UENP - UNIVERSIDADE ESTADUAL DO NORTE DO PARANÁ",
                Address = "Av.Getúlio Vargas, 850, Jacarezinho - PR, 86400 - 000",
            };
            mapa.Pins.Add(jacarezinho);
            MapsConteiner.Children.Add(mapa);
        }
	}
}