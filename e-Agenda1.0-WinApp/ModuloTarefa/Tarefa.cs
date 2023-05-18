using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda1._0_WinApp.ModuloTarefa
{
    public class Tarefa
    {
        public int id;
        public string titulo;
        public string prioridade;

        public Tarefa(int id, string titulo, string prioridade)
        {
            this.id = id;
            this.titulo = titulo;
            this.prioridade = prioridade;

        }

        public override string ToString()
        {
            return $"id {id} titulo {titulo} prioridade {prioridade}";
        }
    }
}
