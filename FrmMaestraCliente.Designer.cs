namespace LoginV1
{
    partial class FrmMaestraCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnUltimoRegistro = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnPrimerRegistro = new System.Windows.Forms.Button();
            this.lblCorreoCliente = new System.Windows.Forms.Label();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbTipoArchivo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(166)))), ((int)(((byte)(167)))));
            this.btnAgregar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(838, 241);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(156, 38);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(166)))), ((int)(((byte)(167)))));
            this.btnConsultar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(838, 297);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(156, 38);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(166)))), ((int)(((byte)(167)))));
            this.btnActualizar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(838, 355);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(156, 38);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(166)))), ((int)(((byte)(167)))));
            this.btnEliminar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(838, 411);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(156, 38);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(78, 135);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(165, 22);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(546, 135);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(213, 22);
            this.txtCorreo.TabIndex = 2;
            this.txtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreo_KeyPress);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(312, 135);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(189, 22);
            this.txtTelefono.TabIndex = 1;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // dtgClientes
            // 
            this.dtgClientes.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClientes.Location = new System.Drawing.Point(78, 188);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.RowHeadersWidth = 51;
            this.dtgClientes.RowTemplate.Height = 24;
            this.dtgClientes.Size = new System.Drawing.Size(649, 365);
            this.dtgClientes.TabIndex = 10;
            this.dtgClientes.TabStop = false;
            this.dtgClientes.SelectionChanged += new System.EventHandler(this.dtgClientes_SelectionChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(73, 105);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(88, 27);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(307, 105);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(90, 27);
            this.lblTelefono.TabIndex = 13;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(203)))), ((int)(((byte)(208)))));
            this.lblCliente.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.lblCliente.Location = new System.Drawing.Point(13, 9);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(1100, 50);
            this.lblCliente.TabIndex = 14;
            this.lblCliente.Text = "                                                        Cliente                  " +
    "                                 ";
            // 
            // btnUltimoRegistro
            // 
            this.btnUltimoRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(166)))), ((int)(((byte)(167)))));
            this.btnUltimoRegistro.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoRegistro.Location = new System.Drawing.Point(1020, 411);
            this.btnUltimoRegistro.Name = "btnUltimoRegistro";
            this.btnUltimoRegistro.Size = new System.Drawing.Size(157, 39);
            this.btnUltimoRegistro.TabIndex = 10;
            this.btnUltimoRegistro.Text = "Ultimo Registro";
            this.btnUltimoRegistro.UseVisualStyleBackColor = false;
            this.btnUltimoRegistro.Click += new System.EventHandler(this.btnUltimoRegistro_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(166)))), ((int)(((byte)(167)))));
            this.btnAnterior.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(1020, 355);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(157, 39);
            this.btnAnterior.TabIndex = 9;
            this.btnAnterior.Text = "Anterior Registro";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(166)))), ((int)(((byte)(167)))));
            this.btnSiguiente.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(1020, 297);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(157, 39);
            this.btnSiguiente.TabIndex = 8;
            this.btnSiguiente.Text = "Siguiente Registro";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnPrimerRegistro
            // 
            this.btnPrimerRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(166)))), ((int)(((byte)(167)))));
            this.btnPrimerRegistro.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimerRegistro.Location = new System.Drawing.Point(1020, 240);
            this.btnPrimerRegistro.Name = "btnPrimerRegistro";
            this.btnPrimerRegistro.Size = new System.Drawing.Size(157, 39);
            this.btnPrimerRegistro.TabIndex = 7;
            this.btnPrimerRegistro.Text = "Primer Registro";
            this.btnPrimerRegistro.UseVisualStyleBackColor = false;
            this.btnPrimerRegistro.Click += new System.EventHandler(this.btnPrimerRegistro_Click);
            // 
            // lblCorreoCliente
            // 
            this.lblCorreoCliente.AutoSize = true;
            this.lblCorreoCliente.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoCliente.Location = new System.Drawing.Point(541, 105);
            this.lblCorreoCliente.Name = "lblCorreoCliente";
            this.lblCorreoCliente.Size = new System.Drawing.Size(74, 27);
            this.lblCorreoCliente.TabIndex = 15;
            this.lblCorreoCliente.Text = "Correo";
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(166)))), ((int)(((byte)(167)))));
            this.btnRegistrarVenta.FlatAppearance.BorderSize = 0;
            this.btnRegistrarVenta.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarVenta.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarVenta.Location = new System.Drawing.Point(901, 503);
            this.btnRegistrarVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(192, 50);
            this.btnRegistrarVenta.TabIndex = 16;
            this.btnRegistrarVenta.Text = "Registrar venta";
            this.btnRegistrarVenta.UseVisualStyleBackColor = false;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(166)))), ((int)(((byte)(167)))));
            this.btnVolver.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.Black;
            this.btnVolver.Location = new System.Drawing.Point(1125, 547);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(97, 38);
            this.btnVolver.TabIndex = 26;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(166)))), ((int)(((byte)(167)))));
            this.btnExportar.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.Color.Black;
            this.btnExportar.Location = new System.Drawing.Point(934, 151);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(143, 38);
            this.btnExportar.TabIndex = 29;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(166)))), ((int)(((byte)(167)))));
            this.btnImportar.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportar.ForeColor = System.Drawing.Color.Black;
            this.btnImportar.Location = new System.Drawing.Point(934, 105);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(143, 38);
            this.btnImportar.TabIndex = 28;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = false;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(1103, 137);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(119, 20);
            this.lblTipo.TabIndex = 41;
            this.lblTipo.Text = "Tipo de Archivo:";
            // 
            // cbTipoArchivo
            // 
            this.cbTipoArchivo.FormattingEnabled = true;
            this.cbTipoArchivo.Items.AddRange(new object[] {
            "XML",
            "TXT",
            "CSV"});
            this.cbTipoArchivo.Location = new System.Drawing.Point(1107, 160);
            this.cbTipoArchivo.Name = "cbTipoArchivo";
            this.cbTipoArchivo.Size = new System.Drawing.Size(108, 24);
            this.cbTipoArchivo.TabIndex = 40;
            // 
            // FrmMaestraCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1278, 597);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cbTipoArchivo);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnRegistrarVenta);
            this.Controls.Add(this.lblCorreoCliente);
            this.Controls.Add(this.btnUltimoRegistro);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnPrimerRegistro);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dtgClientes);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "FrmMaestraCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maestra Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.DataGridView dtgClientes;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnUltimoRegistro;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnPrimerRegistro;
        private System.Windows.Forms.Label lblCorreoCliente;
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbTipoArchivo;
    }
}