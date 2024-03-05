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

            this.ReglaGastos();

            this.txtSueldo.Text = "$ " + gestor.User.Sueldo.ToString("F2");

            double gastoTotal = GestorGasto.CalcularGastoTotal(this.gestor.Gastos);

            this.txtGastoTotal.Text = "$ " + gastoTotal.ToString("F2");

            this.txtRestante.Text = "$ " + (gestor.User.Sueldo - gastoTotal).ToString("F2");

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

        /// <summary>
        /// Calcular el gasto discriminado para cada regla y lo muestra en verde si no supera el limite
        /// de lo contrario marca en rojo
        /// </summary>
        private void ReglaGastos()
        {


            foreach (Gasto item in this.gestor.Gastos)
            {

                double montoTotal;
                string cadenaSub;


                if (item.Tipo.Tipo == EGasto.Necesidad || item.Tipo.Tipo == EGasto.Servicios)
                {

                    montoTotal = (double.Parse(this.txtR50.Text) + item.Valor);

                    this.txtR50.Text = montoTotal.ToString("F2");

                    if (this.gestor.ReglaGasto(montoTotal, this.gestor.User.R50))
                    {
                        this.txtR50.BackColor = Color.GreenYellow;
                    }
                    else
                    {
                        this.txtR50.BackColor = Color.Crimson;

                    }

                }
                else if (item.Tipo.Tipo == EGasto.Ocio || item.Tipo.Tipo == EGasto.Imprevisto)
                {
                    montoTotal = (double.Parse(this.txtR30.Text) + item.Valor);

                    this.txtR30.Text = montoTotal.ToString("F2");

                    if (this.gestor.ReglaGasto(montoTotal, this.gestor.User.R30))
                    {
                        this.txtR30.BackColor = Color.GreenYellow;
                    }
                    else
                    {
                        this.txtR30.BackColor = Color.Crimson;

                    }

                }
                else
                {
                    montoTotal = (double.Parse(this.txtR20.Text) + item.Valor);

                    this.txtR20.Text = montoTotal.ToString("F2");

                    if (this.gestor.ReglaGasto(montoTotal, this.gestor.User.R20))
                    {
                        this.txtR20.BackColor = Color.GreenYellow;
                    }
                    else
                    {
                        this.txtR20.BackColor = Color.Crimson;

                    }
                }

            }

            this.txtR50.Text = "$ " + this.txtR50.Text;
            this.txtR20.Text = "$ " + this.txtR20.Text;
            this.txtR30.Text = "$ " + this.txtR30.Text;




        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
