using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


namespace U4_DCOM
{
    [ComVisible(true)]
    public class ServidorDCOM
    {
        [ComVisible(true)]
        public string ObtenerSaludo(string nombre)
        {
            return $"Hola, {nombre}!";
        }
    }
}