namespace LoginV1
{
    partial class FrmMaestraProveedores
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
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblNombreEmpresa = new System.Windows.Forms.Label();
            this.txtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.lblTelefonoEmpresa = new System.Windows.Forms.Label();
            this.txtCorreoEmpresa = new System.Windows.Forms.TextBox();
            this.lblCorreoEmpresa = new System.Windows.Forms.Label();
            this.btnAgregarProovedor = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnActulizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dtgProveedor = new System.Windows.Forms.DataGridView();
            this.btnPrimerRegistro = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnUltimoRegistro = new System.Windows.Forms.Button();
            this.lblProveedores = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(354, 116);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(175, 22);
            this.txtTelefono.TabIndex = 1;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lblNombreEmpresa
            // 
            this.lblNombreEmpresa.AutoSize = true;
            this.lblNombreEmpresa.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpresa.Location = new System.Drawing.Point(80, 86);
            this.lblNombreEmpresa.Name = "lblNombreEmpresa";
            this.lblNombreEmpresa.Size = new System.Drawing.Size(93, 27);
            this.lblNombreEmpresa.TabIndex = 2;
            this.lblNombreEmpresa.Text = "Nombre ";
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.Location = new System.Drawing.Point(85, 116);
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.Size = new System.Drawing.Size(185, 22);
            this.txtNombreEmpresa.TabIndex = 0;
            this.txtNombreEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreEmpresa_KeyPress);
            // 
            // lblTelefonoEmpresa
            // 
            this.lblTelefonoEmpresa.AutoSize = true;
            this.lblTelefonoEmpresa.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoEmpresa.Location = new System.Drawing.Point(349, 86);
            this.lblTelefonoEmpresa.Name = "lblTelefonoEmpresa";
            this.lblTelefonoEmpresa.Size = new System.Drawing.Size(95, 27);
            this.lblTelefonoEmpresa.TabIndex = 4;
            this.lblTelefonoEmpresa.Text = "Telefono ";
            // 
            // txtCorreoEmpresa
            // 
            this.txtCorreoEmpresa.Location = new System.Drawing.Point(602, 116);
            this.txtCorreoEmpresa.Name = "txtCorreoEmpresa";
            this.txtCorreoEmpresa.Size = new System.Drawing.Size(230, 22);
            this.txtCorreoEmpresa.TabIndex = 2;
            this.txtCorreoEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreoEmpresa_KeyPress);
            // 
            // lblCorreoEmpresa
            // 
            this.lblCorreoEmpresa.AutoSize = true;
            this.lblCorreoEmpresa.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoEmpresa.Location = new System.Drawing.Point(597, 86);
            this.lblCorreoEmpresa.Name = "lblCorreoEmpresa";
            this.lblCorreoEmpresa.Size = new System.Drawing.Size(74, 27);
            this.lblCorreoEmpresa.TabIndex = 6;
            this.lblCorreoEmpresa.Text = "Correo";
            // 
            // btnAgregarProovedor
            // 
            this.btnAgregarProovedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(166)))), ((int)(((byte)(167)))));
            this.btnAgregarProovedor.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProovedor.Location = new System.Drawing.Point(908, 231);
            this.btnAgregarProovedor.Name = "btnAgregarProovedor";
            this.btnAgregarProovedor.Size = new System.Drawing.Size(125, 35);
            this.btnAgregarProovedor.TabIndex = 3;
            this.btnAgregarProovedor.Text = "Agregar";
            this.btnAgregarProovedor.UseVisualStyleBackColor = false;
            this.btnAgregarProovedor.Click += new System.EventHandler(this.btnAgregarProovedor_Click);
            this.btnAgregarProovedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnAgregarProovedor_KeyPress);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(166)))), ((int)(((byte)(167)))));
            this.btnConsultar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(908, 291);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(125, 35);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            this.btnConsultar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnConsultar_KeyPress);
            // 
            // btnActulizar
            // 
            this.btnActulizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(166)))), ((int)(((byte)(167)))));
            this.btnActulizar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActulizar.Location = new System.Drawing.Point(908, 351);
            this.btnActulizar.Name = "btnActulizar";
            this.btnActulizar.Size = new System.Drawing.Size(125, 35);
            this.btnActulizar.TabIndex = 5;
            this.btnActulizar.Text = "Actulizar";
            this.btnActulizar.UseVisualStyleBackColor = false;
            this.btnActulizar.Click += new System.EventHandler(this.btnActulizar_Click);
            this.btnActulizar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnActulizar_KeyPress);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(166)))), ((int)(((byte)(167)))));
            this.btnEliminar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(908, 411);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(125, 35);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnEliminar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnEliminar_KeyPress);
            // 
            // dtgProveedor
            // 
            this.dtgProveedor.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dtgProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProveedor.Location = new System.Drawing.Point(85, 163);
            this.dtgProveedor.Name = "dtgProveedor";
            this.dtgProveedor.RowHeadersWidth = 51;
            this.dtgProveedor.RowTemplate.Height = 24;
            this.dtgProveedor.Size = new System.Drawing.Size(773, 377);
            this.dtgProveedor.TabIndex = 12;
            this.dtgProveedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProveedor_CellClick);
            this.dtgProveedor.SelectionChanged += new System.EventHandler(this.dtgProveedor_SelectionChanged);
            // 
            // btnPrimerRegistro
            // 
            this.btnPrimerRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(166)))), ((int)(((byte)(167)))));
            this.btnPrimerRegistro.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimerRegistro.Location = new System.Drawing.Point(1061, 229);
            this.btnPrimerRegistro.Name = "btnPrimerRegistro";
            this.btnPrimerRegistro.Size = new System.Drawing.Size(157, 39);
            this.btnPrimerRegistro.TabIndex = 7;
            this.btnPrimerRegistro.Text = "Primer Registro";
            this.btnPrimerRegistro.UseVisualStyleBackColor = false;
            this.btnPrimerRegistro.Click += new System.EventHandler(this.btnPrimerRegistro_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(166)))), ((int)(((byte)(167)))));
            this.btnSiguiente.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(1061, 289);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(157, 39);
            this.btnSiguiente.TabIndex = 8;
            this.btnSiguiente.Text = "Siguiente Registro";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(166)))), ((int)(((byte)(167)))));
            this.btnAnterior.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(1061, 349);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(157, 39);
            this.btnAnterior.TabIndex = 9;
            this.btnAnterior.Text = "Anterior Registro";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnUltimoRegistro
            // 
            this.btnUltimoRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(166)))), ((int)(((byte)(167)))));
            this.btnUltimoRegistro.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoRegistro.Location = new System.Drawing.Point(1061, 409);
            this.btnUltimoRegistro.Name = "btnUltimoRegistro";
            this.btnUltimoRegistro.Size = new System.Drawing.Size(157, 39);
            this.btnUltimoRegistro.TabIndex = 10;
            this.btnUltimoRegistro.Text = "Ultimo Registro";
            this.btnUltimoRegistro.UseVisualStyleBackColor = false;
            this.btnUltimoRegistro.Click += new System.EventHandler(this.btnUltimoRegistro_Click);
            // 
            // lblProveedores
            // 
            this.lblProveedores.AutoSize = true;
            this.lblProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(203)))), ((int)(((byte)(208)))));
            this.lblProveedores.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.lblProveedores.Location = new System.Drawing.Point(12, 9);
            this.lblProveedores.Name = "lblProveedores";
            this.lblProveedores.Size = new System.Drawing.Size(1162, 50);
            this.lblProveedores.TabIndex = 17;
            this.lblProveedores.Text = "                                                   Proveedor                     " +
    "                                    ";
            // 
            // FrmMaestraProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1261, 560);
            this.Controls.Add(this.lblProveedores);
            this.Controls.Add(this.btnUltimoRegistro);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnPrimerRegistro);
            this.Controls.Add(this.dtgProveedor);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActulizar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnAgregarProovedor);
            this.Controls.Add(this.txtCorreoEmpresa);
            this.Controls.Add(this.lblCorreoEmpresa);
            this.Controls.Add(this.txtNombreEmpresa);
            this.Controls.Add(this.lblTelefonoEmpresa);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblNombreEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMaestraProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maestra Proveedor  ";
            this.Load += new System.EventHandler(this.FrmMaestraProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblNombreEmpresa;
        private System.Windows.Forms.TextBox txtNombreEmpresa;
        private System.Windows.Forms.Label lblTelefonoEmpresa;
        private System.Windows.Forms.TextBox txtCorreoEmpresa;
        private System.Windows.Forms.Label lblCorreoEmpresa;
        private System.Windows.Forms.Button btnAgregarProovedor;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnActulizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dtgProveedor;
        private System.Windows.Forms.Button btnPrimerRegistro;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnUltimoRegistro;
        private System.Windows.Forms.Label lblProveedores;
    }
}