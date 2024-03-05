namespace GestorGastos
{
    partial class FormBalance
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            txtSueldo = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtGastoTotal = new TextBox();
            label9 = new Label();
            txtR50 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtR20 = new TextBox();
            dgvGastos = new DataGridView();
            Tipo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            dateTimePicker1 = new DateTimePicker();
            txtR30 = new TextBox();
            cmbOrden = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvGastos).BeginInit();
            SuspendLayout();
            // 
            // txtSueldo
            // 
            txtSueldo.Enabled = false;
            txtSueldo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSueldo.Location = new Point(22, 413);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.ReadOnly = true;
            txtSueldo.Size = new Size(110, 25);
            txtSueldo.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 395);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 8;
            label5.Text = "Sueldo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(701, 395);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 10;
            label6.Text = "Gasto total";
            // 
            // txtGastoTotal
            // 
            txtGastoTotal.Enabled = false;
            txtGastoTotal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtGastoTotal.Location = new Point(678, 413);
            txtGastoTotal.Name = "txtGastoTotal";
            txtGastoTotal.ReadOnly = true;
            txtGastoTotal.Size = new Size(110, 25);
            txtGastoTotal.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 13);
            label9.Name = "label9";
            label9.Size = new Size(73, 15);
            label9.TabIndex = 14;
            label9.Text = "Necesidades";
            // 
            // txtR50
            // 
            txtR50.Enabled = false;
            txtR50.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtR50.Location = new Point(22, 31);
            txtR50.Name = "txtR50";
            txtR50.ReadOnly = true;
            txtR50.Size = new Size(78, 25);
            txtR50.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(132, 13);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 16;
            label7.Text = "Ocio";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(214, 13);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 18;
            label8.Text = "Ahorro";
            // 
            // txtR20
            // 
            txtR20.Enabled = false;
            txtR20.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtR20.Location = new Point(111, 31);
            txtR20.Name = "txtR20";
            txtR20.ReadOnly = true;
            txtR20.Size = new Size(78, 25);
            txtR20.TabIndex = 17;
            // 
            // dgvGastos
            // 
            dgvGastos.BackgroundColor = Color.IndianRed;
            dgvGastos.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(0, 2, 0, 2);
            dataGridViewCellStyle1.SelectionBackColor = Color.RosyBrown;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvGastos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvGastos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGastos.Columns.AddRange(new DataGridViewColumn[] { Tipo, Nombre, Fecha, Valor });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Gainsboro;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvGastos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvGastos.EnableHeadersVisualStyles = false;
            dgvGastos.GridColor = SystemColors.AppWorkspace;
            dgvGastos.Location = new Point(22, 78);
            dgvGastos.Name = "dgvGastos";
            dgvGastos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvGastos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvGastos.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.Padding = new Padding(0, 1, 0, 1);
            dataGridViewCellStyle4.SelectionBackColor = Color.Firebrick;
            dgvGastos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvGastos.RowTemplate.Height = 25;
            dgvGastos.Size = new Size(766, 301);
            dgvGastos.TabIndex = 19;
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            Tipo.Width = 181;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 203;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 190;
            // 
            // Valor
            // 
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            Valor.Width = 190;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(350, 31);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(225, 25);
            dateTimePicker1.TabIndex = 20;
            // 
            // txtR30
            // 
            txtR30.Enabled = false;
            txtR30.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtR30.Location = new Point(200, 31);
            txtR30.Name = "txtR30";
            txtR30.ReadOnly = true;
            txtR30.Size = new Size(78, 25);
            txtR30.TabIndex = 21;
            // 
            // cmbOrden
            // 
            cmbOrden.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrden.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbOrden.FormattingEnabled = true;
            cmbOrden.Location = new Point(664, 31);
            cmbOrden.Name = "cmbOrden";
            cmbOrden.Size = new Size(124, 25);
            cmbOrden.TabIndex = 22;
            cmbOrden.SelectedIndexChanged += cmbOrden_SelectedIndexChanged;
            // 
            // FormBalance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbOrden);
            Controls.Add(txtR30);
            Controls.Add(dateTimePicker1);
            Controls.Add(dgvGastos);
            Controls.Add(label8);
            Controls.Add(txtR20);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(txtR50);
            Controls.Add(label6);
            Controls.Add(txtGastoTotal);
            Controls.Add(label5);
            Controls.Add(txtSueldo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormBalance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBalance";
            FormClosing += FormBalance_FormClosing;
            Load += FormBalance_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGastos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSueldo;
        private TextBox txtR50;
        private TextBox txtR20;
        private TextBox txtR30;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtGastoTotal;
        private Label label9;
        private TextBox textBox7;
        private Label label7;
        private TextBox textBox5;
        private Label label8;
        private TextBox textBox6;
        private DataGridView dgvGastos;
        private DateTimePicker dateTimePicker1;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Valor;
        private ComboBox cmbOrden;
    }
}