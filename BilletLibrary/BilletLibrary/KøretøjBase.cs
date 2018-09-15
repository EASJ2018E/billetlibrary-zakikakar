using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public abstract class KøretøjBase
    {
        public string Nummerplade
        {
            get => _nummerplade;
            set
            {
                if (value.Length >= 1 && value.Length <= 7)
                {
                    _nummerplade = value;
                }
                else
                {
                    throw new Exception("Nummerpladen skal være mellem 1-7 tegn");
                }
            }
        }

        public DateTime Dato;
        private string _nummerplade;

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