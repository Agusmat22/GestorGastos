
using Entidades.finance;
using Entidades.sql;
using Entidades.user;



namespace GestorGastos
{
    public partial class Menu : Form
    {

        private GestorGasto gestor;
        private User user;

        public Menu(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        public GestorGasto Gestor { get => gestor; set => gestor = value; }

        private void Menu_Load(object sender, EventArgs e)
        {

            this.gestor = new GestorGasto();

            try
            {


                this.gestor.TipoGasto = TipoGastoSQL.Obtener();
                this.gestor.Gastos = GastoSQL.Obtener(user, this.gestor.TipoGasto);
                this.gestor.User = user;





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormBalance formBalance = new FormBalance(this, this.gestor);

            this.Hide();
            formBalance.Show();




        }

        private void registrarTsm_Click(object sender, EventArgs e)
        {
            FormRegistrarGasto formRegistrarGasto = new FormRegistrarGasto(this.gestor, "Registrar");

            DialogResult result = formRegistrarGasto.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Registro con exito");

            }
        }

        private void registrarTipoTSM_Click(object sender, EventArgs e)
        {
            FormRegistrarTipo formRegistrarTipo = new FormRegistrarTipo(this.gestor, "Registrar");

            formRegistrarTipo.ShowDialog();
        }

        private void verTodoTSM_Click(object sender, EventArgs e)
        {
            FormVerTodo formVerTodo = new FormVerTodo(this.gestor);
            formVerTodo.ShowDialog();
        }

        /// <summary>
        /// Falta seleccionar el gasto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


    }
}
