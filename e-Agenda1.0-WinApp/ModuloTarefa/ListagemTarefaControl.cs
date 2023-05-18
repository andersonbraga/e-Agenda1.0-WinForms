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
        List<Tarefa> tarefas = new List<Tarefa>();
        public ListagemTarefaControl()
        {
            InitializeComponent();

            tarefas.Add(new Tarefa(1, "Academia", "alta"));
            tarefas.Add(new Tarefa(2, "Leitura", "alta"));

            foreach (Tarefa item in tarefas)
            {
                listTarefa.Items.Add(item); 
            }
        }

       
    }
    


}
