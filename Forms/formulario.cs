using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientesApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientesApp.Forms
{
    public partial class formulario : Form
    {
        public int? id;
        Cliente cliente = null; 

        public formulario(int? id= null)
        {
            InitializeComponent();
            this.id = id;

            if(id != null)
            {
                cargarDatos();

            }
        }

        //carga los datos para editar
        private void cargarDatos()
        {
            using (clientesContext db = new clientesContext())
            {
                cliente = db.Clientes.Find(id); //trae datos del registro obtenido

                textNombres.Text = cliente.Nombres;
                textApellidos.Text = cliente.Apellidos;
                textDireccion.Text = cliente.Direccion;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (clientesContext db = new clientesContext())
            {
                if(id == null)
                {
                    cliente = new Cliente();
                }

                cliente.Nombres = textNombres.Text;
                cliente.Apellidos = textApellidos.Text;
                cliente.Direccion = textDireccion.Text;

                if(id == null)
                {
                    db.Clientes.Add(cliente);
                }
                else
                {
                    db.Entry(cliente).State = EntityState.Modified;
                }
                db.SaveChanges();

                this.Close();
            }
        }
    }
}
