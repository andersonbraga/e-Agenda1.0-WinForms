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
            txtId = new TextBox();
            txtAssunto = new TextBox();
            chbCompromisso = new CheckBox();
            cbContato = new ComboBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            txtLocal = new TextBox();
            txtInicio = new DateTimePicker();
            txtTermino = new DateTimePicker();
            label7 = new Label();
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
            label4.Location = new Point(85, 144);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Inicio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(231, 144);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 4;
            label5.Text = "Termino";
            // 
            // txtData
            // 
            txtData.Location = new Point(85, 98);
            txtData.Name = "txtData";
            txtData.Size = new Size(291, 23);
            txtData.TabIndex = 5;
            // 
            // txtId
            // 
            txtId.Location = new Point(85, 12);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(58, 23);
            txtId.TabIndex = 8;
            // 
            // txtAssunto
            // 
            txtAssunto.Location = new Point(85, 52);
            txtAssunto.Name = "txtAssunto";
            txtAssunto.Size = new Size(386, 23);
            txtAssunto.TabIndex = 9;
            // 
            // chbCompromisso
            // 
            chbCompromisso.AutoSize = true;
            chbCompromisso.Location = new Point(85, 196);
            chbCompromisso.Name = "chbCompromisso";
            chbCompromisso.Size = new Size(281, 19);
            chbCompromisso.TabIndex = 10;
            chbCompromisso.Text = "Desejar marcar um contato neste compromisso?";
            chbCompromisso.UseVisualStyleBackColor = true;
            // 
            // cbContato
            // 
            cbContato.FormattingEnabled = true;
            cbContato.Location = new Point(85, 221);
            cbContato.Name = "cbContato";
            cbContato.Size = new Size(291, 23);
            cbContato.TabIndex = 11;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(315, 348);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 12;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(406, 348);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtLocal
            // 
            txtLocal.Location = new Point(371, 17);
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new Size(100, 23);
            txtLocal.TabIndex = 14;
            // 
            // txtInicio
            // 
            txtInicio.CustomFormat = "";
            txtInicio.Format = DateTimePickerFormat.Time;
            txtInicio.Location = new Point(139, 140);
            txtInicio.Name = "txtInicio";
            txtInicio.Size = new Size(76, 23);
            txtInicio.TabIndex = 15;
            txtInicio.Value = new DateTime(2023, 5, 18, 0, 0, 0, 0);
            // 
            // txtTermino
            // 
            txtTermino.Format = DateTimePickerFormat.Time;
            txtTermino.Location = new Point(287, 138);
            txtTermino.Name = "txtTermino";
            txtTermino.Size = new Size(89, 23);
            txtTermino.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(330, 20);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 18;
            label7.Text = "Local";
            // 
            // TelaCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 393);
            Controls.Add(label7);
            Controls.Add(txtTermino);
            Controls.Add(txtInicio);
            Controls.Add(txtLocal);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(cbContato);
            Controls.Add(chbCompromisso);
            Controls.Add(txtAssunto);
            Controls.Add(txtId);
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
        private TextBox txtId;
        private TextBox txtAssunto;
        private CheckBox chbCompromisso;
        private ComboBox cbContato;
        private Button btnGravar;
        private Button btnCancelar;
        private TextBox txtLocal;
        private DateTimePicker txtInicio;
        private DateTimePicker txtTermino;
        private Label label7;
    }
}