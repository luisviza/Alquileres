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
    public partial class Alquiler : Form
    {
        public string modo;
        public Alquiler()
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
            Vehiculo Vehiculos = (Vehiculo)lstAlquiler.SelectedItem;

            if (Vehiculos != null)
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
            Vehiculo vehiculo = (Vehiculo)lstAlquiler.SelectedItem;
            if (vehiculo != null)
            {
                Vehiculo.EliminarVehiculo(vehiculo);
                ActualizarListaVehiculo();
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Favor seleccionar una fila de la lista");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modo == "I")
            {
                Vehiculo vehiculo = ObtenerVehiculoFormulario();
                Vehiculo.AgregarVehiculo(vehiculo);
            }
            else if (modo == "E")
            {
                int index = lstAlquiler.SelectedIndex;
                Vehiculo carne = ObtenerVehiculoFormulario();
                Vehiculo.EditarVehiculo(index, carne);
            }

            ActualizarListaVehiculo();
            LimpiarFormulario();
            BloquearFormulario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            BloquearFormulario();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }
    }
}
