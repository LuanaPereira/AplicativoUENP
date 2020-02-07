using Newtonsoft.Json;
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
    public partial class Materias : ContentPage
    {
        public Materias()
        {
            InitializeComponent();
            CarregarTarefas();
        }
       
        public void CarregarTarefas()
        {

            List<string> Lista = ListagemNoProperties();
            int i = 0;
            for (i = 0; i < Lista.Count; i++)
            {
                LinhaStack(Lista, i);
               
            }
        }

        public void LinhaStack(List<string> Lista, int Index)
        {
            View StackCentral = null;

            StackCentral = new Label() { VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.FillAndExpand, Text = Lista[Index], TextColor = Color.Black, FontAttributes = FontAttributes.Bold};
                       
            StackLayout linha = new StackLayout() { Orientation = StackOrientation.Horizontal, Spacing = 15 };

            linha.Children.Add(StackCentral);
            ListaMateria.Children.Add(linha);
        }

        public List<string> ListagemNoProperties()
        {
            if (App.Current.Properties.ContainsKey("Materias"))
            {
                String JsonVal = (String)App.Current.Properties["Materias"];

                List<string> Lista = JsonConvert.DeserializeObject<List<string>>(JsonVal);
                return Lista;
                //return (List<Tarefa>)App.Current.Properties["Tarefas"];

            }
            return new List<string>();
        }
        public async void AddMateria(object sender, EventArgs args)
        {
            Navigation.InsertPageBefore(new PaginaUsuarios.Alunos.AdicionarMateria(), this);
            await Navigation.PopAsync().ConfigureAwait(false);
            //await Navigation.PushAsync(new PaginaUsuarios.Alunos.AdicionarMateria());
        }
    }
}