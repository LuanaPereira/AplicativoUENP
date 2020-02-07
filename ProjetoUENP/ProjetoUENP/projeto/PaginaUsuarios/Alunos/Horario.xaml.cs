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
	public partial class Horario : ContentPage
	{
		public Horario ()
		{
			InitializeComponent ();
            Verificar();
           
        }
        public void Verificar()
        {

            // if (Aluno.curso_s == "Administração") { }
            //  if (Aluno.curso_s == "Ciências Comtábies")
            //  if (Aluno.curso_s == "Ciências Econômicas")
            //  if (Aluno.curso_s == "Geogrfia")
            //  if (Aluno.curso_s == "Odontologia")
            //  if (Aluno.curso_s == "Direito")
            //  if (Aluno.curso_s == "Educação Física")
            //  if (Aluno.curso_s == "Filosofia")
            //  if (Aluno.curso_s == "História")
            //  if (Aluno.curso_s == "Fisioterapia")
            //  if (Aluno.curso_s == "Agronomia")
            if (Aluno.curso_s == "Ciência da Computação")
            {
                Site.Source = "https://drive.google.com/open?id=1--bMhsO5MJtjv4FZ8vBS80OYQwkVMhAs";
            }
            //  if (Aluno.curso_s == "Computação")
            //  if (Aluno.curso_s == "Enfermagem")
            //  if (Aluno.curso_s == "Medicina Veterianária")
            //  if (Aluno.curso_s == "Sistemas de Informação")
            //  if (Aluno.curso_s == "Ciências Biológicas" && Aluno.campus_s == "Cornélio Procópio")
            //  if (Aluno.curso_s == "Ciências Biológicas" && Aluno.campus_s == "Jacarezinho")
            //  if (Aluno.curso_s == "Ciências Biológicas" && Aluno.campus_s == "Luiz Meneghel")
            //  if (Aluno.curso_s == "Letras Inglês" && Aluno.campus_s == "Cornélio Procópio")
            //  if (Aluno.curso_s == "Letras Inglês" && Aluno.campus_s == "Jacarezinho")
            //  if (Aluno.curso_s == "Letras Espanhol" && Aluno.campus_s == "Jacarezinho")
            //  if (Aluno.curso_s == "Pedagogia" && Aluno.campus_s == "Jazarezinho")
            //  if (Aluno.curso_s == "Pedagogia" && Aluno.campus_s == "Cornélio Procópio")
            //  if (Aluno.curso_s == "Matemática" && Aluno.campus_s == "Jazarezinho")
            //  if (Aluno.curso_s == "Matemática" && Aluno.campus_s == "COrnélio Procópio")
        }
        public void ActionCarregando(object sender, EventArgs args)
        {
            Status.Text = "Carregando...";
        }
        public void ActionCarregado(object sender, EventArgs args)
        {
            Status.Text = "Carregado";
        }
    }
}