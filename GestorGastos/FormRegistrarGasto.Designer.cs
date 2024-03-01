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
            label1 = new Label();
            cmbTipoGasto = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            txtValor = new TextBox();
            btnCancelar = new Button();
            btnRegistrar = new Button();
            cmbNombre = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(135, 10);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 0;
            label1.Text = "Registrar";
            // 
            // cmbTipoGasto
            // 
            cmbTipoGasto.FormattingEnabled = true;
            cmbTipoGasto.Location = new Point(54, 110);
            cmbTipoGasto.Name = "cmbTipoGasto";
            cmbTipoGasto.Size = new Size(254, 23);
            cmbTipoGasto.TabIndex = 1;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(148, 153);
            label3.Name = "label3";
            label3.Size = new Size(59, 19);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // txtValor
            // 
            txtValor.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtValor.Location = new Point(54, 251);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(254, 25);
            txtValor.TabIndex = 5;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(54, 364);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(122, 33);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Brown;
            btnRegistrar.FlatAppearance.BorderColor = Color.Black;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Location = new Point(186, 364);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(122, 33);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // cmbNombre
            // 
            cmbNombre.FormattingEnabled = true;
            cmbNombre.Location = new Point(54, 184);
            cmbNombre.Name = "cmbNombre";
            cmbNombre.Size = new Size(254, 23);
            cmbNombre.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(157, 229);
            label4.Name = "label4";
            label4.Size = new Size(40, 19);
            label4.TabIndex = 9;
            label4.Text = "Valor";
            // 
            // FormRegistrarGasto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 432);
            Controls.Add(label4);
            Controls.Add(cmbNombre);
            Controls.Add(btnRegistrar);
            Controls.Add(btnCancelar);
            Controls.Add(txtValor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbTipoGasto);
            Controls.Add(label1);
            Name = "FormRegistrarGasto";
            Text = "FormRegistrarGasto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbTipoGasto;
        private Label label2;
        private Label label3;
        private TextBox txtValor;
        private Button btnCancelar;
        private Button btnRegistrar;
        private ComboBox cmbNombre;
        private Label label4;
    }
}