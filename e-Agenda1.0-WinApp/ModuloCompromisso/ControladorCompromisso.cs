using e_Agenda1._0_WinApp.Compartilhado;
using e_Agenda1._0_WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda1._0_WinApp.ModuloCompromisso
{
    public class ControladorCompromisso : ControladorBase
    {
        RepositorioCompromisso repositorioCompromisso;
        ListagemCompromissoControl listagemCompromisso;

        public ControladorCompromisso(RepositorioCompromisso repositorioCompromisso)
        {
            this.repositorioCompromisso = repositorioCompromisso;
        }
        public override string ToolTipInserir { get { return "Inserir novo Compromisso"; } }

        public override string ToolTipEditar { get { return "Editar  Compromisso existente"; } }
                                                                     
        public override string TooTipExcluir { get { return "Excluir Compromisso existente"; } }

        public override void Editar()
        {

            TelaCompromissoForm telaCompromisso = new TelaCompromissoForm();
            telaCompromisso.Compromisso = listagemCompromisso.ObterCompromissoSelecionado();


            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Compromisso compromisso = telaCompromisso.Compromisso;
                repositorioCompromisso.Editar(compromisso);
                CarregarCompromissos();
            }
        }

        private void CarregarCompromissos()
        {
            List<Compromisso> compromissos = repositorioCompromisso.SelecionarTodos();
            listagemCompromisso.AtualizarRegistro(compromissos);
        }

        public override void Excluir()
        {
            Compromisso compromisso = listagemCompromisso.ObterCompromissoSelecionado();

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja Excluir o compromisso {compromisso.assunto} ?", "Exclusão de Compromisso",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {

                repositorioCompromisso.Excluir(compromisso);
                CarregarCompromissos();
            }
        }

        public override void Inserir()
        {
            TelaCompromissoForm telaCompromisso = new TelaCompromissoForm();
            
                   
            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Compromisso compromisso = telaCompromisso.Compromisso;
                repositorioCompromisso.Inserir(compromisso);
                CarregarCompromissos();
            }
        }

        public override UserControl ObterListagem()
        {
            if (listagemCompromisso == null)
                listagemCompromisso = new ListagemCompromissoControl();

            CarregarCompromissos();

            return listagemCompromisso;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Compromissos";
        }
    }
}
