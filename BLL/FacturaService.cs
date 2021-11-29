using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
using System.Data.SqlClient;


namespace BLL
{
    public class FacturaService
    {
        SqlConnection Conexion;
        IList<Factura> ListaFacturas;
        RepositoryFactura repositoryFactura;
        RepositoryMedicamento repositoryMedicamento;

        public FacturaService()
        {
            Conexion = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bdmtnz\Documents\Desktop\FarmaPunto\DAL\DatosProyecto.mdf;Integrated Security=True");
            repositoryFactura = new RepositoryFactura(Conexion);
            repositoryMedicamento = new RepositoryMedicamento(Conexion);
        }

        public IList<Factura> ConsultarFactura()
        {
            Conexion.Open();
            try
            {
                ListaFacturas = new List<Factura>();
                ListaFacturas = repositoryFactura.ConsulatrFacturas();
            }
            catch (Exception E)
            {
                
            }
            finally { Conexion.Close(); }
            return (ListaFacturas);
        }

        public IList<ProductoReporte> ConsultarReporte()
        {
            var Reportes = new List<ProductoReporte>();
            Conexion.Open();
            try
            {
                Reportes = new List<ProductoReporte>();
                Reportes = repositoryFactura.Reporte().ToList();
            }
            catch (Exception e)
            {

            }
            finally { Conexion.Close(); }
            return Reportes;
        }

        public IList<Factura> ConsultarFacturacodigo(string codigo)
        {
            Conexion.Open();
            try
            {
                ListaFacturas = new List<Factura>();
                ListaFacturas = repositoryFactura.ConsulatrCodigo(codigo);
            }
            catch (Exception)
            {
                
            }
            finally { Conexion.Close(); }

            return (ListaFacturas);
        }

        public IList<Factura> ConsultarFacturFecha(string desde,string hasta)
        {
            Conexion.Open();
           
                //DateTime.Now.ToShortDateString();
                
                ListaFacturas = new List<Factura>();
                ListaFacturas = repositoryFactura.ConsulatFecha(desde,hasta);
            
           
            Conexion.Close();

            return (ListaFacturas);
        }

        public Factura BuscarFactura(string codigo)
        {
            Conexion.Open();
            Factura factura = new Factura();
            try
            {   
                factura.CodigoFactura = codigo;
                factura = repositoryFactura.BuscarFactura(factura);
            }
            catch (Exception)
            {

                throw;
            }
          
            return factura;
        }

        public string GuardarFactura(Factura factura, List<DetalleFactura> Detalles)
        {
            if(Detalles.Count <= 0)
            {
                return "No hay productos para facturar";

            }
            
            foreach (var x in Detalles)

            {
                Conexion.Open();
                var medicamento = repositoryMedicamento.BuscarMedicamentos(new Medicamentos()
                {
                    CodigoMedicamento = x.IdeMedicamento
                });
                Conexion.Close();
                if (medicamento == null)
                {
                   return "el medicamento no existe";
                }
            }
            try
            {
                Conexion.Open();
                repositoryFactura.GuardarFactura(factura);
                Detalles.ForEach(
                    x => repositoryFactura.GuardarDetalle(x)
                );
                Conexion.Close();
                return "Se Registro La factura " + factura.CodigoFactura;

            }
            catch (Exception e)
            {
                Conexion.Close();
                return "Error de base de datos: " + e.Message.ToString();
            }
        }

        public string EliminarMedicamento(Factura factura)
        {
            Conexion.Open();
            try
            {
                if (repositoryFactura.BuscarFactura(factura) != null)
                {
                    factura = (repositoryFactura.BuscarFactura(factura));
                    repositoryFactura.Eliminar(factura);
                    Conexion.Close();
                    return "Se Eliminó La Factura " + factura.CodigoFactura + "Correctamente";
                }
                else
                {
                    Conexion.Close();
                    return "La Factura Con Ese Codigo No Existe";
                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }
        public void GuardarContador(decimal dato)
        {
            repositoryFactura.GuardarContador(dato);
        }

        public decimal consultarContador() {
            return repositoryFactura.ConsultarContador();
        }

        public CalcularTotal Calcular(string codigo)
        {
            CalcularTotal total = new CalcularTotal();
            foreach (var item in ConsultarFacturacodigo(codigo))
            {
                if (item.CodigoFactura == codigo)
                {
                    total.TotalCodigo += item.TotalParcial;
                }
            }
            
            return (total);
        }


        public string Eliminar( )
        {
            Conexion.Open();
           
                repositoryFactura.eliminar();
                Conexion.Close();
                return "Se eliminó ";
        }
    }
}