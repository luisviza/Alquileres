using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlquilerClases;

namespace FormulariosAlquiler
{
    
    public partial class frmCliente : Form

    {
        string modo;
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            modo = "I";
            LimpiarFormulario();
            DesbloquearFormulario();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)lstCliente.SelectedItem;

            if (cliente != null)
            {
                modo = "E";
                DesbloquearFormulario();
            }
            else
            {
                MessageBox.Show("Seleccione un item de la lista");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)lstCliente.SelectedItem;
            if (cliente != null)
            {
                Cliente.EliminarCliente(cliente);
                ActualizarListaClientes();
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Por favor, Seleccione un item de la lista");
            }
            cliente = (Cliente)lstCliente.SelectedItem;
            if (cliente != null)
            {
                Cliente.EliminarCliente(cliente);
                ActualizarListaClientes();
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Por favor, Seleccione un item de la lista");
            }
        }
    }
}
