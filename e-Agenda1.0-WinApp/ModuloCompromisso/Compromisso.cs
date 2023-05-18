using e_Agenda1._0_WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda1._0_WinApp.ModuloCompromisso
{
    public class Compromisso : EntidadeBase
    {
        public int id;
        public string assunto;
        public string local;
        public string dataCompromisso;
        public string horaInicio;
        public string horaTermino;


        public Compromisso(string assunto, string local, string dataCompromisso, string horaInicio, string horaTermino)
        {
       
            this.assunto = assunto;
            this.local = local;
            this.dataCompromisso = dataCompromisso;
            this.horaTermino = horaTermino;
            this.horaInicio = horaInicio;
        }

        public override string ToString()
        {
            return $"id: {id} assunto: {assunto} local {local} data do compromisso {dataCompromisso} hora inicio {horaInicio} hora termino " +
                $"{horaTermino}";
        }
    }
}
