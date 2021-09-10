using System;

namespace banque2
{
    public class Compte
    {
        private int num;
        private string nom;
        private double solde;
        private double decouvert;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="num"></param>
        /// <param name="nom"></param>
        /// <param name="solde"></param>
        /// <param name="decouvert"></param>
        public Compte(int num, string nom, double solde, double decouvert)
        {
            this.num = num;
            this.nom = nom;
            this.solde = solde;
            this.decouvert = decouvert;
        }
        /// <summary>
        /// Constructeur sans paramètre
        /// </summary>
        public Compte()
        {
            this.num = 0;
            this.nom = "";
            this.solde = 0;
            this.decouvert = 0;
        }
        /// <summary>
        /// Getteur du numero
        /// </summary>
        /// <returns> Le numero </returns>
        public int getNumero()
        {
            int n = this.num;
            return n;
        }
        /// <summary>
        /// Getteur du Nom
        /// </summary>
        /// <returns> Le nom </returns>
        public string getNom()
        {
            string n = this.nom;
            return n;
        }
        /// <summary>
        /// Getteur du solde
        /// </summary>
        /// <returns> Le solde </returns>
        public double getSolde()
        {
            double s = this.solde;
            return s;
        }
        /// <summary>
        /// Getteur du decouvert autorisé
        /// </summary>
        /// <returns> Le decouvert autorisé </returns>
        public double getDecouvertAutorise()
        {
            double d = this.decouvert;
            return d;
        }
        /// <summary>
        /// Permet la concacténation
        /// </summary>
        /// <returns> Une chaine de caractère </returns>
        public override string ToString()
        {
            return "Numero : " + this.num + " Nom : " + this.nom + " Solde : " + this.solde + " Decouvert autorisé : " + this.decouvert;
        }
        /// <summary>
        /// Permet d'ajouter de l'argent sur un compte
        /// </summary>
        /// <param name="a"></param>
        public void crediter(double a)
        {
            this.solde = this.solde + a;

        }
        /// <summary>
        ///  Permet de retirer l'argent du compte si cela est possible
        /// </summary>
        /// <param name="a"></param>
        public void debiter(double a)
        {
            bool debi;
            if (this.solde + (this.decouvert * (-1)) >= a)
            {
                debi = true;
                if (this.solde > a)
                {
                    this.solde = this.solde - a;
                }
                else
                {
                    this.solde = 0;
                    this.decouvert = this.decouvert + a;
                }
            }
            else
            {
                debi = false;
            }
        }
        /// <summary>
        /// Permet de retirer de l'argent d'un compte pour l'ajouter sur un autre si cela est possible
        /// </summary>
        /// <param name="a"></param>
        /// <param name="c1"></param>
        public void transfere(double a, Compte c1)
            {
            this.debiter(a);
            c1.crediter(a);
            }
        /// <summary>
        /// Permet de savoir si un compte a un solde plus grand que l'autre 
        /// </summary>
        /// <param name="c1"></param>
        /// <returns> Un bool </returns>
        public bool superieur(Compte c1)
        {
            bool t = false;
            if (this.solde > c1.solde)
            {
                t = true;
            }
            else
            {
                t = false;
            }
            return t;
        }
        /// <summary>
        ///  Permet de savoir si un compte a un solde plus inferieur que l'autre
        /// </summary>
        /// <param name="c1"></param>
        /// <returns>Un bool</returns>
        public bool inferieur(Compte c1)
        {
            bool t = false;
            if(this.solde < c1.solde)
            {
                t = true;
            }
            else
            {
                t = false;
            }
            return t;
        }
        }
        
    }

