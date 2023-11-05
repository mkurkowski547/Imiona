using System;
namespace Imiona
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaImion = new List<string>
        {
            "Justyna",
            "Piotr",
            "Mateusz",
            "Aleksandra",
            "Bartłomiej",
            "Stanisław",
            "Dorota",
            "Michał"
        };
            foreach (string imie in listaImion)
            {
                Powiedz(imie);
            }
        }
        public static void Powiedz(string imie)
        {
            Console.WriteLine("Jedno dla {0}, jedno dla mnie.", imie);

        }
    }
}