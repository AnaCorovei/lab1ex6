using System;

namespace lab1ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ex6   
             Se citesc trei numere de la tastatura, x,y,z. Scrieti un program care va afisa cele trei valori in ordine descrescatoare.
             • Exemplu: citim 3,9,0 Afisam : 9 3 0 */

            int x;
            int y;
            int z;

            Console.WriteLine("Enter x: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter y: ");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter z: ");
            z = int.Parse(Console.ReadLine());

            if (y > x && z > x && z > y)
            { 
                Console.WriteLine(z + "," + y + "," +x);
           
            }
            else if (y < x && z < x && y < z)
            {
                Console.WriteLine(x + "," + z + "," + y);

            }
            else if (y < x && x < z && z > y)
            {
                Console.WriteLine(z + "," + x + "," + y);

            }

        }
    }
}


