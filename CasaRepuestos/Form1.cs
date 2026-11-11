using Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaRepuestos
{
    public partial class Form1 : Form
    {
        GestorRepuestos gestor = new GestorRepuestos();
        public Form1()
        {
           
            InitializeComponent();
            gestor.CargarArchivo();

            dgvRepuestos.DataSource = null;
            dgvRepuestos.DataSource = gestor.ObtenerTodos();
        }

        private void lblStock_Click(object sender, EventArgs e)
        {

        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Repuesto repuesto = new Repuesto();

            repuesto.Codigo = txtCodigo.Text;
            repuesto.Nombre = txtNombre.Text;
            repuesto.Stock = int.Parse(TxtStock.Text);
            repuesto.Precio = decimal.Parse(txtPrecio.Text);

            gestor.Agregar(repuesto);
            MessageBox.Show("Cantidad: " + gestor.ObtenerTodos().Count);
            gestor.GuardarArchivo();

            dgvRepuestos.DataSource = null;
            dgvRepuestos.DataSource = gestor.ObtenerTodos();

            MessageBox.Show("Repuesto guardado");

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Repuesto encontrado = gestor.Buscar(txtBuscar.Text);

            if (encontrado != null)
            {
                MessageBox.Show(
                    "Nombre: " + encontrado.Nombre +
                    "\nStock: " + encontrado.Stock +
                    "\nPrecio: $" + encontrado.Precio);
            }
            else
            {
                MessageBox.Show("Repuesto no encontrado");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
      
        {
            gestor.Eliminar(txtBuscar.Text);

            dgvRepuestos.DataSource = null;
            dgvRepuestos.DataSource = gestor.ObtenerTodos();

            MessageBox.Show("Repuesto eliminado");
        }

    }
    }
