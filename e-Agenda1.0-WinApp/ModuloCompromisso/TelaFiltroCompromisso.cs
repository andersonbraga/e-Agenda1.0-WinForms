using e_Agenda1._0_WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace e_Agenda1._0_WinApp.ModuloCompromisso
{
    public partial class TelaFiltroCompromisso : Form
    {
        public TelaFiltroCompromisso()
        {
            InitializeComponent();
        }
        public enum StatusCompromissoEnum
        {
            Todos, Passados, Futuros
        }

        public StatusCompromissoEnum StatusSelecionado
        {
            get
            {
                if (rdbCompromissosPassados.Checked)
                    return StatusCompromissoEnum.Passados;
                else if (rdbCompromissoFuturos.Checked)
                    return StatusCompromissoEnum.Futuros;
                else
                    return StatusCompromissoEnum.Todos;

            }
        }



        public DateTime DataInicial { get { return DataInicial; } }
        public DateTime DataFinal { get { return DataFinal; } }

        private void button1_Click(object sender, EventArgs e)
        {

           
           
            DateTime inicio = txtInicio.Value;
            DateTime termino = txtFinal.Value;
            

            

            Compromisso compromisso = new Compromisso(inicio, termino);
        }
    }


}
