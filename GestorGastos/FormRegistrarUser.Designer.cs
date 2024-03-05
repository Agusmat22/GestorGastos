namespace GestorGastos
{
    partial class FormRegistrarUser
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
            btnRegistrar = new Button();
            btnCancelar = new Button();
            txtNombre = new TextBox();
            lblTitulo = new Label();
            label2 = new Label();
            txtR50 = new TextBox();
            txtR30 = new TextBox();
            txtR20 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Brown;
            btnRegistrar.FlatAppearance.BorderColor = Color.Black;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Location = new Point(184, 377);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(122, 33);
            btnRegistrar.TabIndex = 15;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(52, 377);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(122, 33);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(52, 82);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingrese el nombre";
            txtNombre.Size = new Size(254, 25);
            txtNombre.TabIndex = 13;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(131, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(87, 25);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Registrar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(85, 134);
            label2.Name = "label2";
            label2.Size = new Size(185, 25);
            label2.TabIndex = 16;
            label2.Text = "Porcentaje de gastos";
            // 
            // txtR50
            // 
            txtR50.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtR50.Location = new Point(52, 208);
            txtR50.Name = "txtR50";
            txtR50.PlaceholderText = "R 50";
            txtR50.Size = new Size(254, 25);
            txtR50.TabIndex = 17;
            // 
            // txtR30
            // 
            txtR30.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtR30.Location = new Point(52, 256);
            txtR30.Name = "txtR30";
            txtR30.PlaceholderText = "R 30";
            txtR30.Size = new Size(254, 25);
            txtR30.TabIndex = 18;
            // 
            // txtR20
            // 
            txtR20.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtR20.Location = new Point(52, 303);
            txtR20.Name = "txtR20";
            txtR20.PlaceholderText = "R 20";
            txtR20.Size = new Size(254, 25);
            txtR20.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(131, 170);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 20;
            label3.Text = "Regla 50-30-20";
            // 
            // FormRegistrarUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 432);
            Controls.Add(label3);
            Controls.Add(txtR20);
            Controls.Add(txtR30);
            Controls.Add(txtR50);
            Controls.Add(label2);
            Controls.Add(btnRegistrar);
            Controls.Add(btnCancelar);
            Controls.Add(txtNombre);
            Controls.Add(lblTitulo);
            Name = "FormRegistrarUser";
            Text = "FormRegistrarUser";
            Load += FormRegistrarUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar;
        private Button btnCancelar;
        private TextBox txtNombre;
        private Label lblTitulo;
        private Label label2;
        private TextBox txtR50;
        private TextBox txtR30;
        private TextBox txtR20;
        private Label label3;
    }
}