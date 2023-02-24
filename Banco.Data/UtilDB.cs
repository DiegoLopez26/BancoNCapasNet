using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Data
{
    public class UtilDB
    {
        public static string CadenaConexion()
        {
            string cadenaConexión = @"Server= LAPTOP-MKA1MDEC ; DataBase= BancoBD; User= LAPTOP-MKA1MDEC; Password=724809130";
            return cadenaConexión;
       
        }
    }
}
