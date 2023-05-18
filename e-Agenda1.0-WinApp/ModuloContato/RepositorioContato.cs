using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda1._0_WinApp.ModuloContato
{
    public class RepositorioContato
    {
        List<Contato> contatos = new List<Contato>();
   
        private static int contador;

        public void Inserir(Contato contato)
        {
            contador++;
            contato.id = contador;
            contatos.Add(contato);
        }

        public List<Contato> SelecionarTodos() 
        {  
            return contatos; 
        }

        public void Editar(Contato contato)
        {
            Contato contatoSelecionado = SelecionarPorId(contato.id);

            contatoSelecionado.nome = contato.nome;
            contatoSelecionado.email = contato.email;
            contatoSelecionado.empresa = contato.empresa;
            contatoSelecionado.cargo = contato.cargo;
            contatoSelecionado.telefone = contato.telefone;
        }

        private Contato SelecionarPorId(int id)
        {
            return contatos.FirstOrDefault(x => x.id == id);
        }

        

        public void Excluir(Contato contato)
        {
            contatos.Remove(contato);
        }
    }
}
