using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DetalleFactura
    {
        public string IdentificacionDetalle { get; set; }
        public string IdeFactura { get; set; }
        public string IdeMedicamento { get; set; }
        public string NombreMedicamento { get; set; }
        public int Cantidad { get; set; }
        public int ValorUnitario { get; set; }
        public int ValorTotal {
            get
            {
                return Cantidad * ValorUnitario;

            }
        }
        public long IdeFarmaceutico { get; set; }
        public string Fecha { get; set; }

        public DetalleFactura()
        {

        }

        public DetalleFactura(string identificacionDetalle, string ideFactura, string ideMedicamento, string nombreMedicamento, long ideFarmaceutico , string fecha)
        {
            this.IdentificacionDetalle = identificacionDetalle;
            this.IdeFactura = ideFactura;
            this.IdeMedicamento = ideMedicamento;
            this.NombreMedicamento = nombreMedicamento;
            this.IdeFarmaceutico = ideFarmaceutico;
            this.Fecha = fecha;

        }
    }
}
