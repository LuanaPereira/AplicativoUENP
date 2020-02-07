using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetoUENP.projeto.PaginaUsuarios.Alunos
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Agenda : ContentPage
	{
        public Agenda ()
		{
			InitializeComponent ();
            DataHoje.Text = DateTime.Now.DayOfWeek.ToString() + ", " + DateTime.Now.ToString("dd/MM");
            CarregarTarefas();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            CarregarTarefas();
        }
        public async void AddTarefa(object sender, EventArgs args)
        {
            //Navigation.InsertPageBefore(new PaginaUsuarios.Alunos.AdicionarNota(), this);
            //await Navigation.PopAsync().ConfigureAwait(false);
            await Navigation.PushAsync(new PaginaUsuarios.Alunos.AdicionarNota());
        }

        private void CarregarTarefas()
        {
            
            SLTarefas.Children.Clear();

            List<Tarefa> Lista = new GerenciaTarefa().Listagem();
            int i = 0;
            foreach (Tarefa tarefa in Lista)
            {
                LinhaStack(tarefa, i);
                i++;
            }
            Tarefa ord = new Tarefa();
            Lista = Lista.OrderBy(c => ord.Data).ToList();
        }

        public void LinhaStack(Tarefa tarefa, int Index)
        {
            View StackCentral = null;
            if (tarefa.DataFinalizacao == null)
            {
                string[] data = new string[1];
                data = tarefa.Data.Date.ToString().Split(' ');
                StackCentral = new Label() { VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.FillAndExpand, Text = tarefa.Nome + " - " + data[0] };
            }
            else
            {
                StackCentral = new StackLayout() { VerticalOptions = LayoutOptions.Center, Spacing = 0, HorizontalOptions = LayoutOptions.FillAndExpand };
                ((StackLayout)StackCentral).Children.Add(new Label() {Text = tarefa.Nome, TextColor = Color.Gray});
                ((StackLayout)StackCentral).Children.Add(new Label() {Text ="Finalizado em " + tarefa.DataFinalizacao.Value.ToString("dd/MM/yyyy - hh:mm" + "h"), TextColor = Color.Gray, FontSize = 10});


            }
            Image Delete = new Image() { VerticalOptions = LayoutOptions.Center, Source = ImageSource.FromFile("Delete.png")};
            TapGestureRecognizer DeleteTap = new TapGestureRecognizer();
            DeleteTap.Tapped += delegate
            {
                new GerenciaTarefa().Remover(Index);
                CarregarTarefas();
            };
            Delete.GestureRecognizers.Add(DeleteTap);

            Image Prioridade = new Image() { VerticalOptions = LayoutOptions.Center, Source = ImageSource.FromFile("P" + tarefa.Prioridade + ".png")};
            Image Check = new Image() { VerticalOptions = LayoutOptions.Center, Source = ImageSource.FromFile("CheckOff.png")};
            
            
            
            TapGestureRecognizer CheckTap = new TapGestureRecognizer();
            CheckTap.Tapped += delegate
            {
                if(tarefa.DataFinalizacao == null)
                {
                    new GerenciaTarefa().Finalizar(Index, tarefa);
                    CarregarTarefas();
                }
                else
                {
                    new GerenciaTarefa().naoPronta(Index, tarefa);
                    CarregarTarefas();
                }
                
            };
            if (tarefa.DataFinalizacao != null)
            {
                Check.Source = ImageSource.FromFile("CheckOn.png");
            }
            else
            {
                Check.Source = ImageSource.FromFile("CheckOff.png");
            }

            Check.GestureRecognizers.Add(CheckTap);
            
            StackLayout linha = new StackLayout() { Orientation = StackOrientation.Horizontal, Spacing = 15 };
           
            linha.Children.Add(Check);
            linha.Children.Add(StackCentral);
            linha.Children.Add(Prioridade);
            linha.Children.Add(Delete);

            SLTarefas.Children.Add(linha);

        }
	}
}