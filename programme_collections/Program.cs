using System;
using System.Collections.Generic;

namespace programme_collections
{
    internal class Program
    {
        static int somme(int[]t)
        {
            int somme = 0;  
             for (int i = 0; i < t.Length; i++)
            {
                somme += t[i];
            }

             return somme;
        }
        static void AfficherTableau(int[] tableau)
        {
            for (int i = 0;i < tableau.Length;i++)
            {
                Console.WriteLine("["+ i +"] "+tableau[i]);
            }
        }

        static void AfficherLavaleurMaximale(int[] t)
        {
            int valeuMax = t[0];
   

            for (int i = 0; i < t.Length ; i++)
            {
                
                if ( valeuMax < t[i])
                {
                    valeuMax = t[i];
                }
                               
            }
            Console.WriteLine(valeuMax);
        }
        
        static void Listes()
        {
            //List<int> liste = new List<int>();

            //liste.Add(5);
            //liste.Add(8);
            //liste.Add(2);
            //liste.Add(6);

            //liste[2]++;
            
            //liste.Remove(2);
            //liste.RemoveAt(1);

            //AfficherListe(liste);   

            var noms = new List<string>();
            string nom = "";
            while (true)
            {
              Console.WriteLine("Veuillez entrer un nom: ");
              nom = Console.ReadLine();

              if(nom == "")
              {
                    break;
              }

              if (noms.Contains(nom))
              {
                  Console.WriteLine("ERREUR, ce nom est déjà dans la liste ");
                    Console.WriteLine();
              }
              else 
              {
                    noms.Add(nom);
              }
                                
            }

            //List<string> lesPremiersNoms = noms.GetRange(0, 3);

          //  AfficherListe(lesPremiersNoms);

            AfficherListe(noms);
        }

    static void AfficherListe(List<string> liste)
        {
            for ( int i = 0; i< liste.Count; i++)
            {
                Console.WriteLine(liste[i]);
                
            }
        }

        static void AfficherLavaleurMinimal(int[] t)
        {
            int valeuMini = t[0];


            for (int i = 0; i < t.Length; i++)
            {

                if (valeuMini > t[i])
                {
                    valeuMini = t[i];
                }

            }
            Console.WriteLine(valeuMini);
        }
        static void Tableaux() 
        {
           // int[] t = { 200, 40, 15, 8, 12 };

            const int TAILLE_TABLEAU = 20;
            const int MIN = 0;
            const int MAX = 100;

            int[] t = new int[TAILLE_TABLEAU];

           Random r = new Random();
           for (int i = 0; i<t.Length; i++)
           {
              //  t[i] = r.Next(MIN, (MAX + 1));
                t[i] = r.Next(101);   
           }

          AfficherTableau(t);
          Console.WriteLine();
          AfficherLavaleurMaximale(t);
          Console.WriteLine();
          AfficherLavaleurMinimal(t);
          Listes();       

          }
        static void Main(string[] args)
        {
          Tableaux();

        }
    }
}
