namespace e_Agenda1._0_WinApp.ModuloCompromisso
{
    partial class TelaCompromissoForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtData = new DateTimePicker();
            txtInicio = new TextBox();
            txtTermino = new TextBox();
            txtNumero = new TextBox();
            txtAssunto = new TextBox();
            checkBox1 = new CheckBox();
            comboBox1 = new ComboBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            txtLocal = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 20);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Número";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 60);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Assunto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 106);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 2;
            label3.Text = "Data";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 146);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Inicio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(316, 146);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 4;
            label5.Text = "Termino";
            // 
            // txtData
            // 
            txtData.Location = new Point(85, 98);
            txtData.Name = "txtData";
            txtData.Size = new Size(200, 23);
            txtData.TabIndex = 5;
            // 
            // txtInicio
            // 
            txtInicio.Location = new Point(85, 138);
            txtInicio.Name = "txtInicio";
            txtInicio.Size = new Size(100, 23);
            txtInicio.TabIndex = 6;
            // 
            // txtTermino
            // 
            txtTermino.Location = new Point(388, 143);
            txtTermino.Name = "txtTermino";
            txtTermino.Size = new Size(100, 23);
            txtTermino.TabIndex = 7;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(102, 12);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 8;
            // 
            // txtAssunto
            // 
            txtAssunto.Location = new Point(102, 52);
            txtAssunto.Name = "txtAssunto";
            txtAssunto.Size = new Size(386, 23);
            txtAssunto.TabIndex = 9;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(85, 196);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(281, 19);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Desejar marcar um contato neste compromisso?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(102, 221);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 11;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(575, 400);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 12;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(666, 400);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtLocal
            // 
            txtLocal.Location = new Point(85, 167);
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new Size(100, 23);
            txtLocal.TabIndex = 14;
            // 
            // TelaCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLocal);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(comboBox1);
            Controls.Add(checkBox1);
            Controls.Add(txtAssunto);
            Controls.Add(txtNumero);
            Controls.Add(txtTermino);
            Controls.Add(txtInicio);
            Controls.Add(txtData);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaCompromissoForm";
            Text = "Cadastro de Compromissos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker txtData;
        private TextBox txtInicio;
        private TextBox txtTermino;
        private TextBox txtNumero;
        private TextBox txtAssunto;
        private CheckBox checkBox1;
        private ComboBox comboBox1;
        private Button btnGravar;
        private Button btnCancelar;
        private TextBox txtLocal;
    }
}