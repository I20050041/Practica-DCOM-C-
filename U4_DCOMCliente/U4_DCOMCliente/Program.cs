using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4_DCOMCliente
{
    class Program
    {
        static void Main()
        {
            try
            {
                var servidorDCOM = new U4_DCOM.ServidorDCOM();
                string resultado = servidorDCOM.ObtenerSaludo("UsuarioDCOM");
                Console.WriteLine(resultado);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.ReadLine();
        }
    }
}