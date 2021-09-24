using System;
using System.Collections.Generic;
using System.Text;

namespace Mission02_Revision_2emeSLAM
{
    class Type
    {
        /// <summary>
        /// les attributs de la classe Type
        /// </summary>
        string code;
        string libelle; 
        /// <summary>
        /// Constructeur de la classe type
        /// </summary>
        public Type()
        {
            this.code = "";
            this.libelle = "";
        }
        public Type( string code, string libelle )
        {
            this.code = code;
            this.libelle = libelle;
        }
        /// <summary>
        /// Getter
        /// </summary>
        /// <returns></returns>
        public string getCode()
        {
            return this.code;
        }
        /// <summary>
        /// To string 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"code : {code} $libelle : {libelle}";
        }

   
    }
}
