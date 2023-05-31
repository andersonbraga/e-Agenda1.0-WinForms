using e_Agenda1._0_WinApp.Compartilhado;
using e_Agenda1._0_WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda1._0_WinApp.ModuloTarefa
{
    public class ControladorTarefa : ControladorBase
    {
        private RepositorioTarefa repositorioTarefa;
        private ListagemTarefaControl listagemTarefa;
        public override string ToolTipInserir { get { return "Inserir nova Tarefa"; } }

        public override string ToolTipEditar { get { return "Editar  Tarefa existente"; } }

        public override string TooTipExcluir { get { return "Excluir  Tarefa existente"; } }

        public override void Editar()
        {
            TelaTarefaForm telaTarefa = new TelaTarefaForm();
            telaTarefa.Tarefa = listagemTarefa.ObterTarefaSelecionado();

            DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tarefa tarefa = telaTarefa.Tarefa;
                repositorioTarefa.Editar(tarefa);
                CarregarTarefas();
            }
        }

        public override void Excluir()
        {
            Tarefa tarefa = listagemTarefa.ObterTarefaSelecionado();

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja Excluir a tarefa {tarefa.titulo} ?", "Exclusão de Tarefas",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {

                repositorioTarefa.Excluir(tarefa);
                CarregarTarefas();
            }
        }

        public override void Inserir()
        {
            TelaTarefaForm telaTarefa = new TelaTarefaForm();

            DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tarefa tarefa = telaTarefa.Tarefa;
                repositorioTarefa.Inserir(tarefa);
                CarregarTarefas();
            }
        }

        public override UserControl ObterListagem()
        {
            if (listagemTarefa == null)
                listagemTarefa = new ListagemTarefaControl();

            CarregarTarefas();

            return listagemTarefa;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Tarefas";
        }

        public override void Filtrar()
        {
            throw new NotImplementedException();
        }
        private void CarregarTarefas()
        {
            List<Tarefa> tarefas = repositorioTarefa.SelecionarTodos();
            listagemTarefa.AtualizarRegistro(tarefas);
        }
    }
}
