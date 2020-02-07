using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoUENP.projeto.PaginaUsuarios.Alunos;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetoUENP.projeto.PaginaUsuarios.Alunos
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AdicionarNota : ContentPage
	{
        private byte Prioridade { get; set; }
		public AdicionarNota ()
		{
			InitializeComponent ();
		}
        public void PrioridadeSelect(object sender, EventArgs args)
        {
            var Stacks = SLPrioridade.Children;

            foreach (var Linha in Stacks)
            {
                Label lbPrioridades = ((StackLayout)Linha).Children[1] as Label;
                lbPrioridades.TextColor = Color.Gray;
            }

            ((Label)((StackLayout)sender).Children[1]).TextColor = Color.Black;
            FileImageSource Source =  ((Image)((StackLayout)sender).Children[0]).Source as FileImageSource;

            string Prioridade =  Source.File.ToString().Replace("P","").Replace(".png", "");


            this.Prioridade =  byte.Parse(Prioridade);
        }
        public async void SalvarAcao(object sender, EventArgs args)
        {
            bool Erro = false;
            if (String.IsNullOrEmpty(Nota.Text))
            {
                Erro = true;
               await DisplayAlert("ERRO", "Adicionar nota", "OK");
            }
            if (!(this.Prioridade > 0))
            {
                Erro = true;
              await  DisplayAlert("ERRO", "Adicionar Prioridade", "OK");
            }        
            
            if (Erro == false)
            {
                Tarefa tarefa = new Tarefa
                {
                    Nome = Nota.Text.Trim(),
                    Data = DataNota.Date,
                    Prioridade = this.Prioridade
                };

                new GerenciaTarefa().Salvar(tarefa);
                await Navigation.PopAsync();
                //App.Current.MainPage = new NavigationPage(new Agenda());
              
            }
        }

    }
}