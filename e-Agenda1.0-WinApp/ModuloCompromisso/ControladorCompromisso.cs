using e_Agenda1._0_WinApp.Compartilhado;
using e_Agenda1._0_WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static e_Agenda1._0_WinApp.ModuloCompromisso.TelaFiltroCompromisso;

namespace e_Agenda1._0_WinApp.ModuloCompromisso
{
    public class ControladorCompromisso : ControladorBase
    {
        public RepositorioCompromisso repositorioCompromisso;
        public RepositorioContato repositorioContato;
        public ListagemCompromissoControl listagemCompromisso;

        public ControladorCompromisso(RepositorioCompromisso repositorioCompromisso, RepositorioContato repositorioContato)
        {
            this.repositorioCompromisso = repositorioCompromisso;
            this.repositorioContato = repositorioContato;
        }
        public override string ToolTipInserir { get { return "Inserir novo Compromisso"; } }

        public override string ToolTipEditar { get { return "Editar  Compromisso existente"; } }
                                                                     
        public override string TooTipExcluir { get { return "Excluir Compromisso existente"; } }

        public override void Editar()
        {

            TelaCompromissoForm telaCompromisso = new TelaCompromissoForm();
            telaCompromisso.ObterContatos(repositorioContato.SelecionarTodos());
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
            telaCompromisso.ObterContatos(this.repositorioContato.SelecionarTodos());

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

        public override void Filtrar()
        {
            TelaFiltroCompromisso telaFiltro = new  TelaFiltroCompromisso();
                                  

            if (telaFiltro.ShowDialog() == DialogResult.OK)
            {
                StatusCompromissoEnum statusSelecionado = telaFiltro.StatusSelecionado;
                DateTime dataInicial = telaFiltro.DataInicial.Date;
                DateTime dataFinal = telaFiltro.DataFinal.Date;
                CarregarCompromissoComFiltro(statusSelecionado, dataInicial, dataFinal);
            }
        }

        private  void CarregarCompromissoComFiltro(StatusCompromissoEnum statusSelecionado, DateTime dataInicial, DateTime dataFinal)
        {
            string tipoCompromisso;
            List<Compromisso> compromissos;
            

            switch(statusSelecionado)
            {
                case StatusCompromissoEnum.Futuros:
                    compromissos = repositorioCompromisso.SelecionarCompromissosFuturos(dataInicial, dataFinal);
                    tipoCompromisso = "futuro";
                    break;

                case StatusCompromissoEnum.Passados:
                    compromissos = repositorioCompromisso.SelecionarCompromissosPassados(DateTime.Now);
                    break;

                default:
                    compromissos = repositorioCompromisso.SelecionarTodos();
                    tipoCompromisso = "";
                        break;
                    
            }
        }
    }
}
