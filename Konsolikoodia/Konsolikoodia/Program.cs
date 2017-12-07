using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsolikoodia
{
    class Program
    {
        static void Main(string[] args)
        {
            string tiedosto = @"I:\Visual Studio Clones\Konsolikoodia\numero.txt";
            //tiedoston luku
            if (File.Exists(tiedosto))
            {
                string aiempiArvo = File.ReadAllText(tiedosto);
                Console.WriteLine("Aiemmin asetettu numero on " + aiempiArvo + ".");
            }
            else
            {
                Console.WriteLine("Jaa.");
            }


            int lämpötila = 0;
            Console.Write("Aseta numero: ");
            string syöte = Console.ReadLine();
            lämpötila = int.Parse(syöte);

            //tiedostoon kirjoittaminen

            File.WriteAllText(tiedosto, lämpötila.ToString());
            Console.WriteLine("Asetit numeron " + int.Parse(syöte) + ".");
            Console.ReadLine();
        }
    }
}
