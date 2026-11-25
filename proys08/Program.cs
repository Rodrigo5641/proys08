using System;
using System.Collections.Generic;

namespace fp008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] candidatos = { "JFK", "VP", "RR" };
            int[] votos = new int[candidatos.Length];
            List<string> lista = new List<string>();

            do
            {
                string dni;
                bool yaVoto = false;

                do
                {
                    Console.Write("DNI (presiona Enter vacío para terminar): ");
                    dni = Console.ReadLine();

                    if (string.IsNullOrEmpty(dni))
                    {
                        break;
                    }

                    yaVoto = lista.Contains(dni);
                    if (yaVoto)
                    {
                        Console.WriteLine("Usted ya votó");
                    }
                } while (yaVoto);

                if (string.IsNullOrEmpty(dni))
                {
                    break;
                }

                lista.Add(dni);

                for (int i = 0; i < candidatos.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {candidatos[i]}");
                }

                Console.Write("Elija su candidato: ");
                int cand = int.Parse(Console.ReadLine());

                if (cand >= 1 && cand <= candidatos.Length)
                {
                    votos[cand - 1] = votos[cand - 1] + 1;
                }
                else
                {
                    Console.WriteLine("Opción no válida, voto nulo.");
                }

            } while (true);

            Console.WriteLine("\n--- RESULTADOS DE LA VOTACIÓN ---");
            for (int i = 0; i < candidatos.Length; i++)
            {
                Console.WriteLine($"{candidatos[i]} \t {votos[i]}");
            }

            Console.WriteLine("\nCandidato con mayor votación:");
            int mayor = votos[0];
            int idx = 0;

            for (int i = 1; i < candidatos.Length; i++)
            {
                if (votos[i] > mayor)
                {
                    mayor = votos[i];
                    idx = i;
                }
            }

            Console.WriteLine($"{candidatos[idx]} \t {votos[idx]}");
            Console.ReadKey();
        }
    }
}