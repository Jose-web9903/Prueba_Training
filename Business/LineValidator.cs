using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Business
{
    public class LineValidator
    {
        private static Regex reg = new Regex("[0-9]");

        public static bool ValidLine(int count, string line)
        {
            if (!line.Contains(','))
                throw new Exception("Error en la línea " + count + ". No se encontró el separador ','");

            else if (!reg.IsMatch(line.Split(',')[0]))
                throw new Exception("Error en la línea " + count + ". No se admite la subcadena ingresada antes del caracter ','");

            else if (!reg.IsMatch(line.Split(',')[1]))
                throw new Exception("Error en la línea " + count + ". No se admite la subcadena ingresada despues del caracter ','");

            else if (line.Split(',')[0] == "0" && line.Split(',')[1] != "0")
                throw new Exception("Error en la línea " + count + ". Comando no valido");

            else if (Int32.Parse(line.Split(',')[0]) > 10)
                throw new Exception("Error en la línea " + count + ". El tamaño maximo permitido es 10");

            return true;
        }
    }
}
