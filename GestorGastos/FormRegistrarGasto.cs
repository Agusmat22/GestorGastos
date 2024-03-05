using Entidades.finance;
using Entidades.sql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorGastos
{
    public partial class FormRegistrarGasto : Form
    {

        private GestorGasto gestor;
        private Gasto gasto;
        private TipoGasto tipo;

        public Gasto GastoNuevo { get => gasto; set => gasto = value; }

        public FormRegistrarGasto(GestorGasto gestor, string titulo)
        {
            InitializeComponent();
            this.gestor = gestor;
            this.lblTitulo.Text = titulo;
        }

        public FormRegistrarGasto(GestorGasto gestor, string titulo, Gasto gasto): this(gestor,titulo)
        {
            this.gasto = gasto;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {


            if (double.TryParse(this.txtValor.Text, out double valor))
            {

                //this.gasto = new Gasto(this.tipo.Id, valor, DateTime.Now, gestor.User.Id, tipo);              

                this.gasto.IdTipoGasto = this.tipo.Id;
                this.gasto.Valor = valor;
                this.gasto.Fecha = DateTime.Now;
                this.gasto.IdUser = gestor.User.Id;
                this.gasto.Tipo = this.tipo;

                this.gestor.AgregarGasto(this.gasto);

                this.DialogResult = DialogResult.OK;
            }


        }

        private void FormRegistrarGasto_Load(object sender, EventArgs e)
        {

            if (this.gasto is null)
            {
                this.gasto = new Gasto();
            }
            this.cmbTipoGasto.DataSource = this.gestor.TipoGasto;
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //valido que sea un numero o un control especial
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Suprime el evento de la tecla si no es un número o un control
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void cmbTipoGasto_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tipo = (TipoGasto)this.cmbTipoGasto.SelectedItem;

            this.gasto.IdTipoGasto = ((TipoGasto)this.cmbTipoGasto.SelectedItem).Id;
        }
    }
}
