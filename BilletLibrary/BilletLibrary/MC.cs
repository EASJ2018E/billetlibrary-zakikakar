using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class MC : KøretøjBase //Arver fra base klassen 'KøretøjBase'
    {
        public override decimal Pris()//Ved kald af metoden Pris() returneres decimal 125
        {
            return 125;
        }

        public override string Køretøj()//Ved kald af metoden Køretøj() returneres string "MC"
        {
            return "MC";
        }
    }
}
