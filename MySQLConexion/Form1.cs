using MySql.Data.MySqlClient;
using System.Data;

namespace MySQLConexion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            string host = txtHost.Text;
            string user = txtUsuario.Text;
            string password = txtContrasena.Text;
            string puerto = txtPuerto.Text;
            string database = txtBaseDatos.Text;

            string connectionString = BuildConnectionString(host, user, password, puerto, database);

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM cat_personal", con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvDatos.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error: " + ex.Message);
                }
            }
        }

        private string BuildConnectionString(string host, string user, string password, string port, string database)
        {
            return $"SERVER={host};PORT={port};DATABASE={database};USER ID={user};PASSWORD={password};";
        }
    }
}