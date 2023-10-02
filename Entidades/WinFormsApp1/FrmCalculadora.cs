using Entidades;

namespace MiCalculadora
{
    public partial class FrmCalculadora : Form
    {
        private Numeracion primerOperando;
        private Numeracion segundoOperando;
        private Numeracion resultado;
        private ESistema sistema;
        char operador;

        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            this.cmbOperacion.Items.Add("");
            this.cmbOperacion.Items.Add('+');
            this.cmbOperacion.Items.Add('-');
            this.cmbOperacion.Items.Add('*');
            this.cmbOperacion.Items.Add('/');

            sistema = ESistema.Decimal;//Inicializo con el sistema Decimal por defecto
            rdbDecimal.Checked = true;//Inicializo con el roundbox en Decimal por defecto

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            setResultado();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPrimerOperador.Clear();
            txtSegundoOperador.Clear();
            //lblResultado.Text = "";
            primerOperando = null;
            segundoOperando = null;
            resultado = null;

        }


        private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            operador = (char)cmbOperacion.SelectedIndex;
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {
            
        }
        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            sistema = ESistema.Decimal;
            setResultado();
        }
        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            sistema = ESistema.Binario;
            setResultado();
        }

        private void txtPrimerOperador_TextChanged(object sender, EventArgs e)
        {
            if (txtPrimerOperador.Text is not null)
            {
                primerOperando = new Numeracion(sistema, txtPrimerOperador.Text);
            }
        }
        private void txtSegundoOperador_TextChanged(object sender, EventArgs e)
        {
            if (txtSegundoOperador.Text is not null)
            {
                segundoOperando = new Numeracion(sistema, txtSegundoOperador.Text);
            }
        }
        private void setResultado()
        {
            if (primerOperando != null && segundoOperando != null)
            {
                Operacion operacion = new Operacion(primerOperando, segundoOperando);

                Numeracion resultado = operacion.Operar(operador);
            }
            if (resultado != null)
            {
                lblResultado.Text = resultado.ToString();
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea cerrar la calculadora?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }

}