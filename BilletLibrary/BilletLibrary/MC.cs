﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class MC
    {
        public string Nummerplade;
        public DateTime Dato;

        public decimal Pris()//Ved kald af metoden Pris() returneres decimal 125
        {
            return 125;
        }

        public string Køretøj()//Ved kald af metoden Køretøj() returneres string "MC"
        {
            return "MC";
        }
    }
}