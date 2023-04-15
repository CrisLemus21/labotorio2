using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio2
{
    internal class ClsProdectos
    {
        public string Nombre { get; set; }
        public string Provedor { get; set; }
        public DateTime Vencimiento { get; set; }
        public DateTime FechaEntrada { get; set; }
        public string Detalle { get; set; }
        public decimal Precio { get; set; }
        public int Unidades { get; set; }
    }
}
