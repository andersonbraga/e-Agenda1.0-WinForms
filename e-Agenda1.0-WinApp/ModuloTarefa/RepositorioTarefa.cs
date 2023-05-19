using e_Agenda1._0_WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda1._0_WinApp.ModuloTarefa
{
    public class RepositorioTarefa
    {
        List<Tarefa> tarefas = new List<Tarefa>();

        private static int contador;

        public void Inserir(Tarefa tarefa)
        {
            contador++;
            tarefa.id = contador;
            tarefas.Add(tarefa);
        }

        public List<Tarefa> SelecionarTodos()
        {
            return tarefas;
        }
        private Tarefa SelecionarPorId(int id)
        {
            return tarefas.FirstOrDefault(x => x.id == id);
        }

        public void Editar(Tarefa tarefa)
        {
            Tarefa tarefaSelecionado = SelecionarPorId(tarefa.id);

            tarefaSelecionado.titulo = tarefa.titulo;
            tarefaSelecionado.prioridade = tarefa.prioridade;
        }

        public void Excluir(Tarefa tarefa)
        {
            tarefas.Remove(tarefa);
        }
    }
}
