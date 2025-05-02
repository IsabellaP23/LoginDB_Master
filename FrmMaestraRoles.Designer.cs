namespace LoginV1
{
    partial class FrmMaestraRoles
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
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblRoles = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.cbRolID = new System.Windows.Forms.ComboBox();
            this.btnUltimoRegistro = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnPrimerRegistro = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblRol = new System.Windows.Forms.Label();
            this.ClmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmContraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmRoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(300, 124);
            this.lblpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(115, 27);
            this.lblpassword.TabIndex = 23;
            this.lblpassword.Text = "Contraseña";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(49, 124);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(195, 27);
            this.lblNombreUsuario.TabIndex = 21;
            this.lblNombreUsuario.Text = "Nombre De Usuario";
            // 
            // lblRoles
            // 
            this.lblRoles.AutoSize = true;
            this.lblRoles.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoles.Location = new System.Drawing.Point(522, 124);
            this.lblRoles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoles.Name = "lblRoles";
            this.lblRoles.Size = new System.Drawing.Size(42, 27);
            this.lblRoles.TabIndex = 20;
            this.lblRoles.Text = "Rol";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmNombre,
            this.ClmContraseña,
            this.ClmRoles});
            this.dgvUsuarios.Location = new System.Drawing.Point(54, 198);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.Size = new System.Drawing.Size(666, 304);
            this.dgvUsuarios.TabIndex = 19;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(305, 160);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(185, 22);
            this.txtContraseña.TabIndex = 1;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(54, 160);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(208, 22);
            this.txtNombreUsuario.TabIndex = 0;
            // 
            // cbRolID
            // 
            this.cbRolID.FormattingEnabled = true;
            this.cbRolID.Location = new System.Drawing.Point(527, 160);
            this.cbRolID.Margin = new System.Windows.Forms.Padding(4);
            this.cbRolID.Name = "cbRolID";
            this.cbRolID.Size = new System.Drawing.Size(193, 24);
            this.cbRolID.TabIndex = 2;
            // 
            // btnUltimoRegistro
            // 
            this.btnUltimoRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(166)))), ((int)(((byte)(167)))));
            this.btnUltimoRegistro.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoRegistro.Location = new System.Drawing.Point(935, 409);
            this.btnUltimoRegistro.Name = "btnUltimoRegistro";
            this.btnUltimoRegistro.Size = new System.Drawing.Size(157, 39);
            this.btnUltimoRegistro.TabIndex = 10;
            this.btnUltimoRegistro.Text = "Ultimo Registro";
            this.btnUltimoRegistro.UseVisualStyleBackColor = false;
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(166)))), ((int)(((byte)(167)))));
            this.btnAnterior.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(935, 353);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(157, 39);
            this.btnAnterior.TabIndex = 9;
            this.btnAnterior.Text = "Anterior Registro";
            this.btnAnterior.UseVisualStyleBackColor = false;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(166)))), ((int)(((byte)(167)))));
            this.btnSiguiente.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(935, 295);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(157, 39);
            this.btnSiguiente.TabIndex = 8;
            this.btnSiguiente.Text = "Siguiente Registro";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            // 
            // btnPrimerRegistro
            // 
            this.btnPrimerRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(166)))), ((int)(((byte)(167)))));
            this.btnPrimerRegistro.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimerRegistro.Location = new System.Drawing.Point(935, 238);
            this.btnPrimerRegistro.Name = "btnPrimerRegistro";
            this.btnPrimerRegistro.Size = new System.Drawing.Size(157, 39);
            this.btnPrimerRegistro.TabIndex = 7;
            this.btnPrimerRegistro.Text = "Primer Registro";
            this.btnPrimerRegistro.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(166)))), ((int)(((byte)(167)))));
            this.btnEliminar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(753, 409);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(156, 38);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(166)))), ((int)(((byte)(167)))));
            this.btnActualizar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(753, 353);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(156, 38);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(166)))), ((int)(((byte)(167)))));
            this.btnConsultar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(753, 295);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(156, 38);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(166)))), ((int)(((byte)(167)))));
            this.btnAgregar.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(753, 239);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(156, 38);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(203)))), ((int)(((byte)(208)))));
            this.lblRol.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.lblRol.Location = new System.Drawing.Point(5, 9);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(1104, 50);
            this.lblRol.TabIndex = 32;
            this.lblRol.Text = "                                                         Rol                     " +
    "                                    ";
            // 
            // ClmNombre
            // 
            this.ClmNombre.HeaderText = "Nombre";
            this.ClmNombre.MinimumWidth = 6;
            this.ClmNombre.Name = "ClmNombre";
            this.ClmNombre.Width = 125;
            // 
            // ClmContraseña
            // 
            this.ClmContraseña.HeaderText = "Contraseña";
            this.ClmContraseña.MinimumWidth = 6;
            this.ClmContraseña.Name = "ClmContraseña";
            this.ClmContraseña.Width = 125;
            // 
            // ClmRoles
            // 
            this.ClmRoles.HeaderText = "Rol";
            this.ClmRoles.MinimumWidth = 6;
            this.ClmRoles.Name = "ClmRoles";
            this.ClmRoles.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClmRoles.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ClmRoles.Width = 125;
            // 
            // FrmMaestraRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1117, 557);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.btnUltimoRegistro);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnPrimerRegistro);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.lblRoles);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.cbRolID);
            this.Name = "FrmMaestraRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maestra Rol";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblRoles;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.ComboBox cbRolID;
        private System.Windows.Forms.Button btnUltimoRegistro;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnPrimerRegistro;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmContraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmRoles;
    }
}