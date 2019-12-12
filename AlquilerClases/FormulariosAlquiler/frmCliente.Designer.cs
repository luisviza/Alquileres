namespace FormulariosAlquiler
{
    partial class frmCliente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gboListaCliente = new System.Windows.Forms.GroupBox();
            this.lstCliente = new System.Windows.Forms.ListBox();
            this.gboDatosCliente = new System.Windows.Forms.GroupBox();
            this.rbuMasc = new System.Windows.Forms.RadioButton();
            this.rbuFem = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNroDoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gboListaCliente.SuspendLayout();
            this.gboDatosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(609, 353);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(83, 30);
            this.btnLimpiar.TabIndex = 38;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(507, 353);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 30);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(403, 353);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(83, 30);
            this.btnGuardar.TabIndex = 36;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(229, 353);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(83, 30);
            this.btnEliminar.TabIndex = 35;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(127, 353);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(83, 30);
            this.btnEditar.TabIndex = 34;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(23, 353);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(83, 30);
            this.btnAgregar.TabIndex = 33;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // gboListaCliente
            // 
            this.gboListaCliente.Controls.Add(this.lstCliente);
            this.gboListaCliente.Location = new System.Drawing.Point(23, 17);
            this.gboListaCliente.Name = "gboListaCliente";
            this.gboListaCliente.Size = new System.Drawing.Size(289, 312);
            this.gboListaCliente.TabIndex = 32;
            this.gboListaCliente.TabStop = false;
            this.gboListaCliente.Text = "Lista de Clientes";
            // 
            // lstCliente
            // 
            this.lstCliente.FormattingEnabled = true;
            this.lstCliente.Location = new System.Drawing.Point(17, 22);
            this.lstCliente.Name = "lstCliente";
            this.lstCliente.Size = new System.Drawing.Size(255, 277);
            this.lstCliente.TabIndex = 12;
            // 
            // gboDatosCliente
            // 
            this.gboDatosCliente.Controls.Add(this.rbuMasc);
            this.gboDatosCliente.Controls.Add(this.rbuFem);
            this.gboDatosCliente.Controls.Add(this.label7);
            this.gboDatosCliente.Controls.Add(this.txtContacto);
            this.gboDatosCliente.Controls.Add(this.label6);
            this.gboDatosCliente.Controls.Add(this.txtDireccion);
            this.gboDatosCliente.Controls.Add(this.label5);
            this.gboDatosCliente.Controls.Add(this.dtpFechaNac);
            this.gboDatosCliente.Controls.Add(this.label4);
            this.gboDatosCliente.Controls.Add(this.txtNacionalidad);
            this.gboDatosCliente.Controls.Add(this.label3);
            this.gboDatosCliente.Controls.Add(this.txtNombre);
            this.gboDatosCliente.Controls.Add(this.label2);
            this.gboDatosCliente.Controls.Add(this.txtNroDoc);
            this.gboDatosCliente.Controls.Add(this.label1);
            this.gboDatosCliente.Location = new System.Drawing.Point(368, 17);
            this.gboDatosCliente.Name = "gboDatosCliente";
            this.gboDatosCliente.Size = new System.Drawing.Size(348, 312);
            this.gboDatosCliente.TabIndex = 31;
            this.gboDatosCliente.TabStop = false;
            this.gboDatosCliente.Text = "Datos Personales";
            // 
            // rbuMasc
            // 
            this.rbuMasc.AutoSize = true;
            this.rbuMasc.Location = new System.Drawing.Point(241, 264);
            this.rbuMasc.Name = "rbuMasc";
            this.rbuMasc.Size = new System.Drawing.Size(73, 17);
            this.rbuMasc.TabIndex = 14;
            this.rbuMasc.TabStop = true;
            this.rbuMasc.Text = "Masculino";
            this.rbuMasc.UseVisualStyleBackColor = true;
            // 
            // rbuFem
            // 
            this.rbuFem.AutoSize = true;
            this.rbuFem.Location = new System.Drawing.Point(163, 264);
            this.rbuFem.Name = "rbuFem";
            this.rbuFem.Size = new System.Drawing.Size(71, 17);
            this.rbuFem.TabIndex = 13;
            this.rbuFem.TabStop = true;
            this.rbuFem.Text = "Femenino";
            this.rbuFem.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sexo";
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(163, 227);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(128, 20);
            this.txtContacto.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Contacto";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(163, 187);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(151, 20);
            this.txtDireccion.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dirección";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(163, 148);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(95, 20);
            this.dtpFechaNac.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(163, 108);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(128, 20);
            this.txtNacionalidad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nacionalidad";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(163, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(151, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre y Apellido";
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.Location = new System.Drawing.Point(163, 30);
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.Size = new System.Drawing.Size(95, 20);
            this.txtNroDoc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de Documento";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 414);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gboListaCliente);
            this.Controls.Add(this.gboDatosCliente);
            this.Name = "frmCliente";
            this.Text = "::Mantenimiento Cliente::";
            this.gboListaCliente.ResumeLayout(false);
            this.gboDatosCliente.ResumeLayout(false);
            this.gboDatosCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gboListaCliente;
        private System.Windows.Forms.ListBox lstCliente;
        private System.Windows.Forms.GroupBox gboDatosCliente;
        private System.Windows.Forms.RadioButton rbuMasc;
        private System.Windows.Forms.RadioButton rbuFem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNroDoc;
        private System.Windows.Forms.Label label1;
    }
}

