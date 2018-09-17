using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace BilletLibrary
{
    public class Bil : KøretøjBase
    {

        public decimal Pris() //Ved kald af metoden Pris() returneres decimal 240
        {
            if (AnvendtBrobizz) //Tjekker om brobizz er anvendt, hvis true så giver den rabat på 5%
            {
                return 240 * (decimal) Rabat;
            }

            return 240;
        }

        public string Køretøj() //Ved kald af metoden Køretøj() returneres string "Bil"
        {
            return "Bil";
        }
    }
}