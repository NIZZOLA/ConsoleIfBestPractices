using System;
using System.Collections.Generic;

namespace ConsoleIfBestPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var carros = new List<Carro>();
            carros.Add(new Carro("Fusca", 4.026, 1.485));
            carros.Add(new Carro("Creta", 4.270, 1.780));
            carros.Add(new Carro("CrossFox", 4.053, 1.61));
            carros.Add(new Carro("Voyage", 4.213, 1.142));
            carros.Add(new Carro("Hilux", 5.225, 1.810));

            foreach ( var carro in carros)
            {
                Console.Write(carro.Nome + " =>");
                TestaCarro(carro);
            }

        }

        public static void TestaCarro(Carro carro)
        {
            if (carro.Tamanho <= 4.1 && carro.Altura <= 1.6)
                Console.WriteLine("HatchBack");
            else if (carro.Tamanho <= 4.1 && carro.Altura > 1.6)
                Console.WriteLine("Mini Suv");
            else if (carro.Tamanho <= 5.0 && carro.Altura <= 1.6)
                Console.WriteLine("Sedan");
            else if (carro.Tamanho <= 5.0 && carro.Altura > 1.6)
                Console.WriteLine("Suv");
            else if (carro.Tamanho > 5.0 && carro.Altura > 1.6)
                Console.WriteLine("Pickup/Truck");
        }


        public static void TestaCarro2(Carro carro)
        {
            switch (carro)
            {
                case var dimensao when carro.Tamanho <= 4.1 && carro.Altura <= 1.6:
                    Console.WriteLine("HatchBack");
                    break;
                case var dimensao when carro.Tamanho <= 4.1 && carro.Altura > 1.6:
                    Console.WriteLine("Mini Suv");
                    break;
                case var dimensao when carro.Tamanho <= 5.0 && carro.Altura <= 1.6:
                    Console.WriteLine("Sedan");
                    break;
                case var dimensao when carro.Tamanho <= 5.0 && carro.Altura > 1.6:
                    Console.WriteLine("Suv");
                    break;
                case var dimensao when carro.Tamanho > 5.0 && carro.Altura > 1.6:
                    Console.WriteLine("Pickup/Truck");
                    break;
            }
        }

    }



    record Carro( string Nome, double Tamanho, double Altura);
    

}
