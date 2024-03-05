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
    public partial class FormBalance : Form
    {

        Menu formMenu;
        GestorGasto gestor;

        public FormBalance(Menu formMenu, GestorGasto gestor)
        {
            InitializeComponent();
            this.formMenu = formMenu;
            this.gestor = gestor;
        }

        private void FormBalance_Load(object sender, EventArgs e)
        {
            this.txtR50.Text = gestor.User.R50.ToString();
            this.txtR30.Text = gestor.User.R30.ToString();
            this.txtR20.Text = gestor.User.R20.ToString();

            //this.ActualizarDgv();

            this.txtSueldo.Text = "$ " + gestor.User.Sueldo.ToString("F2");
            this.txtGastoTotal.Text = "$ " + GestorGasto.CalcularGastoTotal(this.gestor.Gastos).ToString("F2");

            //cargo todos los tipos de gasto


            for (int i = 0; i < this.gestor.TipoGasto.Count; i++)
            {
                if (i == 0)
                {
                    this.cmbOrden.Items.Add("Todos");
                }

                this.cmbOrden.Items.Add(this.gestor.TipoGasto[i].Nombre);

            }

            this.cmbOrden.SelectedIndex = 0;
        }

        private void ActualizarDgv(string condicion)
        {
            this.dgvGastos.Rows.Clear(); // Limpiar filas existentes
            foreach (Gasto gasto in this.gestor.Gastos)
            {

                if (condicion == "Todos" || gasto.Tipo.Nombre == condicion)
                {
                    // Añadir una nueva fila y llenarla con datos
                    int rowIndex = this.dgvGastos.Rows.Add(); // Añade una nueva fila y obtén el índice
                    DataGridViewRow newRow = this.dgvGastos.Rows[rowIndex];

                    newRow.Cells["Tipo"].Value = gasto.Tipo.Tipo;
                    newRow.Cells["Nombre"].Value = gasto.Tipo.Nombre;
                    newRow.Cells["Valor"].Value = "$ " + gasto.Valor.ToString("F2");
                    newRow.Cells["Fecha"].Value = gasto.Fecha.ToString("dd/MM/yyyy"); // Formato de fecha según preferencia
                }

            }
        }

        private void FormBalance_FormClosing(object sender, FormClosingEventArgs e)
        {

            this.formMenu.Show();
        }

        private void cmbOrden_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarDgv(this.cmbOrden.SelectedItem.ToString());
        }
    }
}
