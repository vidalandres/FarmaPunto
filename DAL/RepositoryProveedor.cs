using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class RepositoryProveedor
    {
        public RepositoryProveedor()
        {

        }
        private SqlConnection Conexion;
        private SqlDataReader Reader;
        private SqlCommand Comando;
        private IList<Proveedor> listaProveedores;

        public RepositoryProveedor(SqlConnection conexion)
        {
            Conexion = conexion;

        }

        public void GuardarProveedor(Proveedor proveedor)
        {
            using (Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "insert into TablaProveedores(Nit,DireccionProveedor,Telefono,NombreEmpresa,Representante,Ciudad,IdentificacionRepresentante,CelularRepresentante) values (@Nit,@DireccionProveedor,@Telefono,@NombreEmpresa,@Representante,@Ciudad,@IdentificacionRepresentante,@CelularRepresentante)";
                Comando.Parameters.Add("@Nit", SqlDbType.VarChar).Value = proveedor.Nit;
                Comando.Parameters.Add("@DireccionProveedor", SqlDbType.VarChar).Value = proveedor.DireccionProveedor;
                Comando.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = proveedor.Telefono;
                Comando.Parameters.Add("@NombreEmpresa", SqlDbType.VarChar).Value = proveedor.NombreEmpresa;
                Comando.Parameters.Add("@Representante", SqlDbType.VarChar).Value = proveedor.Representante;
                Comando.Parameters.Add("@Ciudad", SqlDbType.VarChar).Value = proveedor.Ciudad;
                Comando.Parameters.Add("@IdentificacionRepresentante", SqlDbType.BigInt).Value = proveedor.IdentificacionRepresentante;
                Comando.Parameters.Add("@CelularRepresentante", SqlDbType.VarChar).Value = proveedor.CelularRepresentante;
                Comando.ExecuteNonQuery();
            }
        }

        private Proveedor MapeoProveedor(SqlDataReader reader)
        {
            Proveedor proveedor = new Proveedor();
            proveedor.Nit = (string)reader["Nit"];
            proveedor.DireccionProveedor = (string)reader["DireccionProveedor"];
            proveedor.Telefono = (string)reader["Telefono"];
            proveedor.NombreEmpresa = (string)reader["NombreEmpresa"];
            proveedor.Representante = (string)reader["Representante"];
            proveedor.Ciudad = (string)reader["Ciudad"];
            proveedor.IdentificacionRepresentante = (long)reader["IdentificacionRepresentante"];
            proveedor.CelularRepresentante = (string)reader["CelularRepresentante"];

            return proveedor;
        }

        public IList<Proveedor> ConsultarProveedor()
        {
            listaProveedores = new List<Proveedor>();
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Select * from TablaProveedores";
                Reader = Comando.ExecuteReader();
                while (Reader.Read())
                {
                    Proveedor proveedor = new Proveedor();
                    proveedor = MapeoProveedor(Reader);
                    listaProveedores.Add(proveedor);
                }
                Reader.Close();
            }
            return listaProveedores;
        }

        public void EliminarProveedor(Proveedor proveedor)
        {

            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "delete from TablaProveedores where Nit=@Nit";
                Comando.Parameters.Add("@Nit", SqlDbType.VarChar).Value = proveedor.Nit;
                Comando.ExecuteNonQuery();
            }

        }

        public Proveedor BuscarProveedor(Proveedor proveedor)
        {
            ConsultarProveedor();
            foreach (Proveedor item in listaProveedores)
            {
                if (EsEncontrado(item, proveedor))
                {
                    return item;
                }
            }
            return null;
        }
        private bool EsEncontrado(Proveedor item, Proveedor proveedor)
        {
            return item.Nit == proveedor.Nit;
        }

        public string ModificarProveedor(Proveedor proveedor)
        {
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Update TablaProveedores set Nit=@Nit,DireccionProveedor=@DireccionProveedor,Telefono=@Telefono,NombreEmpresa=@NombreEmpresa,Representante=@Representante,Ciudad=@Ciudad,IdentificacionRepresentante=@IdentificacionRepresentante,CelularRepresentante=@CelularRepresentante where Nit=@Nit";
                Comando.Parameters.Add("@Nit", SqlDbType.VarChar).Value = proveedor.Nit;
                Comando.Parameters.Add("@DireccionProveedor", SqlDbType.VarChar).Value = proveedor.DireccionProveedor;
                Comando.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = proveedor.Telefono;
                Comando.Parameters.Add("@NombreEmpresa", SqlDbType.VarChar).Value = proveedor.NombreEmpresa;
                Comando.Parameters.Add("@Representante", SqlDbType.VarChar).Value = proveedor.Representante;
                Comando.Parameters.Add("@Ciudad", SqlDbType.VarChar).Value = proveedor.Ciudad;
                Comando.Parameters.Add("@IdentificacionRepresentante", SqlDbType.BigInt).Value = proveedor.IdentificacionRepresentante;
                Comando.Parameters.Add("@CelularRepresentante", SqlDbType.VarChar).Value = proveedor.CelularRepresentante;
                int co = Comando.ExecuteNonQuery();
                if (co == 0)
                {
                    return "No se modifico ningun Proveedor";
                }
                else
                {
                    return "Se modifico correctamente el Proveedor " + proveedor.NombreEmpresa;
                }
            }
        }
    }
}
