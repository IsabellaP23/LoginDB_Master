namespace LoginV1
{
    partial class frmBienvenido
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
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnRol = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.btnCompras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
<<<<<<< Updated upstream
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(166, 9);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(500, 91);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "Bienvenido :)";
=======
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(166)))), ((int)(((byte)(167)))));
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnProveedores.Location = new System.Drawing.Point(203, 426);
            this.btnProveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(189, 50);
            this.btnProveedores.TabIndex = 3;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = false;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(166)))), ((int)(((byte)(167)))));
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnClientes.Location = new System.Drawing.Point(584, 266);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(192, 50);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProducto
            // 
            this.btnProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(166)))), ((int)(((byte)(167)))));
            this.btnProducto.FlatAppearance.BorderSize = 0;
            this.btnProducto.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnProducto.Location = new System.Drawing.Point(203, 266);
            this.btnProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(189, 50);
            this.btnProducto.TabIndex = 0;
            this.btnProducto.Text = "Productos";
            this.btnProducto.UseVisualStyleBackColor = false;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btnRol
            // 
            this.btnRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(166)))), ((int)(((byte)(167)))));
            this.btnRol.FlatAppearance.BorderSize = 0;
            this.btnRol.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnRol.Location = new System.Drawing.Point(584, 426);
            this.btnRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRol.Name = "btnRol";
            this.btnRol.Size = new System.Drawing.Size(192, 50);
            this.btnRol.TabIndex = 4;
            this.btnRol.Text = "Roles";
            this.btnRol.UseVisualStyleBackColor = false;
            this.btnRol.Click += new System.EventHandler(this.btnRol_Click_1);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.lblUser.Location = new System.Drawing.Point(400, 133);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(184, 60);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "Usuario";
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(203)))), ((int)(((byte)(208)))));
            this.lblBienvenido.Font = new System.Drawing.Font("Palatino Linotype", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.lblBienvenido.Location = new System.Drawing.Point(12, 9);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(934, 107);
            this.lblBienvenido.TabIndex = 5;
            this.lblBienvenido.Text = "           Bienvenido :)          ";
>>>>>>> Stashed changes
            // 
            // lblUser
            // 
<<<<<<< Updated upstream
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.lblUser.Location = new System.Drawing.Point(300, 108);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(145, 47);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "Usuario";
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(203)))), ((int)(((byte)(208)))));
            this.lblBienvenido.Font = new System.Drawing.Font("Palatino Linotype", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.lblBienvenido.Location = new System.Drawing.Point(9, 7);
            this.lblBienvenido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(748, 86);
            this.lblBienvenido.TabIndex = 5;
            this.lblBienvenido.Text = "           Bienvenido :)          ";
            // 
            // btnCompras
            // 
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Location = new System.Drawing.Point(568, 290);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(148, 44);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // frmBienvenido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnProducto);
            this.Controls.Add(this.btnRol);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblBienvenido);
            this.Name = "frmBienvenido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBienvenido";
            this.Load += new System.EventHandler(this.frmBienvenido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btnRol;
        public System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnCompras;
    }
}