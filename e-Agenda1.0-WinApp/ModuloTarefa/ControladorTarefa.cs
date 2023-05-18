using e_Agenda1._0_WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda1._0_WinApp.ModuloTarefa
{
    public class ControladorTarefa : ControladorBase
    {
        public override string ToolTipInserir { get { return "Inserir nova Tarefa"; } }

        public override string ToolTipEditar { get { return "Editar  Tarefa existente"; } }

        public override string TooTipExcluir { get { return "Excluir  Tarefa existente"; } }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override void Inserir()
        {
            TelaTarefaForm telaTarefa = new TelaTarefaForm();
            telaTarefa.ShowDialog();
        }

        public override UserControl ObterListagem()
        {
            return new ListagemTarefaControl();
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Tarefas";
        }

        internal override void Filtrar()
        {
            throw new NotImplementedException();
        }
    }
}
