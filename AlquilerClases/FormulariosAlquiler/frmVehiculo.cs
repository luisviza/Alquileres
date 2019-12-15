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
    public partial class frmVehiculo : Form
    {
        public string modo;
        public frmVehiculo()
        {
            InitializeComponent();
        }
        
        
        

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            modo = "I";
            LimpiarFormulario();
            DesbloquearFormulario();

        }

        private void frmVehiculo_Load(object sender, EventArgs e)
        {
            ActualizarListaVehiculos();
            
            cboMarca.SelectedIndex = 1;

            //cmbProveedor.SelectedItem = null;
            BloquearFormulario();

        }

        private void ActualizarListaVehiculos()
        {
            lstMarca.DataSource = null;
            lstMarca.DataSource = Vehiculo.ObtenerVehiculos();
        }

        private void BloquearFormulario()
        {
            txtNroMatricula.Enabled = false;
            cboMarca.Enabled = false;
            dtpFechaCompra.Enabled = false;
            txtModelo.Enabled = false;
            txtCantPuertas.Enabled = false;
            txtPlazas.Enabled = false;

        }

        private void DesbloquearFormulario()
        {
            txtNroMatricula.Enabled = true;
            cboMarca.Enabled = true;
            txtModelo.Enabled = true;
            dtpFechaCompra.Enabled = true;
            txtCantPuertas.Enabled = true;
            txtPlazas.Enabled = true;
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {

           
            Vehiculo vehiculo = (Vehiculo)lstMarca.SelectedItem;

            if (vehiculo != null)
            {
                modo = "E";
                DesbloquearFormulario();
            }
            else
            {
                MessageBox.Show("Seleccione un item de la lista");
            }

        }

        private Vehiculo ObtenerVehiculoFormulario()
        {
            Vehiculo vehiculo = new Vehiculo();
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                vehiculo.Id = Convert.ToInt32(txtId.Text);
            }

            vehiculo.Matricula = txtNroMatricula.Text;
            vehiculo.Marca = (marcas)cboMarca.SelectedItem;
            vehiculo.Fecha_Compra = dtpFechaCompra.Value.Date;
            vehiculo.Modelo = txtModelo.Text;
            vehiculo.PuertasCantidad = Convert.ToInt16(txtCantPuertas);
            vehiculo.Plazas = Convert.ToInt16(txtPlazas);

            return vehiculo;
        }

        private void LimpiarFormulario()
        {
            txtNroMatricula.Text = "";
            cboMarca.SelectedItem = "";
            dtpFechaCompra.Value = System.DateTime.Now;
            txtModelo.Text = "";
            txtCantPuertas.Text = "";
            txtPlazas.Text = "";

        }

        private void ActualizarListaVehiculo()
        {
            lstMarca.DataSource = null;
            lstMarca.DataSource = Vehiculo.ObtenerVehiculos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Vehiculo carne = (Vehiculo)lstMarca.SelectedItem;
            if (carne != null)
            {
                Vehiculo.EliminarVehiculo(carne);
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
                int index = lstMarca.SelectedIndex;
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
            LimpiarFormulario();
        }

        private void frmVehiculo_Load_1(object sender, EventArgs e)
        {

        }
    }
}

