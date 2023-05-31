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
using static e_Agenda1._0_WinApp.ModuloTarefa.ListagemTarefaControl;

namespace e_Agenda1._0_WinApp.ModuloTarefa
{
    
    public partial class ListagemTarefaControl : UserControl
    {
     
        public ListagemTarefaControl()
        {
            InitializeComponent();

        }

        public void AtualizarRegistro(List<Tarefa> tarefas)
        {
            listTarefa.Items.Clear();
            foreach (Tarefa item in tarefas)
            {
                listTarefa.Items.Add(item);
            }
        }

        public Tarefa ObterTarefaSelecionado()
        {
            return (Tarefa)listTarefa.SelectedItem;
        }


    }
    


}
