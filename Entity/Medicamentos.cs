using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Medicamentos
    {

        public Medicamentos()
        {

        }

        public string CodigoMedicamento { get; set; }

        public string NombreMedicamento { get; set; }

        public int Cantidad { get; set; }

        public decimal ValorUnitario { get; set; }

        public string Detalle { get; set; }

        public string Proveedor { get; set; }

        public decimal Impuesto { get; set; }

        public Medicamentos(string codigoMedicamento, string nombreMedicamento, int cantidad, decimal valorUnitario, string detalle, string proveedor,decimal impuesto)
        {
            this.CodigoMedicamento = codigoMedicamento;
            this.NombreMedicamento = nombreMedicamento;
            this.Cantidad = cantidad;
            this.ValorUnitario = valorUnitario;
            this.Detalle = detalle;
            this.Proveedor = proveedor;
            this.Impuesto = impuesto;
        }

        public decimal Iva
        {
            get
            {
                return ((Impuesto/100) * ValorUnitario);
            }
            set { }
        }

        public decimal PrecioVenta
        {
            get
            {
                return (ValorUnitario + Iva);
            }
            set { }
        }
    }
}
