using e_Agenda1._0_WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda1._0_WinApp.ModuloCompromisso
{
    public partial class TelaCompromissoForm : Form
    {
        private Compromisso compromisso;
        public TelaCompromissoForm()
        {
            InitializeComponent();
        }

        public Compromisso Compromisso
        {
            get { return compromisso; }
            set
            {
                txtNumero.Text = value.id.ToString();
                txtAssunto.Text = value.assunto;
                txtData.Text = value.dataCompromisso;
                txtInicio.Text = value.horaInicio;
                txtTermino.Text = value.horaTermino;
                txtLocal.Text = value.local;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            string assunto = txtAssunto.Text;
            string data = txtData.Text;
            string inicio = txtInicio.Text;
            string termino = txtTermino.Text;
            string local = txtLocal.Text;
            compromisso = new Compromisso(assunto, data, inicio, termino, local);

        }
    }
}
