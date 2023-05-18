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
        public List<Contato> contatos;

        public TelaCompromissoForm()
        {
            InitializeComponent();


        }

        public Compromisso Compromisso
        {
            get { return compromisso; }
            set
            {
                txtId.Text = value.id.ToString();
                txtAssunto.Text = value.assunto;
                txtData.Value = value.dataCompromisso;
                txtInicio.Value = value.horaInicio.Date;
                txtTermino.Value = value.horaTermino.Date;
                txtLocal.Text = value.local;
                if (value.Contato != null)
                {
                    cbContato.SelectedItem = value.Contato.nome;
                }
            }
        }




        public void ObterContatos(List<Contato> contatos)
        {
            cbContato.Items.Clear();
            foreach (Contato item in contatos)
            {
                cbContato.Items.Add(item);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            string assunto = txtAssunto.Text;
            DateTime data = txtData.Value;
            DateTime inicio = txtInicio.Value;
            DateTime termino = txtTermino.Value;
            string local = txtLocal.Text;

            Contato contato = contatos.Find(c => c.nome == cbContato.SelectedItem);

            compromisso = new Compromisso(assunto, local, data, inicio.Date, termino.Date, contato);

            if (txtId.Text != "0")
                compromisso.id = Convert.ToInt32(txtId.Text);

        }
    }
}
