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
    public class RepositoryMedicamento
    {
        public RepositoryMedicamento()
        {

        }

        private SqlConnection Conexion;
        private SqlDataReader Reader;
        private SqlCommand Comando;
        private IList<Medicamentos> ListaMedicamntos;
        public RepositoryMedicamento(SqlConnection conexion)
        {
            Conexion = conexion;
        }

        public void GuardarMedicamnetos(Medicamentos medicamento)
        {
            using (Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "insert into TablaMedicamentos(CodigoMedicamento,NombreMedicamento,Cantidad,ValorUnitario,Detalle,Proveedor,Impuesto,Iva,PrecioVenta) values (@CodigoMedicamento,@NombreMedicamento,@Cantidad,@ValorUnitario,@Detalle,@Proveedor,@Impuesto,@Iva,@PrecioVenta)";
                Comando.Parameters.Add("@CodigoMedicamento", SqlDbType.VarChar).Value = medicamento.CodigoMedicamento;
                Comando.Parameters.Add("@NombreMedicamento", SqlDbType.VarChar).Value = medicamento.NombreMedicamento;
                Comando.Parameters.Add("@Cantidad", SqlDbType.Int).Value = medicamento.Cantidad;
                Comando.Parameters.Add("@ValorUnitario", SqlDbType.Decimal).Value = medicamento.ValorUnitario;
                Comando.Parameters.Add("@Detalle", SqlDbType.VarChar).Value = medicamento.Detalle;
                Comando.Parameters.Add("@Proveedor", SqlDbType.VarChar).Value = medicamento.Proveedor;
                Comando.Parameters.Add("@Impuesto", SqlDbType.Decimal).Value = medicamento.Impuesto;
                Comando.Parameters.Add("@Iva", SqlDbType.Decimal).Value = medicamento.Iva;
                Comando.Parameters.Add("@PrecioVenta", SqlDbType.Decimal).Value = medicamento.PrecioVenta;
                Comando.ExecuteNonQuery();
            }
        }

        private Medicamentos MapeoMedicamentos(SqlDataReader reader)
        {
            Medicamentos medicamento = new Medicamentos();
            medicamento.CodigoMedicamento = (string)reader["CodigoMedicamento"];
            medicamento.NombreMedicamento = (string)reader["NombreMedicamento"];
            medicamento.Cantidad = (int)reader["Cantidad"];
            medicamento.ValorUnitario = (decimal)reader["ValorUnitario"];
            medicamento.Detalle = (string)reader["Detalle"];
            medicamento.Proveedor = (string)reader["Proveedor"];
            medicamento.Impuesto = (decimal)reader["Impuesto"];
            medicamento.Iva = (decimal)reader["Iva"];
            medicamento.PrecioVenta = (decimal)reader["PrecioVenta"];
            return medicamento;
        }

        public IList<Medicamentos> ConsultarMedicamntos()
        {
            ListaMedicamntos = new List<Medicamentos>();
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Select * from TablaMedicamentos";
                Reader = Comando.ExecuteReader();
                while (Reader.Read())
                {
                    Medicamentos medicamento = new Medicamentos();
                    medicamento = MapeoMedicamentos(Reader);
                    ListaMedicamntos.Add(medicamento);
                }
                Reader.Close();
            }
            return ListaMedicamntos;
        }

        public void EliminarMedicamento(Medicamentos medicamento)
        {

            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "delete from TablaMedicamentos where CodigoMedicamento=@CodigoMedicamento";
                Comando.Parameters.Add("@CodigoMedicamento", SqlDbType.VarChar).Value = medicamento.CodigoMedicamento;
                Comando.ExecuteNonQuery();
            }
        }

        public Medicamentos BuscarMedicamentos(Medicamentos medicamento)
        {
            ConsultarMedicamntos();
            foreach (Medicamentos item in ListaMedicamntos)
            {
                if (EsEncontrado(item, medicamento))
                {
                    return item;
                }
            }
            return null;
        }
        private bool EsEncontrado(Medicamentos item, Medicamentos medicamento)
        {
            return item.CodigoMedicamento == medicamento.CodigoMedicamento;
        }

        public string ModificarMedicamento(Medicamentos medicamento)
        {
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Update TablaMedicamentos set CodigoMedicamento=@CodigoMedicamento,NombreMedicamento=@NombreMedicamento,Cantidad=@Cantidad,ValorUnitario=@ValorUnitario,Detalle=@Detalle,Proveedor=@Proveedor,Impuesto=@Impuesto,Iva=@Iva,PrecioVenta=@PrecioVenta where CodigoMedicamento=@CodigoMedicamento";
                Comando.Parameters.Add("@CodigoMedicamento", SqlDbType.VarChar).Value = medicamento.CodigoMedicamento;
                Comando.Parameters.Add("@NombreMedicamento", SqlDbType.VarChar).Value = medicamento.NombreMedicamento;
                Comando.Parameters.Add("@Cantidad", SqlDbType.Int).Value = medicamento.Cantidad;
                Comando.Parameters.Add("@ValorUnitario", SqlDbType.Decimal).Value = medicamento.ValorUnitario;
                Comando.Parameters.Add("@Detalle", SqlDbType.VarChar).Value = medicamento.Detalle;
                Comando.Parameters.Add("@Proveedor", SqlDbType.VarChar).Value = medicamento.Proveedor;
                Comando.Parameters.Add("@Impuesto", SqlDbType.Decimal).Value = medicamento.Impuesto;
                Comando.Parameters.Add("@Iva", SqlDbType.Decimal).Value = medicamento.Iva;
                Comando.Parameters.Add("@PrecioVenta", SqlDbType.Decimal).Value = medicamento.PrecioVenta;

                int co = Comando.ExecuteNonQuery();
                if (co == 0)
                {
                    return "No se modifico ningun medicamento";
                }
                else
                {
                    return "Se modifico correctamente el medicamento " + medicamento.NombreMedicamento;
                }
            }
        }

        public string ModificarStock(Medicamentos medicamento)
        {
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Update TablaMedicamentos set Cantidad=@Cantidad where CodigoMedicamento=@CodigoMedicamento";

                Comando.Parameters.Add("@Cantidad", SqlDbType.Int).Value = medicamento.Cantidad;
              
                int co = Comando.ExecuteNonQuery();
                if (co == 0)
                {
                    return "No se modifico la cantidad ";
                }
                else
                {
                    return "Se modifico correctamente la cantidad el medicamento " + medicamento.NombreMedicamento;
                }
            }
        }
    }
}
