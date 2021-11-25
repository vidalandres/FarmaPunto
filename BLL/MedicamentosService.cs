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
    public class MedicamentosService
    {
        SqlConnection Conexion;
        IList<Medicamentos> ListaMedicamentos;
        RepositoryMedicamento repositoryMedicamento;
        public MedicamentosService()
        {
            Conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\FarmaPunto(copia)\DAL\DatosProyecto.mdf;Integrated Security=True");
            repositoryMedicamento = new RepositoryMedicamento(Conexion);
        }

        public IList<Medicamentos> ConsultarMedicamentos()
        {
            Conexion.Open();
            ListaMedicamentos = new List<Medicamentos>();
            ListaMedicamentos = repositoryMedicamento.ConsultarMedicamntos();
            Conexion.Close();
            return (ListaMedicamentos);
        }

        public Medicamentos BuscarMedicamento(string codigo)
        {
            Conexion.Open();
            Medicamentos medicamento = new  Medicamentos();
            medicamento.CodigoMedicamento = codigo;
            medicamento = repositoryMedicamento.BuscarMedicamentos(medicamento);
            Conexion.Close();
            return medicamento;
        }

        public string GuardarMedicamentos(Medicamentos medicamento)
        {
            try
            {
                Conexion.Open();
                repositoryMedicamento.GuardarMedicamnetos(medicamento);
                Conexion.Close();
                return "se registro el medicamento " + medicamento.NombreMedicamento;
            }
            catch (Exception e)
            {
                Conexion.Close();
                return "Error de base de datos: " + e.Message.ToString();
            }
        }

        public string EliminarMedicamento(Medicamentos medicamento)
        {
            Conexion.Open();
            if (repositoryMedicamento.BuscarMedicamentos(medicamento) != null)
            {
                medicamento = (repositoryMedicamento.BuscarMedicamentos(medicamento));
                repositoryMedicamento.EliminarMedicamento(medicamento);
                Conexion.Close();
                return "Se eliminó al medeicamennto " + medicamento.NombreMedicamento + "correctamente";
            }
            else
            {
                Conexion.Close();
                return "El medicamento con ese codigo no existe";
            }
        }

        public string ModificarMedicamentos(Medicamentos medicamento)
        {
            Conexion.Open();
            string respuesta;
            respuesta = repositoryMedicamento.ModificarMedicamento(medicamento);
            Conexion.Close();
            return respuesta;
        }


        public string ModificarStock(Medicamentos medicamento)
        {
            Conexion.Open();
            string respuesta;
            respuesta = repositoryMedicamento.ModificarStock(medicamento);
            Conexion.Close();
            return respuesta;
        }
    }
}
