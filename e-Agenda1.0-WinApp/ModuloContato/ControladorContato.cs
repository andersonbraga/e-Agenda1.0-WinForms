using e_Agenda1._0_WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda1._0_WinApp.ModuloContato
{
    public class ControladorContato : ControladorBase
    {
        private RepositorioContato repositorioContato;
        private ListagemContatoControl listagemContato;
        public ControladorContato(RepositorioContato repositorioContato) 
        {
            this.repositorioContato = repositorioContato;
        }
        public override string ToolTipInserir { get { return "Inserir novo Contato"; } }

        public override string ToolTipEditar { get { return "Editar  Contato existente"; } }

        public override string TooTipExcluir { get { return "Excluir  Contato existente"; } }

        

        public override void Inserir()
        {
            TelaContatoForm telaContato = new TelaContatoForm();

            DialogResult opcaoEscolhida = telaContato.ShowDialog();

            if(opcaoEscolhida == DialogResult.OK)
            {
                Contato contato = telaContato.Contato;
                repositorioContato.Inserir(contato);
                CarregarContatos();
            }
        }

        public override void Editar()
        {
            TelaContatoForm telaContato = new TelaContatoForm();
            telaContato.Contato = listagemContato.ObterContatoSelecionado();

            DialogResult opcaoEscolhida = telaContato.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Contato contato = telaContato.Contato;
                repositorioContato.Editar(contato);
                CarregarContatos();
            }
        }

        public override void Excluir()
        {
            
            Contato contato = listagemContato.ObterContatoSelecionado();

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja Excluir o contato {contato.nome} ?", "Exclusão de Contatos",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                
                repositorioContato.Excluir(contato);
                CarregarContatos();
            }
        }

        private void CarregarContatos()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();
            listagemContato.AtualizarRegistro(contatos);
        }

        public override UserControl ObterListagem()
        {
            if(listagemContato == null)
                listagemContato = new ListagemContatoControl();

            CarregarContatos();

            return listagemContato;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Contatos";
        }

       
    }
}
