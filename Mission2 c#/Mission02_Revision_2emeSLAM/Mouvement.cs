using System;
using System.Collections.Generic;
using System.Text;

namespace Mission02_Revision_2emeSLAM
{
    class Mouvement
    {
        DateTime dateMvt;
        int montant;
        Type leType;

        public Mouvement(DateTime date, int Mnt, Type type)
        {
            this.dateMvt = date;
            this.montant = Mnt;
            this.leType = type;
        }
        public Mouvement()
        {
            DateTime time = new DateTime(00-00-00);
            this.dateMvt = time;
            this.montant = 0;
        }
    }
}
