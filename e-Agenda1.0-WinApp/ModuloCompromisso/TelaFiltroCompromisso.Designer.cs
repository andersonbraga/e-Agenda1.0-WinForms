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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtInicio = new DateTimePicker();
            txtFinal = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 221);
            label1.Name = "label1";
            label1.Size = new Size(206, 15);
            label1.TabIndex = 3;
            label1.Text = "Filtro paras os Compromissos Futuros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 283);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 4;
            label2.Text = "Data Inicial";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(299, 283);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 5;
            label3.Text = "Datat Final";
            // 
            // txtInicio
            // 
            txtInicio.Format = DateTimePickerFormat.Short;
            txtInicio.Location = new Point(136, 277);
            txtInicio.Name = "txtInicio";
            txtInicio.Size = new Size(101, 23);
            txtInicio.TabIndex = 6;
            // 
            // txtFinal
            // 
            txtFinal.Format = DateTimePickerFormat.Short;
            txtFinal.Location = new Point(386, 275);
            txtFinal.Name = "txtFinal";
            txtFinal.Size = new Size(101, 23);
            txtFinal.TabIndex = 7;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(320, 349);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Filtrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(424, 349);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // TelaFiltroCompromisso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 386);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtFinal);
            Controls.Add(txtInicio);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker txtInicio;
        private DateTimePicker txtFinal;
        private Button button1;
        private Button button2;
    }
}