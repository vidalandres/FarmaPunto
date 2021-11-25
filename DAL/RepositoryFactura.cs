using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entity;
using System.Data;
using System.IO;


namespace DAL
{
    public class RepositoryFactura
    {
        private SqlConnection Conexion;
        private SqlDataReader Reader;
        private SqlCommand Comando;
        private IList<Factura> ListaFacturas;
        string DIRECCIONARCHIVO = (@"E:\FarmaPunto(copia)\Archivo\ArchivoContador.txt");
        public RepositoryFactura(SqlConnection connection)
        {
            Conexion = connection;
        }

        public void GuardarContador(decimal dato)
        {
            FileStream SoucerStream = new FileStream(DIRECCIONARCHIVO, FileMode.Append);
            StreamWriter writer = new StreamWriter(SoucerStream);
            writer.WriteLine(""+dato);
            writer.Close();
            SoucerStream.Close();
        }

        public decimal ConsultarContador()
        {
            decimal dato=0;
            FileStream SoucerStream = new FileStream(DIRECCIONARCHIVO, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader Reader = new StreamReader(SoucerStream);

            string Linea = string.Empty; // es igual a string Linea="";

            while ((Linea = Reader.ReadLine()) != null)
            {

                dato = Convert.ToDecimal(Linea.Trim());
            }
            Reader.Close();
            SoucerStream.Close();
            return dato;
        }

        public void GuardarFactura(Factura factura)
        {
            using (Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "insert into TablaFactura(CodigoFactura,Codigo,Producto,Unidades,Iva,TotalParcial,Fecha) values (@CodigoFactura,@Codigo,@Producto,@Unidades,@Iva,@TotalParcial,@Fecha)";
                Comando.Parameters.Add("@CodigoFactura", SqlDbType.VarChar).Value = factura.CodigoFactura;
                Comando.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = factura.Codigo;
                Comando.Parameters.Add("@Producto", SqlDbType.VarChar).Value = factura.Producto;
                Comando.Parameters.Add("@Unidades", SqlDbType.Int).Value = factura.Unidades;
                Comando.Parameters.Add("@Iva", SqlDbType.Decimal).Value = factura.Iva;
                Comando.Parameters.Add("@TotalParcial", SqlDbType.Decimal).Value = factura.TotalParcial;
                Comando.Parameters.Add("@Fecha", SqlDbType.Date).Value = factura.Fecha;
                Comando.ExecuteNonQuery();
            }
        }

        private Factura MapeoFactura(SqlDataReader reader)
        {
            Factura factura = new Factura();
            factura.CodigoFactura = (string)reader["CodigoFactura"];
            factura.Codigo = (string)reader["Codigo"];
            factura.Producto = (string)reader["Producto"];
            factura.Unidades = (int)reader["Unidades"];
            factura.Iva = (decimal)reader["Iva"];
            factura.TotalParcial = (decimal)reader["TotalParcial"];
            DateTime dateTime = (DateTime)reader["Fecha"];
            factura.Fecha = dateTime.ToShortDateString();
            return factura;
        }

        public IList<Factura> ConsulatrFacturas()
        {
            ListaFacturas = new List<Factura>();
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Select * from TablaFactura";
                Reader = Comando.ExecuteReader();
                while (Reader.Read())
                {
                    Factura factura = new Factura();
                    factura = MapeoFactura(Reader);
                    ListaFacturas.Add(factura);
                }
                Reader.Close();
            }
            return ListaFacturas;
        }


        public void eliminar()
        {
          
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "delete from TablaFactura";
                Comando.ExecuteNonQuery();
            }

        }

        public IList<Factura> ConsulatrCodigo(string codigo)
        {

            ListaFacturas = new List<Factura>();
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Select CodigoFactura,Codigo,Producto,Unidades,Iva,TotalParcial,Fecha from TablaFactura where CodigoFactura=@CodigoFactura ";
                Comando.Parameters.Add(@"CodigoFactura", System.Data.SqlDbType.VarChar).Value = codigo;
                Reader = Comando.ExecuteReader();
                while (Reader.Read())
                {
                    Factura factura = new Factura();
                    factura = MapeoFactura(Reader);
                    ListaFacturas.Add(factura);
                }
                Reader.Close();
            }
            return ListaFacturas;

        }


        public void Eliminar(Factura factura)
        {
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "delete from TablaFactura where CodigoFactura=@CodigoFactura";
                Comando.Parameters.Add("@CodigoFactura", SqlDbType.VarChar).Value = factura.CodigoFactura;
                Comando.ExecuteNonQuery();
            }
        }


        public Factura BuscarFactura(Factura factura)
        {
            ConsulatrFacturas();
            foreach (Factura item in ListaFacturas)
            {
                if (EsEncontrado(item, factura))
                {
                    return item;
                }
            }
            return null;
        }

        private bool EsEncontrado(Factura item, Factura factura)
        {
            return item.CodigoFactura== factura.CodigoFactura;
        }

        // 

        public IList<Factura> ConsulatFecha(string desde,string hasta)
        {
//            desde= DateTime.Now.ToShortDateString();
//            hasta= DateTime.Now.ToShortDateString();

            ListaFacturas = new List<Factura>();
            using (var Comando = Conexion.CreateCommand())
            { 
                Comando.CommandText = "select * from TablaFactura where Fecha between @desde and @hasta";
                Comando.Parameters.Add("@desde", SqlDbType.Date).Value = desde;
                Comando.Parameters.Add("@hasta", SqlDbType.Date).Value = hasta;

                Reader = Comando.ExecuteReader();
                while (Reader.Read())
                {
                    Factura factura = new Factura();
                    factura = MapeoFactura(Reader);
                    ListaFacturas.Add(factura);
                }
                Reader.Close();
            }
            return ListaFacturas;

        }
    }
}
