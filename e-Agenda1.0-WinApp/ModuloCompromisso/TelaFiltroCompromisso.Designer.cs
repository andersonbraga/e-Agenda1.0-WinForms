namespace e_Agenda1._0_WinApp.ModuloCompromisso
{
    partial class TelaFiltroCompromisso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rdbCompromissoTodos = new RadioButton();
            rdbCompromissosPassados = new RadioButton();
            rdbCompromissoFuturos = new RadioButton();
            SuspendLayout();
            // 
            // rdbCompromissoTodos
            // 
            rdbCompromissoTodos.AutoSize = true;
            rdbCompromissoTodos.Location = new Point(32, 25);
            rdbCompromissoTodos.Name = "rdbCompromissoTodos";
            rdbCompromissoTodos.Size = new Size(205, 19);
            rdbCompromissoTodos.TabIndex = 0;
            rdbCompromissoTodos.TabStop = true;
            rdbCompromissoTodos.Text = "Visualizar todos os Compromissos";
            rdbCompromissoTodos.UseVisualStyleBackColor = true;
            // 
            // rdbCompromissosPassados
            // 
            rdbCompromissosPassados.AutoSize = true;
            rdbCompromissosPassados.Location = new Point(32, 71);
            rdbCompromissosPassados.Name = "rdbCompromissosPassados";
            rdbCompromissosPassados.Size = new Size(257, 19);
            rdbCompromissosPassados.TabIndex = 1;
            rdbCompromissosPassados.TabStop = true;
            rdbCompromissosPassados.Text = "Visualizar somente Compromissos Passados";
            rdbCompromissosPassados.UseVisualStyleBackColor = true;
            // 
            // rdbCompromissoFuturos
            // 
            rdbCompromissoFuturos.AutoSize = true;
            rdbCompromissoFuturos.Location = new Point(32, 118);
            rdbCompromissoFuturos.Name = "rdbCompromissoFuturos";
            rdbCompromissoFuturos.Size = new Size(249, 19);
            rdbCompromissoFuturos.TabIndex = 2;
            rdbCompromissoFuturos.TabStop = true;
            rdbCompromissoFuturos.Text = "Visualizar somente Compromissos Futuros";
            rdbCompromissoFuturos.UseVisualStyleBackColor = true;
            // 
            // TelaFiltroCompromisso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 386);
            Controls.Add(rdbCompromissoFuturos);
            Controls.Add(rdbCompromissosPassados);
            Controls.Add(rdbCompromissoTodos);
            Name = "TelaFiltroCompromisso";
            Text = "TelaFiltroCompromisso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdbCompromissoTodos;
        private RadioButton rdbCompromissosPassados;
        private RadioButton rdbCompromissoFuturos;
    }
}