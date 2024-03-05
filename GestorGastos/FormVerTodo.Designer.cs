namespace GestorGastos
{
    partial class FormVerTodo
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
            lstbTipoGastos = new ListBox();
            btnModificar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // lstbTipoGastos
            // 
            lstbTipoGastos.FormattingEnabled = true;
            lstbTipoGastos.ItemHeight = 15;
            lstbTipoGastos.Location = new Point(12, 27);
            lstbTipoGastos.Name = "lstbTipoGastos";
            lstbTipoGastos.Size = new Size(332, 334);
            lstbTipoGastos.TabIndex = 0;
            lstbTipoGastos.SelectedIndexChanged += lstbTipoGastos_SelectedIndexChanged;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Khaki;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(365, 27);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(52, 45);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "?";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Crimson;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(365, 88);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(52, 45);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "-";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // FormVerTodo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 385);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(lstbTipoGastos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormVerTodo";
            Text = "FormVerTodo";
            Load += FormVerTodo_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstbTipoGastos;
        private Button btnModificar;
        private Button btnEliminar;
    }
}