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
	public partial class AdicionarMateria : ContentPage
    {
        List<string> materia = new List<string>();
        public AdicionarMateria ()
		{
			InitializeComponent ();
            materia = ListagemNoProperties();
            CarregarCheck();

        }
        public void Verificacao()
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
            /* if (Aluno.curso_s == "Ciência da Computação")
           {

                materia.Add("Administração");
                materia.Add("Algebra Linear");
                materia.Add("Arquitetura de Computadores");
                materia.Add("Banco de Dados");
                materia.Add("Cálculo I");
                materia.Add("Cálculo II");
                materia.Add("Compiladores");
                materia.Add("Computadores e Sociedade");
                materia.Add("Computação Gráfica");
                materia.Add("Computação Simbólica e Numérica");
                materia.Add("Comunicação e Expressão");
                materia.Add("Empreendorismo");
                materia.Add("Engenharia I");
                materia.Add("Engenharia II");
                materia.Add("Engenharia III");
                materia.Add("Estrutura de Dados");
                materia.Add("Física");
                materia.Add("Informática e Educação");
                materia.Add("Inteligência Artificial");
                materia.Add("Interface Homem Máquina");
                materia.Add("Linguagens de Programação");
                materia.Add("Matemática Discreta");
                materia.Add("Metodologia de Pesquisa");
                materia.Add("Prática e Gerenciamento de Projeto");
                materia.Add("Probabilidade e Estatística");
                materia.Add("Programação I");
                materia.Add("Programação II");
                materia.Add("Projeto e Análise de Algoritmo");
                materia.Add("Redes");
                materia.Add("Segurança e Auditoria de Sistemas");
                materia.Add("Sistemas Digitais");
                materia.Add("Sistemas Distribuídos");
                materia.Add("Sistemas Operacionais");
                materia.Add("Sociologia");
                materia.Add("Teoria da Computação");
                materia.Add("Teoria e Prática dos Sistemas de Informação");
           }*/
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
          //  if (Aluno.curso_s == "Matemática" && Aluno.campus_s == "Cornélio Procópio")
          
        }

        private async void Materia(object sender, EventArgs args)
        {
            List<String> MateriasSelecionadas = ListarMateriasCC();
            SalvarMateria(MateriasSelecionadas);
            await Navigation.PopAsync();
        }        
       

        private List<String> ListarMateriasCC()
        {
            List<String> ListaMaterias = new List<string>();
            if (Administracao.IsChecked)
            {
                ListaMaterias.Add("Administração");
            }
            if (AlgebraLinear.IsChecked)
            {
                ListaMaterias.Add("Algebra Linear");
            }
            if (ArquiteturaComputadores.IsChecked)
            {
                ListaMaterias.Add("Arquitetura de Computadores");
            }
            if (BancoDeDados.IsChecked)
            {
                ListaMaterias.Add("Banco de Dados");
            }
            if (Calculo1.IsChecked)
            {
                ListaMaterias.Add("Cálculo 1");
            }
            if (Calculo2.IsChecked)
            {
                ListaMaterias.Add("Cálculo 2");
            }
            if (Compiladores.IsChecked)
            {
                ListaMaterias.Add("Compiladores");
            }
            if (CompESociedade.IsChecked)
            {
                ListaMaterias.Add("Computadores e Sociedade");
            }
            if (ComputacaoGrafica.IsChecked)
            {
                ListaMaterias.Add("Computação Gráfica");
            }
            if (ComputacaoSimb.IsChecked)
            {
                ListaMaterias.Add("Computação Simbólica e Númerica");
            }
            if (ComunicacaoExp.IsChecked)
            {
                ListaMaterias.Add("Comunicação e Expressão");
            }
            if (Empreendedorismo.IsChecked)
            {
                ListaMaterias.Add("Empreendedorismo");
            }
            if (Eng1.IsChecked)
            {
                ListaMaterias.Add("Engenharia de Software 1");
            }
            if (Eng2.IsChecked)
            {
                ListaMaterias.Add("Engenharia de Software 2");
            }
            if (Eng3.IsChecked)
            {
                ListaMaterias.Add("Engenharia de Software 3");
            }
            if (Estrutura.IsChecked)
            {
                ListaMaterias.Add("Estrutura de Dados");
            }
            if (Fisica.IsChecked)
            {
                ListaMaterias.Add("Física");
            }
            if (InformaticaEd.IsChecked)
            {
                ListaMaterias.Add("Informática e Educação");
            }
            if (IA.IsChecked)
            {
                ListaMaterias.Add("Inteligência Artificial");
            }
            if (IHC.IsChecked)
            {
                ListaMaterias.Add("Interface Homem Máquina");
            }
            if (LinguagensProg.IsChecked)
            {
                ListaMaterias.Add("Linguagens de Programação");
            }
            if (MatDisc.IsChecked)
            {
                ListaMaterias.Add("Matemática Discreta");
            }
            if (Metodologia.IsChecked)
            {
                ListaMaterias.Add("Metodologia de Pesquisa");
            }
            if (GerenciamentoProjeto.IsChecked)
            {
                ListaMaterias.Add("Prática e Gerenciamento de Projeto");
            }
            if (ProbEst.IsChecked)
            {
                ListaMaterias.Add("Probabilidade e Estatística");
            }
            if (Prog1.IsChecked)
            {
                ListaMaterias.Add("Programação 1");
            }
            if (Prog2.IsChecked)
            {
                ListaMaterias.Add("Programação 2");
            }
            if (ProjAnalise.IsChecked)
            {
                ListaMaterias.Add("Projeto e Análise de Algoritmo");
            }
            if (Redes.IsChecked)
            {
                ListaMaterias.Add("Redes");
            }
            if (Auditoria.IsChecked)
            {
                ListaMaterias.Add("Segurança e Auditoria de Sistemas");
            }
            if (SistemasDigitais.IsChecked)
            {
                ListaMaterias.Add("Sistemas Digitais");
            }
            if (SistemasDistribuidos.IsChecked)
            {
                ListaMaterias.Add("Sistemas Distribuidos");
            }
            if (SO.IsChecked)
            {
                ListaMaterias.Add("Sistemas Operacionais");
            }
            if (Sociologia.IsChecked)
            {
                ListaMaterias.Add("Sociologia");
            }
            if (TeoriaComp.IsChecked)
            {
                ListaMaterias.Add("Teoria da Computação");
            }
            if (TeoriaEPrat.IsChecked)
            {
                ListaMaterias.Add("Teoria e Prática dos Sistemas de Informação");
            }

            return ListaMaterias;
        }

        public void SalvarMateria(List<string> Materia)
        {
            if (App.Current.Properties.ContainsKey("Materias"))
            {
                App.Current.Properties.Remove("Materias");
            }

            string JsonVal = JsonConvert.SerializeObject(Materia);

            App.Current.Properties.Add("Materias", JsonVal);
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

        public void CarregarCheck()
        {
            if (materia.Contains("Administração"))
            {
                Administracao.IsChecked = true;
            }
            if (materia.Contains("Algebra Linear"))
            {
                AlgebraLinear.IsChecked = true;
            }
            if (materia.Contains("Arquitetura de Computadores"))
            {
                ArquiteturaComputadores.IsChecked = true;
            }
            if (materia.Contains("Banco de Dados"))
            {
                BancoDeDados.IsChecked = true;
            }
            if (materia.Contains("Cálculo 1"))
            {
                Calculo1.IsChecked = true;
            }
            if (materia.Contains("Cálculo 2"))
            {
                Calculo2.IsChecked = true;
            }
            if (materia.Contains("Compiladores"))
            {
                Compiladores.IsChecked = true;
            }
            if (materia.Contains("Computadores e Sociedade"))
            {
                CompESociedade.IsChecked = true;
            }
            if (materia.Contains("Computação Gráfica"))
            {
                ComputacaoGrafica.IsChecked = true;
            }
            if (materia.Contains("Computação Simbólica e Númerica"))
            {
                ComputacaoSimb.IsChecked = true;
            }
            if (materia.Contains("Comunicação e Expressão"))
            {
                ComunicacaoExp.IsChecked = true;
            }
            if (materia.Contains("Empreendedorismo"))
            {
                Empreendedorismo.IsChecked = true;
            }
            if (materia.Contains("Engenharia de Software 1"))
            {
                Eng1.IsChecked = true;
            }
            if (materia.Contains("Engenharia de Software 2"))
            {
                Eng2.IsChecked = true;
            }
            if (materia.Contains("Engenharia de Software 3"))
            {
                Eng3.IsChecked = true;
            }
            if (materia.Contains("Estrutura de Dados"))
            {
                Estrutura.IsChecked = true;
            }
            if (materia.Contains("Física"))
            {
                Fisica.IsChecked = true;
            }
            if (materia.Contains("Informática e Educação"))
            {
                InformaticaEd.IsChecked = true;
            }
            if (materia.Contains("Inteligência Artifical"))
            {
                IA.IsChecked = true;
            }
            if (materia.Contains("Interface Homem Máquina"))
            {
                IHC.IsChecked = true;
            }
            if (materia.Contains("Linguagens de Programação"))
            {
                LinguagensProg.IsChecked = true;
            }
            if (materia.Contains("Matemática Discreta"))
            {
                MatDisc.IsChecked = true;
            }
            if (materia.Contains("Metodologia de Pesquisa"))
            {
                Metodologia.IsChecked = true;
            }
            if (materia.Contains("Prática e Gerenciamento de Projeto"))
            {
                GerenciamentoProjeto.IsChecked = true;
            }
            if (materia.Contains("Probabilidade e Estatística"))
            {
                ProbEst.IsChecked = true;
            }
            if (materia.Contains("Programação 1"))
            {
                Prog1.IsChecked = true;
            }
            if (materia.Contains("Programação 2"))
            {
                Prog2.IsChecked = true;
            }
            if (materia.Contains("Projeto e Análise de Algoritmo"))
            {
                ProjAnalise.IsChecked = true;
            }
            if (materia.Contains("Redes"))
            {
                Redes.IsChecked = true;
            }
            if (materia.Contains("Segurança e Auditoria de Segurança"))
            {
                Auditoria.IsChecked = true;
            }
            if (materia.Contains("Sistemas Digitais"))
            {
                SistemasDigitais.IsChecked = true;
            }
            if (materia.Contains("Sistemas Distribuídos"))
            {
                SistemasDistribuidos.IsChecked = true;
            }
            if (materia.Contains("Sistemas Operacionais"))
            {
                SO.IsChecked = true;
            }
            if (materia.Contains("Sociologia"))
            {
                Sociologia.IsChecked = true;
            }
            if (materia.Contains("Teoria da Computação"))
            {
                TeoriaComp.IsChecked = true;
            }
            if (materia.Contains("Teoria e Prática dos Sistemas de Informação"))
            {
                TeoriaEPrat.IsChecked = true;
            }
        }
    }
}