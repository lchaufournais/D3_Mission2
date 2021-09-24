using System;

namespace Mission02_Revision_2emeSLAM
{
    class Program
    {
        static void Main(string[] args)
        {
             Compte c1, c2;

            Banque b = new Banque();
            c1 = new Compte(12345, "toto", 1000, -500);
             c2 = new Compte(45657, "titi", 2000, -1000);
        
 c1 =  new Compte(12345,"toto",1000,-500);
 b.ajouter(c1);
              b.ajouter(12345, "toto", 1000, -500);
              b.ajouter(45657, "titi", 2000, -1000);
              b.ajouter(12654, "tintin", 5000, -500);
              Console.WriteLine(b.rendCompte(45657).ToString());


            b.ajouterType("ch", "chèque débité");
            b.ajouterType("pre", "prélèvement");
            b.ajouterType("dab", "retrait en distributeur");
            b.ajouterType("ret", "retrait guichet ");
            b.ajouterType("vir", "virement sur compte");
            Console.WriteLine(b.GetType("vir").ToString());
            b.rendCompte(45657).ajouterMouvement(200, new DateTime(2012, 09, 11), b.GetType("vir"));
            foreach (Mouvement mouv in c1.GetListMouv())
            {
                Console.WriteLine(mouv.ToString());
            }
        }
    }
}
