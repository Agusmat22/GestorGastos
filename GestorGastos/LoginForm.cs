using Entidades.sql;
using Entidades.user;
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
    public partial class LoginForm : Form
    {
        private List<User> users;
        private User loginUser;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.users = UserSQL.Obtener();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            this.cmbUsers.DataSource = users;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Menu formMenu = new Menu(loginUser);

            this.Hide();
            formMenu.Show();
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Casteo el usuario seleccionado en el CMB al usuario logueado
            this.loginUser = (User)cmbUsers.SelectedItem;
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
