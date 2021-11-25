using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class ProveedorService
    {
        SqlConnection Conexion;
        IList<Proveedor> LitaProveedores;
        RepositoryProveedor repositoryProveedor;

        public ProveedorService()
        {
            Conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\FarmaPunto(copia)\DAL\DatosProyecto.mdf;Integrated Security=True");
            repositoryProveedor = new RepositoryProveedor(Conexion);
        }
        public IList<Proveedor> ConsultarProveedor()
        {
            Conexion.Open();
            LitaProveedores = new List<Proveedor>();
            LitaProveedores = repositoryProveedor.ConsultarProveedor();
            Conexion.Close();
            return (LitaProveedores);
        }

        public Proveedor BuscarProveedor(string codigo)
        {
            Conexion.Open();
            Proveedor proveedor = new Proveedor();
            proveedor.Nit = codigo;
            proveedor = repositoryProveedor.BuscarProveedor(proveedor);
            Conexion.Close();
            return proveedor;
        }

        public string GuardarProveedor(Proveedor proveedor)
        {
            try
            {
                Conexion.Open();
                repositoryProveedor.GuardarProveedor(proveedor);
                Conexion.Close();
                return "se registro el Proveedor " + proveedor.NombreEmpresa;
            }
            catch (Exception e)
            {
                Conexion.Close();
                return "Error de base de datos: " + e.Message.ToString();

            }
        }

        public string EliminarProveedor(Proveedor proveedor)
        {
            Conexion.Open();
            if (repositoryProveedor.BuscarProveedor(proveedor) != null)
            {
                proveedor = (repositoryProveedor.BuscarProveedor(proveedor));
                repositoryProveedor.EliminarProveedor(proveedor);
                Conexion.Close();
                return "Se eliminó al Proveedor " + proveedor.NombreEmpresa + " correctamente";
            }
            else
            {
                Conexion.Close();
                return "El Proveedor con ese codigo no existe";
            }

        }

        public string ModificarProveedor(Proveedor proveedor)
        {
            Conexion.Open();
            string respuesta;
            respuesta = repositoryProveedor.ModificarProveedor(proveedor);
            Conexion.Close();
            return respuesta;
        }
    }
}
