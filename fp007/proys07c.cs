using System;
using System.Collections.Generic;
using System.Text;

namespace fp007
{
    internal class proys07c
    {
        static void Main(string[] args)
        {
            List<string> nombres = new List<string>();
            List<int> puntajes = new List<int>();

            int opc = 1;
            while (opc == 1)
            {
                Console.WriteLine("Ingresa nombre:");
                string nom = Console.ReadLine();

                Console.WriteLine("Ingresa puntaje:");
                int puntos = int.Parse(Console.ReadLine());

                nombres.Add(nom);
                puntajes.Add(puntos);

                Console.WriteLine("El [1] Continuar \n [0] Salir ");
                opc = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < puntajes.Count; i++)
            {
                Console.WriteLine($"{nombres[i]} \t {puntajes[i]}");
            }

            int mayor = puntajes[0];
            int menor = puntajes[0];
            int idxmayor = 0;

            for (int i = 1; i < puntajes.Count; i++)
            {
                if (puntajes[i] > mayor)
                {
                    mayor = puntajes[i];
                    idxmayor = i;
                }
                if (puntajes[i] < menor)
                {
                    menor = puntajes[i];
                }
            }

            Console.WriteLine($"\nMayor puntaje: {nombres[idxmayor]} con {mayor}");
            Console.WriteLine($"Menor puntaje: {menor}");
        }
    }
}
