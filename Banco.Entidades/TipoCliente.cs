using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entidades
{
    internal class TipoCliente
    {
        public int ID { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public bool Estado { get; set; }
    }
}
