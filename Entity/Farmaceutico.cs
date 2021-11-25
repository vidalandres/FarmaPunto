using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Farmaceutico: Usuario
    {
        public new string TipoDeUsuario {
            get {
                return "Farmaceutico";
            }
        }
        
        public Farmaceutico()
        {

        }
    }
}
