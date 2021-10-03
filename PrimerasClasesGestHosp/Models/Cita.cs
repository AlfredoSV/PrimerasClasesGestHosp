using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerasClasesGestHosp.Models
{
    class Cita
    {
        public Guid Id;

        public Guid PacienteId;

        public int Estatus;

        public DateTime Fecha;
    }
}
