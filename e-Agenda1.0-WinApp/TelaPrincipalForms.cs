using e_Agenda1._0_WinApp.Compartilhado;
using e_Agenda1._0_WinApp.ModuloCompromisso;
using e_Agenda1._0_WinApp.ModuloContato;
using e_Agenda1._0_WinApp.ModuloTarefa;

namespace e_Agenda1._0_WinApp
{
    public partial class TelaPrincipalForms1 : Form
    {
        private ControladorBase controlador;
        private RepositorioContato repositorioContato = new RepositorioContato();
        private RepositorioCompromisso repositorioCompromisso = new RepositorioCompromisso();
        public TelaPrincipalForms1()
        {
            InitializeComponent();
        }

        private void contatosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorContato(repositorioContato);
            ConfigurarTelaPrincipal(controlador);

        }

        private void compromissosMenuItem_Click(object sender, EventArgs e)
        {

            controlador = new ControladorCompromisso(repositorioCompromisso, repositorioContato);
            ConfigurarTelaPrincipal(controlador);

        }

        private void tarefasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTarefa();
            ConfigurarTelaPrincipal(controlador);

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }

        private void ConfigurarToolTips(ControladorBase controladorBase)
        {
            btnInserir.ToolTipText = controladorBase.ToolTipInserir;
            btnEditar.ToolTipText = controladorBase.ToolTipEditar;
            btnExcluir.ToolTipText = controladorBase.TooTipExcluir;
        }

        private void ConfigurarListagem(ControladorBase controladorBase)
        {
            UserControl listagem = controladorBase.ObterListagem();
            listagem.Dock = DockStyle.Fill;
            panelRegistros.Controls.Clear();
            panelRegistros.Controls.Add(listagem);
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
        {
            labelTipoCadastro.Text = controladorBase.ObterTipoCadastro();
            ConfigurarToolTips(controlador);
            ConfigurarListagem(controlador);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            controlador.Filtrar();
        }
    }
}