﻿using e_Agenda1._0_WinApp.ModuloContato;
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
    public partial class ListagemCompromissoControl : UserControl
    {
       
        public ListagemCompromissoControl()
        {
            InitializeComponent();


           
        }


        public void AtualizarRegistro(List<Compromisso> compromissos)
        {
            listCompromisso.Items.Clear();
            foreach (Compromisso item in compromissos)
            {
                listCompromisso.Items.Add(item);
            }
        }

        public Compromisso ObterCompromissoSelecionado()
        {
            return (Compromisso)listCompromisso.SelectedItem;
        }






        private void listCompromisso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
