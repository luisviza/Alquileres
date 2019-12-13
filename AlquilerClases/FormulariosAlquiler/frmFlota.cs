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
    public partial class frmFlota : Form
    {
        Flota flota;
        public frmFlota()
        {
            InitializeComponent();
        }
        
        private void frmFlota_Load(object sender, EventArgs e)
        {

            dtgVehiculo.AutoGenerateColumns = true;

            cboVehiculo.SelectedItem = null;
            Vehiculo v = new Vehiculo();
            
            ActualizarListasFlotas();
            
            cboVehiculo.DataSource = Vehiculo.ObtenerVehiculos();
            cboVehiculo.SelectedItem = null;
            
            BloquearFormulario();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DetalleFlota df = new DetalleFlota();
            df.precio = Convert.ToDouble(txtpreciod.Text);
            df.IdFlota = (Flota)cboVehiculo.SelectedItem;
            flota.detalleFlota.Add(df);
            ActualizarDataGrid();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DetalleFlota df = (DetalleFlota)dtgVehiculo.CurrentRow.DataBoundItem;
            flota.detalleFlota.Remove(df);
            ActualizarDataGrid();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtIdFlota.Text))
            {
                flota.Id = Convert.ToInt32(txtIdFlota.Text);
            }
            flota.vehiculo = (Vehiculo)cboVehiculo.SelectedItem;
            flota.precioDiario= Convert.ToInt32(txtpreciod.Text);
            if (rdbAlquilado.Checked)
            {
                flota.estado = Estados.Alquilado;
            }
            else if (rdbDisponible.Checked)
            {
                flota.estado = Estados.Disponible;
            }
            Flota.AgregarFlota(flota);
            MessageBox.Show("La Flota ha sido actualizada");
            Limpiar();
            dtgVehiculo.DataSource = null;
            cboVehiculo.SelectedItem = (Vehiculo)Vehiculo.ObtenerVehiculo(flota.vehiculo.Id);
            txtpreciod.Text = Convert.ToString(flota.precioDiario);

            if (flota.estado == Estados.Disponible)
            {
                rdbDisponible.Checked = false;
            }
            else if (flota.estado == Estados.Alquilado)
            {
                rdbAlquilado.Checked = false;
            }

            flota = new Flota();
        }

        private void Limpiar()
        {
            throw new NotImplementedException();
        }
    }
    }
}
