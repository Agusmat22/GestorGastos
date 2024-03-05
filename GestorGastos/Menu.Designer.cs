namespace GestorGastos
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            gastosToolStripMenuItem = new ToolStripMenuItem();
            registrarTsm = new ToolStripMenuItem();
            tipoToolStripMenuItem = new ToolStripMenuItem();
            registrarTipoTSM = new ToolStripMenuItem();
            verTodoTSM = new ToolStripMenuItem();
            balanceToolStripMenuItem = new ToolStripMenuItem();
            visualizarToolStripMenuItem = new ToolStripMenuItem();
            usuarioToolStripMenuItem = new ToolStripMenuItem();
            registrarToolStripMenuItem1 = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            modificarToolStripMenuItem1 = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.Brown;
            menuStrip1.BackgroundImageLayout = ImageLayout.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gastosToolStripMenuItem, balanceToolStripMenuItem, usuarioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 50);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // gastosToolStripMenuItem
            // 
            gastosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrarTsm, tipoToolStripMenuItem });
            gastosToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            gastosToolStripMenuItem.Name = "gastosToolStripMenuItem";
            gastosToolStripMenuItem.Size = new Size(65, 46);
            gastosToolStripMenuItem.Text = "Gastos";
            // 
            // registrarTsm
            // 
            registrarTsm.Name = "registrarTsm";
            registrarTsm.Size = new Size(180, 24);
            registrarTsm.Text = "Registrar";
            registrarTsm.Click += registrarTsm_Click;
            // 
            // tipoToolStripMenuItem
            // 
            tipoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrarTipoTSM, verTodoTSM });
            tipoToolStripMenuItem.Name = "tipoToolStripMenuItem";
            tipoToolStripMenuItem.Size = new Size(180, 24);
            tipoToolStripMenuItem.Text = "Tipo";
            // 
            // registrarTipoTSM
            // 
            registrarTipoTSM.Name = "registrarTipoTSM";
            registrarTipoTSM.Size = new Size(180, 24);
            registrarTipoTSM.Text = "Registrar";
            registrarTipoTSM.Click += registrarTipoTSM_Click;
            // 
            // verTodoTSM
            // 
            verTodoTSM.Name = "verTodoTSM";
            verTodoTSM.Size = new Size(180, 24);
            verTodoTSM.Text = "Ver todo";
            verTodoTSM.Click += verTodoTSM_Click;
            // 
            // balanceToolStripMenuItem
            // 
            balanceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { visualizarToolStripMenuItem });
            balanceToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            balanceToolStripMenuItem.Name = "balanceToolStripMenuItem";
            balanceToolStripMenuItem.Size = new Size(73, 46);
            balanceToolStripMenuItem.Text = "Balance";
            // 
            // visualizarToolStripMenuItem
            // 
            visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            visualizarToolStripMenuItem.Size = new Size(142, 24);
            visualizarToolStripMenuItem.Text = "Visualizar";
            visualizarToolStripMenuItem.Click += visualizarToolStripMenuItem_Click;
            // 
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrarToolStripMenuItem1, eliminarToolStripMenuItem, modificarToolStripMenuItem1 });
            usuarioToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            usuarioToolStripMenuItem.ForeColor = Color.Black;
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new Size(72, 46);
            usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // registrarToolStripMenuItem1
            // 
            registrarToolStripMenuItem1.Name = "registrarToolStripMenuItem1";
            registrarToolStripMenuItem1.Size = new Size(143, 24);
            registrarToolStripMenuItem1.Text = "Registrar";
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(143, 24);
            eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // modificarToolStripMenuItem1
            // 
            modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            modificarToolStripMenuItem1.Size = new Size(143, 24);
            modificarToolStripMenuItem1.Text = "Modificar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(128, 33, 33);
            label1.Location = new Point(260, 137);
            label1.Name = "label1";
            label1.Size = new Size(283, 46);
            label1.TabIndex = 1;
            label1.Text = "Gestor de gastos";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 232, 232);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MaximizeBox = false;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            FormClosing += Menu_FormClosing;
            Load += Menu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gastosToolStripMenuItem;
        private ToolStripMenuItem registrarTsm;
        private ToolStripMenuItem balanceToolStripMenuItem;
        private ToolStripMenuItem visualizarToolStripMenuItem;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem registrarToolStripMenuItem1;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private Label label1;
        private ToolStripMenuItem tipoToolStripMenuItem;
        private ToolStripMenuItem registrarTipoTSM;
        private ToolStripMenuItem modificarToolStripMenuItem1;
        private ToolStripMenuItem verTodoTSM;
    }
}
