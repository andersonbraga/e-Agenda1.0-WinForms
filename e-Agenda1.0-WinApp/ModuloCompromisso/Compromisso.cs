using e_Agenda1._0_WinApp.Compartilhado;
using e_Agenda1._0_WinApp.ModuloContato;
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
        public DateTime dataCompromisso;
        public DateTime horaInicio;
        public DateTime horaTermino;
        public Contato Contato;


        public Compromisso(string assunto, string local, DateTime dataCompromisso, DateTime horaInicio, DateTime horaTermino, Contato Contato)
        {
       
            this.assunto = assunto;
            this.local = local;
            this.dataCompromisso = dataCompromisso;
            this.horaTermino = horaTermino;
            this.horaInicio = horaInicio;
            this.Contato = Contato;
        }

        public override string ToString()
        {
            return $"id: {id} assunto: {assunto} local {local} data do compromisso {dataCompromisso} hora inicio {horaInicio.ToString("HH:mm")} hora termino " +
                $"{horaTermino.ToString("HH:mm")} contato {Contato}";
        }
    }
}
