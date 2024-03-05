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
    public partial class FormVerTodo : Form
    {
        private GestorGasto gestor;
        private TipoGasto tipoGasto;

        public FormVerTodo(GestorGasto gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
            this.tipoGasto = new TipoGasto();
        }

        private void FormVerTodo_Load(object sender, EventArgs e)
        {
            this.lstbTipoGastos.DataSource = this.gestor.TipoGasto;
        }

        private void lstbTipoGastos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tipoGasto = (TipoGasto)this.lstbTipoGastos.SelectedItem;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //ACA MODIFICO EL TIPO DE GASTO
        }
    }
}
