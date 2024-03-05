namespace GestorGastos
{
    partial class FormRegistrarTipo
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
            label4 = new Label();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            txtNombre = new TextBox();
            label2 = new Label();
            cmbTipo = new ComboBox();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(149, 171);
            label4.Name = "label4";
            label4.Size = new Size(59, 19);
            label4.TabIndex = 16;
            label4.Text = "Nombre";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Brown;
            btnRegistrar.FlatAppearance.BorderColor = Color.Black;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Location = new Point(184, 275);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(122, 33);
            btnRegistrar.TabIndex = 15;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(52, 275);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(122, 33);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(52, 202);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(254, 27);
            txtNombre.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(158, 89);
            label2.Name = "label2";
            label2.Size = new Size(35, 19);
            label2.TabIndex = 12;
            label2.Text = "Tipo";
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(52, 124);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(254, 28);
            cmbTipo.TabIndex = 11;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(113, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(126, 25);
            lblTitulo.TabIndex = 10;
            lblTitulo.Text = "Registrar tipo";
            // 
            // FormRegistrarTipo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 333);
            Controls.Add(label4);
            Controls.Add(btnRegistrar);
            Controls.Add(btnCancelar);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(cmbTipo);
            Controls.Add(lblTitulo);
            Name = "FormRegistrarTipo";
            Text = "FormRegistrarTipo";
            Load += FormRegistrarTipo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button btnRegistrar;
        private Button btnCancelar;
        private TextBox txtNombre;
        private Label label2;
        private ComboBox cmbTipo;
        private Label lblTitulo;
    }
}