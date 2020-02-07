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
	public partial class PerfilAlunos : ContentPage
	{
		public PerfilAlunos ()
		{
			InitializeComponent ();

            Nome.Text = Aluno.nome_s;
            Campus.Text = Aluno.campus_s;
            Curso.Text = Aluno.curso_s;
            Turno.Text = Aluno.turno_s;
            RA.Text = Aluno.RA_s;
            DataNascimento.Text = Aluno.Nascimento_s;
           // ListaMaterias.Text = Aluno.curso_s;
           // Nome.Text = Aluno.curso_s;
		}
	}
}