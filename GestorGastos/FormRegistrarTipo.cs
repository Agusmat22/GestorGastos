using Entidades.finance;
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
    public partial class FormRegistrarTipo : Form
    {
        private GestorGasto gestor;
        private EGasto tipoGasto;
        private TipoGasto tipo;
        public FormRegistrarTipo(GestorGasto gestor, string titulo)
        {
            InitializeComponent();
            this.gestor = gestor;
            this.lblTitulo.Text = titulo;
        }

        public FormRegistrarTipo(GestorGasto gestor, string titulo, TipoGasto tipoGasto): this(gestor,titulo)
        {
                this.tipo = tipoGasto;
        }

        private void FormRegistrarTipo_Load(object sender, EventArgs e)
        {
            if (tipo is null)
            {
                this.tipo = new TipoGasto();
            }


            this.cmbTipo.DataSource = Enum.GetValues(typeof(EGasto));
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.Text != "")
            {
                this.tipo.Nombre = this.txtNombre.Text;

                if (this.lblTitulo.Text == "Registrar")
                {
                    this.gestor.AgregarTipo(tipo);
                    
                }
                else if(this.lblTitulo.Text == "Modificar")
                {
                    this.gestor.ActualizarTipo(tipo);
                }

                this.DialogResult = DialogResult.OK;
            }
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tipoGasto = (EGasto)this.cmbTipo.SelectedItem;
            this.tipo.Tipo = this.tipoGasto;
        }
    }
}
