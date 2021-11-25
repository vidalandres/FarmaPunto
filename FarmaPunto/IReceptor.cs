using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace FarmaPunto
{
    public interface IReceptor
    {
        void Recibir(Medicamentos medicamento);
    }
}
