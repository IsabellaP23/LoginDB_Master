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
            this.lbIdmpresa = new System.Windows.Forms.Label();
            this.txtIdempresa = new System.Windows.Forms.TextBox();
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
            this.dtgDatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbIdmpresa
            // 
            this.lbIdmpresa.AutoSize = true;
            this.lbIdmpresa.Location = new System.Drawing.Point(39, 32);
            this.lbIdmpresa.Name = "lbIdmpresa";
            this.lbIdmpresa.Size = new System.Drawing.Size(178, 16);
            this.lbIdmpresa.TabIndex = 0;
            this.lbIdmpresa.Text = "Identificacion de la  empresa";
            // 
            // txtIdempresa
            // 
            this.txtIdempresa.Location = new System.Drawing.Point(42, 63);
            this.txtIdempresa.Name = "txtIdempresa";
            this.txtIdempresa.Size = new System.Drawing.Size(156, 22);
            this.txtIdempresa.TabIndex = 1;
            this.txtIdempresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdempresa_KeyPress);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(540, 63);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(156, 22);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lblNombreEmpresa
            // 
            this.lblNombreEmpresa.AutoSize = true;
            this.lblNombreEmpresa.Location = new System.Drawing.Point(283, 32);
            this.lblNombreEmpresa.Name = "lblNombreEmpresa";
            this.lblNombreEmpresa.Size = new System.Drawing.Size(59, 16);
            this.lblNombreEmpresa.TabIndex = 2;
            this.lblNombreEmpresa.Text = "Nombre ";
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.Location = new System.Drawing.Point(286, 63);
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.Size = new System.Drawing.Size(156, 22);
            this.txtNombreEmpresa.TabIndex = 3;
            this.txtNombreEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreEmpresa_KeyPress);
            // 
            // lblTelefonoEmpresa
            // 
            this.lblTelefonoEmpresa.AutoSize = true;
            this.lblTelefonoEmpresa.Location = new System.Drawing.Point(537, 32);
            this.lblTelefonoEmpresa.Name = "lblTelefonoEmpresa";
            this.lblTelefonoEmpresa.Size = new System.Drawing.Size(64, 16);
            this.lblTelefonoEmpresa.TabIndex = 4;
            this.lblTelefonoEmpresa.Text = "Telefono ";
            // 
            // txtCorreoEmpresa
            // 
            this.txtCorreoEmpresa.Location = new System.Drawing.Point(769, 63);
            this.txtCorreoEmpresa.Name = "txtCorreoEmpresa";
            this.txtCorreoEmpresa.Size = new System.Drawing.Size(156, 22);
            this.txtCorreoEmpresa.TabIndex = 7;
            this.txtCorreoEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreoEmpresa_KeyPress);
            // 
            // lblCorreoEmpresa
            // 
            this.lblCorreoEmpresa.AutoSize = true;
            this.lblCorreoEmpresa.Location = new System.Drawing.Point(766, 32);
            this.lblCorreoEmpresa.Name = "lblCorreoEmpresa";
            this.lblCorreoEmpresa.Size = new System.Drawing.Size(48, 16);
            this.lblCorreoEmpresa.TabIndex = 6;
            this.lblCorreoEmpresa.Text = "Correo";
            // 
            // btnAgregarProovedor
            // 
            this.btnAgregarProovedor.Location = new System.Drawing.Point(1117, 25);
            this.btnAgregarProovedor.Name = "btnAgregarProovedor";
            this.btnAgregarProovedor.Size = new System.Drawing.Size(88, 35);
            this.btnAgregarProovedor.TabIndex = 8;
            this.btnAgregarProovedor.Text = "Agregar";
            this.btnAgregarProovedor.UseVisualStyleBackColor = true;
            this.btnAgregarProovedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnAgregarProovedor_KeyPress);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(1117, 77);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(88, 35);
            this.btnConsultar.TabIndex = 9;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnConsultar_KeyPress);
            // 
            // btnActulizar
            // 
            this.btnActulizar.Location = new System.Drawing.Point(1117, 133);
            this.btnActulizar.Name = "btnActulizar";
            this.btnActulizar.Size = new System.Drawing.Size(88, 35);
            this.btnActulizar.TabIndex = 10;
            this.btnActulizar.Text = "Actulizar";
            this.btnActulizar.UseVisualStyleBackColor = true;
            this.btnActulizar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnActulizar_KeyPress);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(1117, 190);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 35);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnEliminar_KeyPress);
            // 
            // dtgDatos
            // 
            this.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatos.Location = new System.Drawing.Point(42, 231);
            this.dtgDatos.Name = "dtgDatos";
            this.dtgDatos.RowHeadersWidth = 51;
            this.dtgDatos.RowTemplate.Height = 24;
            this.dtgDatos.Size = new System.Drawing.Size(1163, 279);
            this.dtgDatos.TabIndex = 12;
            // 
            // FrmMaestraProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 528);
            this.Controls.Add(this.dtgDatos);
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
            this.Controls.Add(this.txtIdempresa);
            this.Controls.Add(this.lbIdmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMaestraProveedores";
            this.Text = "FrmMaestraProveedores";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIdmpresa;
        private System.Windows.Forms.TextBox txtIdempresa;
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
        private System.Windows.Forms.DataGridView dtgDatos;
    }
}