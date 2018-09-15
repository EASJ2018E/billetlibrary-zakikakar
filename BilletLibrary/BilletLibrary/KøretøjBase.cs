using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public abstract class Base
    {
        public string Nummerplade;
        public DateTime Dato;

        public decimal Pris()
        {
             throw new NotImplementedException();
        }

        public string Køretøj()
        {
            throw new NotImplementedException();
        }
    }
}