﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda1._0_WinApp.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract string ToolTipInserir { get; }

        public abstract string ToolTipEditar { get; }

        public abstract string TooTipExcluir { get; }

        public abstract void Inserir();

        public abstract UserControl ObterListagem();
        public abstract string ObterTipoCadastro();
        public abstract void Editar();
        public abstract void Excluir();
        public abstract void Filtrar();
    }
}
