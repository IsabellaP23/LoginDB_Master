namespace LoginV1
{
    partial class FrmDetalleVentas
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
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.dtgCompras = new System.Windows.Forms.DataGridView();
            this.lblCompras = new System.Windows.Forms.Label();
            this.dtgDetalleCompras = new System.Windows.Forms.DataGridView();
            this.dtgAbonos = new System.Windows.Forms.DataGridView();
            this.lblDetalleCompra = new System.Windows.Forms.Label();
            this.lblAbonos = new System.Windows.Forms.Label();
            this.grpAgregarAbono = new System.Windows.Forms.GroupBox();
            this.lblMontoAbonos = new System.Windows.Forms.Label();
            this.txtMontoAbono = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechaAbono = new System.Windows.Forms.DateTimePicker();
            this.btnAgregarAbono = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProveedores = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalleCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAbonos)).BeginInit();
            this.grpAgregarAbono.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbClientes
            // 
            this.cbClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(203)))), ((int)(((byte)(208)))));
            this.cbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientes.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.IntegralHeight = false;
            this.cbClientes.Location = new System.Drawing.Point(684, 154);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(271, 32);
            this.cbClientes.TabIndex = 0;
            this.cbClientes.SelectedIndexChanged += new System.EventHandler(this.cbClientes_SelectedIndexChanged);
            // 
            // dtgCompras
            // 
            this.dtgCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCompras.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dtgCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCompras.Location = new System.Drawing.Point(12, 124);
            this.dtgCompras.Name = "dtgCompras";
            this.dtgCompras.ReadOnly = true;
            this.dtgCompras.RowHeadersWidth = 51;
            this.dtgCompras.RowTemplate.Height = 24;
            this.dtgCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCompras.Size = new System.Drawing.Size(558, 158);
            this.dtgCompras.TabIndex = 1;
            this.dtgCompras.TabStop = false;
            this.dtgCompras.SelectionChanged += new System.EventHandler(this.dtgCompras_SelectionChanged);
            // 
            // lblCompras
            // 
            this.lblCompras.AutoSize = true;
            this.lblCompras.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompras.ForeColor = System.Drawing.Color.Black;
            this.lblCompras.Location = new System.Drawing.Point(7, 94);
            this.lblCompras.Name = "lblCompras";
            this.lblCompras.Size = new System.Drawing.Size(195, 27);
            this.lblCompras.TabIndex = 2;
            this.lblCompras.Text = "Compras Realizadas";
            // 
            // dtgDetalleCompras
            // 
            this.dtgDetalleCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDetalleCompras.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dtgDetalleCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetalleCompras.Location = new System.Drawing.Point(12, 335);
            this.dtgDetalleCompras.Name = "dtgDetalleCompras";
            this.dtgDetalleCompras.ReadOnly = true;
            this.dtgDetalleCompras.RowHeadersWidth = 51;
            this.dtgDetalleCompras.RowTemplate.Height = 24;
            this.dtgDetalleCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDetalleCompras.Size = new System.Drawing.Size(558, 159);
            this.dtgDetalleCompras.TabIndex = 3;
            this.dtgDetalleCompras.TabStop = false;
            // 
            // dtgAbonos
            // 
            this.dtgAbonos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgAbonos.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dtgAbonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAbonos.Location = new System.Drawing.Point(12, 551);
            this.dtgAbonos.Name = "dtgAbonos";
            this.dtgAbonos.ReadOnly = true;
            this.dtgAbonos.RowHeadersWidth = 51;
            this.dtgAbonos.RowTemplate.Height = 24;
            this.dtgAbonos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAbonos.Size = new System.Drawing.Size(558, 155);
            this.dtgAbonos.TabIndex = 4;
            this.dtgAbonos.TabStop = false;
            // 
            // lblDetalleCompra
            // 
            this.lblDetalleCompra.AutoSize = true;
            this.lblDetalleCompra.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleCompra.ForeColor = System.Drawing.Color.Black;
            this.lblDetalleCompra.Location = new System.Drawing.Point(12, 305);
            this.lblDetalleCompra.Name = "lblDetalleCompra";
            this.lblDetalleCompra.Size = new System.Drawing.Size(182, 27);
            this.lblDetalleCompra.TabIndex = 5;
            this.lblDetalleCompra.Text = "Detalle de Compra";
            // 
            // lblAbonos
            // 
            this.lblAbonos.AutoSize = true;
            this.lblAbonos.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbonos.ForeColor = System.Drawing.Color.Black;
            this.lblAbonos.Location = new System.Drawing.Point(12, 521);
            this.lblAbonos.Name = "lblAbonos";
            this.lblAbonos.Size = new System.Drawing.Size(88, 27);
            this.lblAbonos.TabIndex = 6;
            this.lblAbonos.Text = "Abonos:";
            // 
            // grpAgregarAbono
            // 
            this.grpAgregarAbono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(203)))), ((int)(((byte)(208)))));
            this.grpAgregarAbono.Controls.Add(this.btnAgregarAbono);
            this.grpAgregarAbono.Controls.Add(this.dtpFechaAbono);
            this.grpAgregarAbono.Controls.Add(this.lblFecha);
            this.grpAgregarAbono.Controls.Add(this.txtMontoAbono);
            this.grpAgregarAbono.Controls.Add(this.lblMontoAbonos);
            this.grpAgregarAbono.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAgregarAbono.Location = new System.Drawing.Point(647, 544);
            this.grpAgregarAbono.Name = "grpAgregarAbono";
            this.grpAgregarAbono.Size = new System.Drawing.Size(435, 150);
            this.grpAgregarAbono.TabIndex = 7;
            this.grpAgregarAbono.TabStop = false;
            this.grpAgregarAbono.Text = "Agregar un Nuevo Abono";
            // 
            // lblMontoAbonos
            // 
            this.lblMontoAbonos.AutoSize = true;
            this.lblMontoAbonos.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoAbonos.ForeColor = System.Drawing.Color.Black;
            this.lblMontoAbonos.Location = new System.Drawing.Point(6, 39);
            this.lblMontoAbonos.Name = "lblMontoAbonos";
            this.lblMontoAbonos.Size = new System.Drawing.Size(152, 24);
            this.lblMontoAbonos.TabIndex = 8;
            this.lblMontoAbonos.Text = "Monto del Abono:";
            // 
            // txtMontoAbono
            // 
            this.txtMontoAbono.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoAbono.Location = new System.Drawing.Point(6, 66);
            this.txtMontoAbono.Name = "txtMontoAbono";
            this.txtMontoAbono.Size = new System.Drawing.Size(226, 30);
            this.txtMontoAbono.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(260, 39);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(145, 24);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "Fecha del Abono:";
            // 
            // dtpFechaAbono
            // 
            this.dtpFechaAbono.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaAbono.Location = new System.Drawing.Point(264, 66);
            this.dtpFechaAbono.Name = "dtpFechaAbono";
            this.dtpFechaAbono.Size = new System.Drawing.Size(144, 30);
            this.dtpFechaAbono.TabIndex = 2;
            // 
            // btnAgregarAbono
            // 
            this.btnAgregarAbono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(166)))), ((int)(((byte)(167)))));
            this.btnAgregarAbono.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAbono.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarAbono.Location = new System.Drawing.Point(157, 102);
            this.btnAgregarAbono.Name = "btnAgregarAbono";
            this.btnAgregarAbono.Size = new System.Drawing.Size(143, 38);
            this.btnAgregarAbono.TabIndex = 3;
            this.btnAgregarAbono.Text = "Agregar Abono";
            this.btnAgregarAbono.UseVisualStyleBackColor = false;
            this.btnAgregarAbono.Click += new System.EventHandler(this.btnAgregarAbono_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(679, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Seleccione un cliente";
            // 
            // lblProveedores
            // 
            this.lblProveedores.AutoSize = true;
            this.lblProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(203)))), ((int)(((byte)(208)))));
            this.lblProveedores.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.lblProveedores.Location = new System.Drawing.Point(8, 9);
            this.lblProveedores.Name = "lblProveedores";
            this.lblProveedores.Size = new System.Drawing.Size(1168, 50);
            this.lblProveedores.TabIndex = 18;
            this.lblProveedores.Text = "                                                Detalle de Ventas                " +
    "                                ";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(166)))), ((int)(((byte)(167)))));
            this.btnVolver.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.Black;
            this.btnVolver.Location = new System.Drawing.Point(1088, 668);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(97, 38);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmDetalleVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 718);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblProveedores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpAgregarAbono);
            this.Controls.Add(this.lblAbonos);
            this.Controls.Add(this.lblDetalleCompra);
            this.Controls.Add(this.dtgAbonos);
            this.Controls.Add(this.dtgDetalleCompras);
            this.Controls.Add(this.lblCompras);
            this.Controls.Add(this.dtgCompras);
            this.Controls.Add(this.cbClientes);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.Name = "FrmDetalleVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalleCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAbonos)).EndInit();
            this.grpAgregarAbono.ResumeLayout(false);
            this.grpAgregarAbono.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.DataGridView dtgCompras;
        private System.Windows.Forms.Label lblCompras;
        private System.Windows.Forms.DataGridView dtgDetalleCompras;
        private System.Windows.Forms.DataGridView dtgAbonos;
        private System.Windows.Forms.Label lblDetalleCompra;
        private System.Windows.Forms.Label lblAbonos;
        private System.Windows.Forms.GroupBox grpAgregarAbono;
        private System.Windows.Forms.Label lblMontoAbonos;
        private System.Windows.Forms.Button btnAgregarAbono;
        private System.Windows.Forms.DateTimePicker dtpFechaAbono;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtMontoAbono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProveedores;
        private System.Windows.Forms.Button btnVolver;
    }
}