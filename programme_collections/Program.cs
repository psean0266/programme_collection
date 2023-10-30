using System;
using System.Collections.Generic;
using System.Linq;

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

      static void  AfficherElementCommun(List<string> liste1 , List<string> liste2)
        {
            //  string nom;

            #region with contains
            //for (int i = 0; i< liste1.Count; i++)
            //{
            //    string nom1 = liste1[i];

            //    if (liste2.Contains(nom1))
            //    {
            //        Console.WriteLine(nom1);
            //    }
               
            //}
            #endregion

            #region with two boucles
            for (int i = 0; i < liste1.Count; i++)
            {
                string nom1 = liste1[i];

                for(int j = 0; j < liste2.Count; j++)
                {
                    string nom2 = liste2[j];
                    if (nom1 == nom2)
                    {
                        Console.WriteLine(nom1);
                    }
                }

            }
            #endregion

        }



        static void Listes()
        {

            //var noms = new List<string>();
            //string nom = "";
            //while (true)
            //{
            //  Console.WriteLine("Veuillez entrer un nom: ");
            //  nom = Console.ReadLine();

            //  if(nom == "")
            //  {
            //        break;
            //  }

            //  if (noms.Contains(nom))
            //  {
            //      Console.WriteLine("ERREUR, ce nom est déjà dans la liste ");
            //        Console.WriteLine();
            //  }
            //  else 
            //  {
            //        noms.Add(nom);
            //  }

            //}

            ////List<string> lesPremiersNoms = noms.GetRange(0, 3);

            ////  AfficherListe(lesPremiersNoms);

            //for (int i = noms.Count - 1; i >= 0; i--)
            //{
            //    string nom2 = noms[i]; // Move this line inside the loop

            //    if (nom2[nom2.Length - 1] == 'e')
            //    {
            //        noms.RemoveAt(i); // Use RemoveAt to remove by index
            //    }
            //}

            var liste1 = new List<string>() { "Paul", "Jean","Pierre", "emilie", "Martin" };
            var liste2 = new List<string>() { "Sophie", "Jean", "Martin", "Toto"};

           AfficherElementCommun(liste1 , liste2);

            //AfficherListe(noms, true);
        }

    static void AfficherListe(List<string> liste, bool ordreDescendant = false)
        {
        
            if(ordreDescendant)
            {
                for (int i = liste.Count - 1; i >= 0 ; i--)
                {                                  
                    Console.WriteLine(liste[i]);
                }
            }
            else
            {
                for (int i = 0; i < liste.Count; i++)
                {
                    Console.WriteLine(liste[i]);
                }
            }

            string nomLePlusLong = "";
            int longueurMax = 0;

            for (int i = 0; i < liste.Count; i++)
            {
                string nom = liste[i];

                if (longueurMax < nom.Length)
                  //  if (nomLePlusLong.Length < liste[i].Length)
                {
                    longueurMax = nom.Length;
                    nomLePlusLong = nom;
                   // nomLePlusLong = liste[i];
                }
            }
     

            Console.WriteLine();
            Console.WriteLine("Le nom le plus grand est: " + nomLePlusLong);
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

        static void ListeDeListe()
        {
            var Pays = new List<List<string>>();

            Pays.Add(new List<string> { "France","Paris","Toulouse", "Nice","Bordeaux","Lille"});
            Pays.Add(new List<string> { "Etats-unis", "New-York", "Chicago", "Los angeles", "San francisco" });
            Pays.Add(new List<string> { "Italie", "Venise", "Florence", "Milan", "Pise" });

            for(int i = 0 ; i < Pays.Count; i++)
            {
                var p= Pays[i];

                Console.WriteLine(p[0] + " - " + (p.Count - 1) + " Villes");

                for (int j = 1 ; j< p.Count; j++)
                {


                    Console.WriteLine(" "+ p[j]);
                }
            }

        }

        
        static void Dictionnaire()
        {
            string personneAChercher = "Martin";
            var d = new Dictionary<string, string>();
            d.Add("Jean", "07887786");
            d.Add("Marie", "099766454");
            d["Martin"] = "97446454";
            d["Toto"] = "0744645664";

            if (d.ContainsKey(personneAChercher))
            {
                Console.WriteLine(d[personneAChercher]);
            }
            else
            {
                Console.WriteLine("Cette personne n'a pas été trouvé");
            }

            // Liste string [2] nom numero de tel
            var l = new List<string[]>();
            l.Add(new string[] { "Jean", "07887786" });
            l.Add(new string[] { "Marie", "099766454" });
            l.Add(new string[] { "Martin", "97446454" });
            l.Add(new string[] { "Toto", "0744645664" });

            for (int i =0; i<l.Count; i++)
            {
              //  var p = l[i];

                if (l[i][0] == personneAChercher)
                {
                    Console.WriteLine(l[i][1]);
                }
            }

        }

        static void BoucleForEach()
        {
            
            var noms = new string[] {"Toto","Jean","Pierre" };
            #region Avec For
            for (int i = 0 ; i<noms.Length; i++)
            {
                Console.WriteLine(noms[i]);
            }
            #endregion 

            #region Avec Foreach
            foreach (var nom in noms)
            {
                Console.WriteLine(nom);
            }
            #endregion

            var d = new Dictionary<string, string>();
            d.Add("Jean", "07887786");
            d.Add("Marie", "099766454");
            d["Martin"] = "97446454";
            d["Toto"] = "0744645664";

            foreach (var e in d)
            {
                Console.WriteLine(e.Key + " -> " + e.Value);
            }


        }

        static void TrisEtLinq()
        {
            #region Avec Liste
            var noms = new List<string>() { "Toto", "Jean", "Pierre", "Emilie", "Sophie", "Benoit", "Martin", "Vincent" };
            //noms.Sort();

            #endregion

            #region Avec Tableau
            //  var noms = new string[] { "Toto", "Jean", "Pierre", "Emilie", "Sophie", "Benoit", "Martin", "Vincent" };
            //    Array.Sort(noms);   

            var nomTries = noms.OrderBy(nom => nom);  // Pour chaque nom dans mes noms retourner nom 
            var nomTriesDesc = noms.OrderByDescending(nom => nom);
            var nomTriesLonger = noms.OrderBy(nom => nom.Length); // taille
            var nomTriesParLaDernièreLettreDuNom = noms.OrderBy(nom => nom[nom.Length-1]); // taille

            //noms = noms.OrderBy(nom => nom).ToList();  // noms = noms.OrderBy(nom => nom).ToArray();  Pour Array();
            //noms = noms.Where(nom => nom.Length > 4).ToList();
            //noms = noms.Where(nom => nom[nom.Length-1] =='e').ToList();
            noms = noms.Where(nom => nom[nom.Length - 1] != 'e').ToList();
            #endregion


            foreach (var nom in noms)
            //foreach (var nom in nomTriesParLaDernièreLettreDuNom)  // Linq
            {
                Console.WriteLine(nom);
            }

            var notes = new List<int> { 4, 8, 1, 9, 2 };
            notes = notes.OrderBy(n => n ).ToList();
            notes = notes.OrderByDescending(n => n).ToList();
            notes = notes.Where(n => n >= 5).ToList();  

            foreach (var n in notes)
            {
                Console.WriteLine(n);
            }
        }

        static void MaFonction(out int p)
        {
         //   Console.WriteLine("Dans Ma fonction p =" + p);
            p = 10;
         //   Console.WriteLine("Dans MaFonction p=" + p);
        }

        static void MaFonction2(List<int> p)
        {
            p[0] = 10;
        }
        static void passageParValeursOuRef()
        {
            int a = 5;
            MaFonction(out a); // Passage par reference

            //  int num = int.Parse("15");
            //   int num = int.Parse("hggfgfgfcc");

            int num = 0;

            if ( int.TryParse("hgghg", out num))
            {
                Console.WriteLine("Conversion OK");
                num++;
            }
            else 
            {
                Console.WriteLine("Problème de Conversion");
            }
            

            var l = new List<int> {5};
            //  MaFonction2(l);  // Passage par reference

            Console.WriteLine(num);

            //Console.WriteLine(a);

            //  Console.WriteLine(l[0]);
        }
        static void Main(string[] args)
        {
            //  Tableaux();
            //  ListeDeListe();
            // Dictionnaire();
            //  BoucleForEach();
            // TrisEtLinq();
            passageParValeursOuRef();
        }
    }
}
