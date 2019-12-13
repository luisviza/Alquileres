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

        private void LimpiarFormulario()
        {
            txtNroDoc.Text = "";
            txtNombre.Text = "";
           cboNacionalidad.SelectedItem = null;
            dtpFechaNac.Value = System.DateTime.Now;
            txtDireccion.Text = "";
            txtContacto.Text = "";
            rbuFem.Checked = false;
            rbuMasc.Checked = false;
            
        }
        private void DesbloquearFormulario()
        {
            txtNroDoc.Enabled = true;
            txtNombre.Enabled = true;
          cboNacionalidad.Enabled = true;
            dtpFechaNac.Enabled = true;
            txtDireccion.Enabled = true;
            txtContacto.Enabled = true;
            rbuFem.Enabled = true;
            rbuMasc.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;

        }
        private void BloquearFormulario()
        {
            txtNroDoc.Enabled = false;
            txtNombre.Enabled = false;
            cboNacionalidad.Enabled = false;
            dtpFechaNac.Enabled = false;
            txtDireccion.Enabled = false;
            txtContacto.Enabled = false;
            rbuFem.Enabled = false;
            rbuMasc.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;

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

        private void ActualizarListaClientes()
        {
            lstCliente.DataSource = null;
            lstCliente.DataSource = Cliente.ObtenerClientes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modo == "I")
            {
                if (modo == "I")
            {
                    Cliente cliente = ObtenerClienteFormulario();

                    Cliente.AgregarCliente(cliente);

                
            }
            else if (modo == "E")
            {
                int index = lstCliente.SelectedIndex;

                    Cliente cliente = ObtenerClienteFormulario();
                    Cliente.EditarCliente(index, cliente);
                
            }

                ActualizarListaClientes();
            LimpiarFormulario();
            BloquearFormulario(); 

               


            }
        }

        private Cliente ObtenerClienteFormulario()
        {
            Cliente cliente = new Cliente();
            if (!string.IsNullOrWhiteSpace(txtId.Text))
            {
                cliente.Id = Convert.ToInt32(txtId.Text);
            }

            cliente.Nombre = txtNombre.Text;
            cliente.NumeroDocumento = txtNombre.Text;
            cliente.Nacionalidad = (Nacionalidades)cboNacionalidad.SelectedItem;
            cliente.Fecha_Nacimiento = dtpFechaNac.Value.Date;
            cliente.Direccion = txtDireccion.Text;
            cliente.Contacto = txtContacto.Text;

            if (rbuFem.Checked)
            {
                cliente.Sexo = Sexos.Femenino;
            }
            else if (rbuMasc.Checked)
            {
                cliente.Sexo = Sexos.Masculino;
            }
            
            return cliente;
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

        private void frmCliente_Load(object sender, EventArgs e)
        {
                       
            ActualizarListaClientes();
            cboNacionalidad.DataSource = Enum.GetValues(typeof(Nacionalidades));
            cboNacionalidad.SelectedItem = null;
            BloquearFormulario();
        }

        private void lstCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)lstCliente.SelectedItem;

            if (cliente != null)
            {
                txtId.Text = Convert.ToString(cliente.Id);

                txtNombre.Text = carne.nombre;
                txtPeso.Text = Convert.ToString(carne.peso);
                dtpFechaVencimiento.Value = carne.fecha_vencimiento;
                txtPrecio.Text = Convert.ToString(carne.precio);
                cmbCategoria.SelectedItem = (Categoria)carne.categoria;
                cmbProveedor.SelectedItem = (Proveedor)Proveedor.ObtenerProveedor(carne.proveedor.Id);
                if (carne.tipo_carne == TipoCarne.Vacuna)
                {
                    rdbVacuna.Checked = true;
                }
                else if (carne.tipo_carne == TipoCarne.Porcina)
                {
                    rdbPorcina.Checked = true;
                }
                ResetearCheckedListBox();
                foreach (string dia in carne.dias_entrega)
                {
                    if (dia == "L") clbDias.SetItemChecked(0, true);
                    else if (dia == "M") clbDias.SetItemChecked(1, true);
                    else if (dia == "X") clbDias.SetItemChecked(2, true);
                    else if (dia == "J") clbDias.SetItemChecked(3, true);
                    else if (dia == "V") clbDias.SetItemChecked(4, true);
                    else if (dia == "S") clbDias.SetItemChecked(5, true);
                    else if (dia == "D") clbDias.SetItemChecked(6, true);


                }
                if (true)
                {

                }

            }
        }
    }

}
