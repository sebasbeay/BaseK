using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BaseK(287, 4));
        }

        public static int BaseK(int numero, int nuevaBase)
        {
            List<int> residuos = new List<int>();
            int cociente, residuo = 0;
            string nuevaRepresentacion = string.Empty;
            StringBuilder numeros = new StringBuilder();

            //Calculo de la nueva representación
            do
            {
                cociente = numero / nuevaBase;
                residuo = numero % nuevaBase;
                residuos.Add(residuo);
                numero = cociente;
            } while (numero >= nuevaBase);

            //Armar representación con los resultados obtenidos
            numeros.Append(cociente);
            for (int i = residuos.Count - 1; i >= 0; i--)
            {
                numeros.Append(residuos[i]);
            }
            nuevaRepresentacion = numeros.ToString();

            return int.Parse(nuevaRepresentacion);
        }
    }
}
