namespace MiCalculadora
{
    partial class FrmCalculadora        /// <summary>
                                        ///  Required designer variable.

    {
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOperar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            txtPrimerOperador = new TextBox();
            txtSegundoOperador = new TextBox();
            cmbOperacion = new ComboBox();
            rdbDecimal = new RadioButton();
            rdbBinario = new RadioButton();
            grpSistema = new GroupBox();
            lblResultado = new Label();
            lblPrimerOperador = new Label();
            lblOperacion = new Label();
            lblSegundoOperador = new Label();
            grpSistema.SuspendLayout();
            SuspendLayout();
            // 
            // btnOperar
            // 
            btnOperar.Location = new Point(24, 270);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(187, 49);
            btnOperar.TabIndex = 0;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            btnOperar.Click += btnOperar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(231, 270);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(187, 49);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(437, 270);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(187, 49);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // txtPrimerOperador
            // 
            txtPrimerOperador.Location = new Point(24, 225);
            txtPrimerOperador.Name = "txtPrimerOperador";
            txtPrimerOperador.PlaceholderText = "Primer Operador";
            txtPrimerOperador.Size = new Size(187, 23);
            txtPrimerOperador.TabIndex = 3;
            txtPrimerOperador.TextChanged += txtPrimerOperador_TextChanged;
            // 
            // txtSegundoOperador
            // 
            txtSegundoOperador.Location = new Point(437, 225);
            txtSegundoOperador.Name = "txtSegundoOperador";
            txtSegundoOperador.PlaceholderText = "Segundo Operador";
            txtSegundoOperador.Size = new Size(184, 23);
            txtSegundoOperador.TabIndex = 4;
            txtSegundoOperador.TextChanged += txtSegundoOperador_TextChanged;
            // 
            // cmbOperacion
            // 
            cmbOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Location = new Point(269, 225);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(109, 23);
            cmbOperacion.TabIndex = 5;
            cmbOperacion.SelectedIndexChanged += cmbOperacion_SelectedIndexChanged;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Location = new Point(18, 22);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(68, 19);
            rdbDecimal.TabIndex = 6;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            rdbDecimal.CheckedChanged += rdbDecimal_CheckedChanged;
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Location = new Point(135, 22);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(62, 19);
            rdbBinario.TabIndex = 7;
            rdbBinario.TabStop = true;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            rdbBinario.CheckedChanged += rdbBinario_CheckedChanged;
            // 
            // grpSistema
            // 
            grpSistema.Controls.Add(rdbBinario);
            grpSistema.Controls.Add(rdbDecimal);
            grpSistema.Location = new Point(217, 106);
            grpSistema.Name = "grpSistema";
            grpSistema.Size = new Size(224, 60);
            grpSistema.TabIndex = 8;
            grpSistema.TabStop = false;
            grpSistema.Text = "Representar resultado en:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(24, 33);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(62, 15);
            lblResultado.TabIndex = 9;
            lblResultado.Text = "Resultado:";
            lblResultado.Click += lblResultado_Click;
            // 
            // lblPrimerOperador
            // 
            lblPrimerOperador.AutoSize = true;
            lblPrimerOperador.Location = new Point(24, 194);
            lblPrimerOperador.Name = "lblPrimerOperador";
            lblPrimerOperador.Size = new Size(98, 15);
            lblPrimerOperador.TabIndex = 10;
            lblPrimerOperador.Text = "Primer Operador:";
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Location = new Point(269, 194);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(65, 15);
            lblOperacion.TabIndex = 11;
            lblOperacion.Text = "Operacion:";
            // 
            // lblSegundoOperador
            // 
            lblSegundoOperador.AutoSize = true;
            lblSegundoOperador.Location = new Point(437, 194);
            lblSegundoOperador.Name = "lblSegundoOperador";
            lblSegundoOperador.Size = new Size(110, 15);
            lblSegundoOperador.TabIndex = 12;
            lblSegundoOperador.Text = "Segundo Operador:";
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(644, 330);
            Controls.Add(lblSegundoOperador);
            Controls.Add(lblOperacion);
            Controls.Add(lblPrimerOperador);
            Controls.Add(lblResultado);
            Controls.Add(grpSistema);
            Controls.Add(cmbOperacion);
            Controls.Add(txtSegundoOperador);
            Controls.Add(txtPrimerOperador);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOperar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora de Hugo Gimenez";
            FormClosing += FrmCalculadora_FormClosing;
            Load += FrmCalculadora_Load;
            grpSistema.ResumeLayout(false);
            grpSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOperar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private TextBox txtPrimerOperador;
        private TextBox txtSegundoOperador;
        private ComboBox cmbOperacion;
        private RadioButton rdbDecimal;
        private RadioButton rdbBinario;
        private GroupBox grpSistema;
        private Label lblResultado;
        private Label lblPrimerOperador;
        private Label lblOperacion;
        private Label lblSegundoOperador;
    }
}