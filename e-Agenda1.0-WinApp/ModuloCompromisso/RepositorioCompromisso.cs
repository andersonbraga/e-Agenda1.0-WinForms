namespace e_Agenda1._0_WinApp.ModuloCompromisso
{
    public class RepositorioCompromisso
    {
        List<Compromisso> compromissos = new List<Compromisso>();
        private static int contador;

        public void Inserir(Compromisso compromisso)
        {
            contador++;
            compromisso.id = contador;
            compromissos.Add(compromisso);
        }

        public List<Compromisso> SelecionarTodos()
        {
            return compromissos;
        }

        public void Editar(Compromisso compromisso)
        {
            Compromisso compromissoSelecionado = SelecionarPorId(compromisso.id);

            compromissoSelecionado.assunto = compromisso.assunto;
            compromissoSelecionado.local = compromisso.local;
            compromissoSelecionado.horaInicio = compromisso.horaInicio;
            compromissoSelecionado.horaTermino = compromisso.horaTermino;
            compromissoSelecionado.dataCompromisso = compromisso.dataCompromisso;
        }

        private Compromisso SelecionarPorId(int id)
        {
            return compromissos.FirstOrDefault(x => x.id == id);
        }

        public void Excluir(Compromisso compromisso)
        {
            compromissos.Remove(compromisso);
        }
    }
}