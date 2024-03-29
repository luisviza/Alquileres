﻿using System;
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
    public partial class frmLog : Form
    {
        public frmLog()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Favor Ingresa el Usuario");
                return;
            }

            if (txtPassword.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Favor Ingresa la clave");
                return;
            }
            try
            {
                if (Usuario.Autenticar(txtUsuario.Text, txtPassword.Text))
                {
                    this.Hide();
                    MessageBox.Show("Bienvenido " + txtUsuario.Text);
                    frmMenu elmenuPrincipal = new frmMenu();
                    elmenuPrincipal.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(-1);
        }
    }
}
