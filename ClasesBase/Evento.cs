using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    class Evento
    {
        public int Eve_ID { get; set; }
        public int Com_ID { get; set; } // Competencia
        public int Atl_ID { get; set; } // Atleta
        public string Eve_Estado { get; set; } // Inscripto, Acreditado, Anulado, Abandono, Descalificado
        public DateTime Eve_HoraInicio { get; set; }
        public DateTime Eve_HoraFin { get; set; }
    }
}
