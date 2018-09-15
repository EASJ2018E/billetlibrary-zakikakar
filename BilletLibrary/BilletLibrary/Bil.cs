using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class Bil
    {
        public string NummerPlade;
        public DateTime Dato;

        public decimal Pris() //Ved kald af metoden Pris() returneres decimal 240
        {
            return 240;
        }

        public string Køretøj() //Ved kald af metoden Køretøj() returneres string "Bil"
        {
            return "Bil";
        }
    }
}