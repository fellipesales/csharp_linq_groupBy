using System;
using System.Linq;

namespace TesteMarcorattiArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayNumeros = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2, 8, 1, 3, 9, 2, 7, 6, 3, 1, 5, 7, 8, 9 };

            //ImprmirArrayUmaLinha(arrayNumeros);

            ImprmirArray(arrayNumeros);

            Console.ReadKey();
        }

        private static void ImprmirArrayUmaLinha(int[] arrayNumeros)
        {
            arrayNumeros.GroupBy(x => x).Select(a => new { Texto = a.First().ToString() + " aparece " + a.Count().ToString() + (a.Count().Equals(1) ? " vez " : " vezes ") }).ToList().ForEach(n => Console.WriteLine(n.Texto));
        }

        private static void ImprmirArray(int[] arrayNumeros)
        {
            var count = arrayNumeros.Count();

            var arrayGroup = arrayNumeros.GroupBy(x => x).Select(a => new
            {
                Texto = a.First().ToString() + " aparece " + a.Count().ToString() + (a.Count().Equals(1) ? " vez " : " vezes ")
            }).ToArray();

            foreach (var item in arrayGroup)
            {
                Console.WriteLine(item.Texto);
            }
        }
    }
}
