using e_Agenda1._0_WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda1._0_WinApp.ModuloContato
{
    public class Contato : EntidadeBase
    {
       
            public int id;
            public string nome;
            public string telefone;
            public string email;
            public string cargo;
            public string empresa;

            public Contato( string nome, string telefone, string email, string cargo, string empresa)
            {
              
                this.nome = nome;
                this.telefone = telefone;
                this.email = email;  
                this.cargo = cargo;
                this.empresa = empresa;

            }

            public override string ToString()
            {
                return $"id: {id} nome: {nome} empresa {empresa}";
            }
        
    }
}
