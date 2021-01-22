using System;

namespace Informatica_programma_distilleria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questo è un programma gestionale per distillerie " +
            "che permette di gestire botti, bottiglie e vendita dei prodotti.");
            Console.WriteLine("I distillati più convenienti per una distilleria sono:" +
            "vino, grappa, whisky, rum, gin, brandy, vodka e cognac.");
            string[] distillatitotali = new string[] { "vino", "grappa", "whisky", "rum", "gin", "brandy", "vodka", "cognac" };
            Console.WriteLine("Quanti distillati vuoi utilizzare nella tua distilleria?" +
            " Digita il numero di distillati.");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero > 0 && numero < 9)
            {
                string[] distillati = new string[numero];
                Console.WriteLine("Di seguito verranno elencati tutti i distillati uno ad uno");
                Console.WriteLine("Per selezionarli digitare: sì," +
                    " altrimenti per passare al successivo digitare: no");
                for (int i = 0; i < numero; i++)
                {
                    Console.WriteLine("Vuoi selezionare: " + distillatitotali[i] + " ?");
                    string risposta = Convert.ToString(Console.ReadLine());
                    if (risposta == "sì")
                    {
                        Console.WriteLine("hai selezionato: " + distillatitotali[i]);
                        distillati[i] = distillatitotali[i];
                    }
                    if (risposta == "no")
                    {
                        Console.WriteLine("non hai selezionato: " + distillatitotali[i]);
                    }
                    if (risposta != "sì" && risposta != "no")
                    {
                        Console.WriteLine("Non hai scritto la risposta corretta.");
                        break;
                    }
                }
                Console.WriteLine("Hai selezionato i seguenti distillati:");
                for (int i = 0; i < numero; i++)
                {
                    Console.WriteLine(distillati[i]);
                }
            }
            else
            {
                Console.WriteLine("Il numero inserito non ha un valore adeguato.");
            }
            Console.ReadKey();
        }
    }
}
