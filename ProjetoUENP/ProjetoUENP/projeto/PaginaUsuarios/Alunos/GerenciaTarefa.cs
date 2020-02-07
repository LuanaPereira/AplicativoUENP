using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ProjetoUENP.projeto.PaginaUsuarios.Alunos
{
    public class GerenciaTarefa
    {
        private List<Tarefa> Lista { get; set; }
        public void Salvar(Tarefa tarefa)
        {
            Lista = Listagem();
            Lista.Add(tarefa);
            SalvarNoProperties(Lista);
        }
        public void Remover( int index)
        {
            Lista = Listagem();

            Lista.RemoveAt(index);
            SalvarNoProperties(Lista);
           
        }
        public void Finalizar(int index, Tarefa tarefa)
        {
            Lista = Listagem();

            Lista.RemoveAt(index);

            tarefa.DataFinalizacao = DateTime.Now;
            Lista.Add(tarefa);
            SalvarNoProperties(Lista);
        }
        
        public void naoPronta(int index, Tarefa tarefa)
        {
            Lista = Listagem();

            Lista.RemoveAt(index);

            tarefa.DataFinalizacao = null;
            Lista.Add(tarefa);
            SalvarNoProperties(Lista);
        }

        public List<Tarefa> Listagem()
        {
            return ListagemNoProperties();
            
        }
        public void SalvarNoProperties(List<Tarefa> Lista) 
        {
            if (App.Current.Properties.ContainsKey("Tarefas"))
            {
                App.Current.Properties.Remove("Tarefas");
            }

            string JsonVal = JsonConvert.SerializeObject(Lista);

            App.Current.Properties.Add("Tarefas", JsonVal);
        }
        public List<Tarefa> ListagemNoProperties()
        {
            if (App.Current.Properties.ContainsKey("Tarefas"))
            {
                String JsonVal = (String)App.Current.Properties["Tarefas"];

                List<Tarefa> Lista = JsonConvert.DeserializeObject<List<Tarefa>>(JsonVal);
                return Lista;
                //return (List<Tarefa>)App.Current.Properties["Tarefas"];
                 
            } 
            return new List<Tarefa>();
        }
    }
}
