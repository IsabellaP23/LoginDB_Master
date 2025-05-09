﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace LoginV1
{
    public class database
    {
        private string dbFile = "tienda.db";

        public database()
        {
            CrearBaseDeDatos();
        }

        private void CrearBaseDeDatos()
        {
            if (!File.Exists(dbFile))
            {
                SQLiteConnection.CreateFile(dbFile);
                Console.WriteLine("Base de datos creada.");
                CrearTablas();
            }

            else
            {

            }
        }

        private void CrearTablas()
        {
            using (var conexion = new SQLiteConnection($"Data Source={dbFile};Version=3;"))
            {
                conexion.Open();

                string crearTipoUsuarios = @"
                CREATE TABLE IF NOT EXISTS Tipo_Usuarios (
                    Rol_ID INTEGER PRIMARY,
                    NombreRol TEXT NOT NULL
                );";

                string crearUsuarios = @"
                CREATE TABLE IF NOT EXISTS tbUsuarios (
                    UsuarioID INTEGER PRIMARY KEY,
                    Nombre_Usuario TEXT NOT NULL,
                    Contraseña TEXT NOT NULL,
                    Rol_ID INTEGER,
                    FOREIGN KEY (Rol_ID) REFERENCES Tipo_Usuarios(Rol_ID)
                );";

                string crearProductos = @"
                CREATE TABLE IF NOT EXISTS Productos (
                    ProductoID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nombre_Producto TEXT NOT NULL,
                    Stock INTEGER NOT NULL,
                    Precio REAL NOT NULL
                );";

                string crearClientes = @"
                CREATE TABLE IF NOT EXISTS Clientes (
                    ClienteID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nombre TEXT NOT NULL,
                    Correo TEXT NOT NULL,
                    Telefono TEXT NOT NULL
                );";

                string crearVentas = @"
                CREATE TABLE IF NOT EXISTS Ventas (
                    VentaID INTEGER PRIMARY KEY AUTOINCREMENT,
                    ClienteID INTEGER,
                    ProductoID INTEGER,
                    Fecha_Venta TEXT NOT NULL,
                    Cantidad INTEGER NOT NULL,
                    Precio_Total REAL NOT NULL,
                    FOREIGN KEY (ClienteID) REFERENCES Clientes(ClienteID),
                    FOREIGN KEY (ProductoID) REFERENCES Productos(ProductoID)
                );";

                string crearProovedores = @"
                CREATE TABLE IF NOT EXISTS Proovedores (
                    EmpresaID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nombre_Empresa TEXT NOT NULL,
                    Telefono INTEGER NOT NULL,
                    Correo TEXT NOT NULL
                );";

                string insertRoles = @"
                INSERT OR IGNORE INTO Tipo_Usuarios (Rol_ID, NombreRol)
                VALUES
                    (1, 'Admin'),
                    (2, 'Almacenista'),
                    (3, 'Proveedor'),
                    (4, 'Vendedor');";

                string insertUsuario = @"
                INSERT OR IGNORE INTO tbUsuarios (UsuarioID, Nombre_Usuario, Contraseña, Rol_ID)
                VALUES
                    (1524563254, 'JulianG', '12345', 1);";

                string crearCompras = @"
                CREATE TABLE IF NOT EXISTS Compra (
                    IdCompra INTEGER PRIMARY KEY AUTOINCREMENT,
                    IdCliente INTEGER NOT NULL,
                    IdVendedor INTEGER NOT NULL,
                    Fecha TEXT NOT NULL,
                    Total REAL NOT NULL,
                    TipoPago TEXT NOT NULL,
                    FOREIGN KEY (IdCliente) REFERENCES Clientes(ClienteID),
                    FOREIGN KEY (IdVendedor) REFERENCES tbUsuarios(UsuarioID)
                );";

                string crearDetalleCompra = @"
                CREATE TABLE IF NOT EXISTS DetalleCompra (
                    IdDetalle INTEGER PRIMARY KEY AUTOINCREMENT,
                    IdCompra INTEGER NOT NULL,
                    IdProducto INTEGER NOT NULL,
                    Cantidad INTEGER NOT NULL,
                    Subtotal REAL NOT NULL,
                    FOREIGN KEY (IdCompra) REFERENCES Compra(IdCompra),
                    FOREIGN KEY (IdProducto) REFERENCES Productos(ProductoID)
                );";

                string crearAbonos = @"
                CREATE TABLE IF NOT EXISTS Abono (
                    IdAbono INTEGER PRIMARY KEY AUTOINCREMENT,
                    IdCompra INTEGER NOT NULL,
                    Fecha TEXT NOT NULL,
                    Monto REAL NOT NULL,
                    FOREIGN KEY (IdCompra) REFERENCES Compra(IdCompra)
                );";


                var comandos = new[]
                {
                    crearTipoUsuarios,
                    crearUsuarios,
                    crearProductos,
                    crearClientes,
                    crearVentas,
                    crearCompras,
                    crearProovedores,
                    crearDetalleCompra,
                    crearAbonos,
                    insertRoles,
                    insertUsuario,
                };

                foreach (var comandoSQL in comandos)
                {
                    using (var comando = new SQLiteCommand(comandoSQL, conexion))
                    {
                        comando.ExecuteNonQuery();
                    }
                }
            }
        }
        public bool VerificarCredenciales(string nombreUsuario, string contraseña)
        {
            using (var conexion = new SQLiteConnection($"Data Source={dbFile};Version=3;"))
            {
                conexion.Open();

                string consulta = "SELECT COUNT(*) FROM tbUsuarios WHERE Nombre_Usuario = @usuario AND Contraseña = @contraseña";

                using (var comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@usuario", nombreUsuario);
                    comando.Parameters.AddWithValue("@contraseña", contraseña);

                    int cantidad = Convert.ToInt32(comando.ExecuteScalar());
                    return cantidad > 0;
                }
            }
        }

        public int ObtenerRolID(string nombreUsuario)
        {
            using (var conexion = new SQLiteConnection($"Data Source={dbFile};Version=3;"))
            {
                conexion.Open();

                string consulta = "SELECT Rol_ID FROM tbUsuarios WHERE Nombre_Usuario = @usuario";

                using (var comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@usuario", nombreUsuario);

                    object resultado = comando.ExecuteScalar();
                    return resultado != null ? Convert.ToInt32(resultado) : -1;
                }
            }
        }

        public int ObtenerUsuarioID(string nombreUsuario)
        {
            using (var conexion = new SQLiteConnection($"Data Source={dbFile};Version=3;"))
            {
                conexion.Open();

                string consulta = "SELECT UsuarioID FROM tbUsuarios WHERE Nombre_Usuario = @usuario";

                using (var comando = new SQLiteCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@usuario", nombreUsuario);

                    object resultado = comando.ExecuteScalar();
                    return resultado != null ? Convert.ToInt32(resultado) : -1;
                }
            }
        }
    }
}
