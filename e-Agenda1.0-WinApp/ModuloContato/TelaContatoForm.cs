using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda1._0_WinApp.ModuloContato
{
    public partial class TelaContatoForm : Form
    {
        private Contato contato;
        public TelaContatoForm()
        {
            InitializeComponent();
           
        }

        public Contato Contato
        {
            get
            {
                return contato;
            }
            set
            {
                txtId.Text = value.id.ToString();
                txtNome.Text = value.nome;
                txtTelefone.Text = value.telefone;
                txtCargo.Text = value.cargo;
                txtEmpresa.Text = value.empresa;
                txtEmail.Text = value.email;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            string nome = txtNome.Text;
            string telefone = txtTelefone.Text;
            string cargo = txtCargo.Text;
            string empresa = txtEmpresa.Text;
            string email = txtEmail.Text;
            contato = new Contato(nome, telefone, cargo, empresa, email);

            if (txtId.Text != "0")
            {
                contato.id = Convert.ToInt32(txtId.Text);
            }
        }
    }
}
