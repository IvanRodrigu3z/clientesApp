using ClientesApp.Models;

namespace ClientesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarTabla();
            
        }

        private void cargarTabla()
        {
            using(clientesContext db = new clientesContext())
            {
                var listClientes = from cliente in db.Clientes
                                   select cliente;
                dataGridView1.DataSource = listClientes.ToList();
            }
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            Forms.formulario formAgregar = new Forms.formulario();
            formAgregar.ShowDialog();

            cargarTabla();
        }

        private int? getId()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());

            }
            catch
            {
                return null;
            }
        }

        private void editar_Click(object sender, EventArgs e)
        {
            int? id = getId();
            
            if(id != null)
            {
                Forms.formulario editar = new Forms.formulario(id);
                editar.ShowDialog();

                cargarTabla();
            }
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            int? id = getId();

            if (id != null)
            {
                using(clientesContext db = new clientesContext())
                {
                    Cliente cliente = db.Clientes.Find(id);
                    db.Clientes.Remove(cliente);
                    db.SaveChanges();
                }
                cargarTabla();
            }
        }
    }
}