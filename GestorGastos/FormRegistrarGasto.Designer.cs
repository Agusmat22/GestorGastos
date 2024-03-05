namespace GestorGastos
{
    partial class FormRegistrarGasto
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
            lblTitulo = new Label();
            cmbTipoGasto = new ComboBox();
            label2 = new Label();
            txtValor = new TextBox();
            btnCancelar = new Button();
            btnRegistrar = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(135, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(87, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registrar";
            // 
            // cmbTipoGasto
            // 
            cmbTipoGasto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoGasto.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTipoGasto.FormattingEnabled = true;
            cmbTipoGasto.Location = new Point(54, 110);
            cmbTipoGasto.Name = "cmbTipoGasto";
            cmbTipoGasto.Size = new Size(254, 28);
            cmbTipoGasto.TabIndex = 1;
            cmbTipoGasto.SelectedIndexChanged += cmbTipoGasto_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(133, 80);
            label2.Name = "label2";
            label2.Size = new Size(92, 19);
            label2.TabIndex = 2;
            label2.Text = "Tipo de gasto";
            // 
            // txtValor
            // 
            txtValor.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtValor.Location = new Point(54, 188);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(254, 27);
            txtValor.TabIndex = 5;
            txtValor.KeyPress += txtValor_KeyPress;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(54, 261);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(122, 33);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Brown;
            btnRegistrar.FlatAppearance.BorderColor = Color.Black;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Location = new Point(186, 261);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(122, 33);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(157, 157);
            label4.Name = "label4";
            label4.Size = new Size(40, 19);
            label4.TabIndex = 9;
            label4.Text = "Valor";
            // 
            // FormRegistrarGasto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 333);
            Controls.Add(label4);
            Controls.Add(btnRegistrar);
            Controls.Add(btnCancelar);
            Controls.Add(txtValor);
            Controls.Add(label2);
            Controls.Add(cmbTipoGasto);
            Controls.Add(lblTitulo);
            Name = "FormRegistrarGasto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegistrarGasto";
            Load += FormRegistrarGasto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private ComboBox cmbTipoGasto;
        private Label label2;
        private TextBox txtValor;
        private Button btnCancelar;
        private Button btnRegistrar;
        private Label label4;
    }
}