using System;
using System.Threading;



namespace Montella_RicercaConcorrente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci il numero da ricercare");
            int n = int.Parse(Console.ReadLine());
            //Thread t1 = new Thread(new ThreadStart(RicercaNumero));
            //t1.Start();
            //ThreadStart start = new ThreadStart(RicercaNumero(n));
            Thread t1 = new Thread( () => RicercaNumero(n));
            t1.Start();
            
            static void RicercaNumero(int n)
            {
                int temp;
                Random r = new Random();
                int[] array = new int[100];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = r.Next(0, 100);
                    if (array[i] == n)
                    {
                        temp = array[i];
                        Console.WriteLine($"Trovata!!! in: {i}" );
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"posizione: {i} non trovato");
                    }

                }
            }
        }
    }
}
