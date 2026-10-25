namespace fp007
{
    internal class Program
    {
        public Program()
        {
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Cantidad de candidatas");
            int n = int.Parse(Console.ReadLine());

            string[] nombre = new string[n];
            int[] puntos = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nombre de candidata:");
                nombre[i] = Console.ReadLine();
                Console.WriteLine("Puntuaje:");
                puntos[i] = int.Parse(Console.ReadLine());
            }

            int mayor = puntos[0];
            int menor = puntos[0];
            int idxmayor = 0;

            for (int i = 1; i < n; i++)
            {
                if (puntos[i] > mayor)
                {
                    mayor = puntos[i];
                    idxmayor = i;
                }
                if (puntos[i] < menor)
                {
                    menor = puntos[i];
                }
            }

            Console.WriteLine("La cantidad de candidatas es " + puntajes..Count);
            Console.WriteLine("La mayor puntaje ingresado es de:" + puntajes[idxmayor]);
            Console.WriteLine("La cantidad de candidatas es " + puntos.Length);
            Console.WriteLine("La mayor puntaje ingresado es de:" + puntos[idxmayor]);
            Console.WriteLine("La menor puntuación es " + menor);
        }
    }   