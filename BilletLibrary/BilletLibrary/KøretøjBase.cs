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
                    throw new ArgumentException("Nummerpladen skal være mellem 1-7 tegn");
                }
            }
        }

        public DateTime Dato;
        private string _nummerplade;
        public bool AnvendtBrobizz;
        public decimal Rabat = 0.95m;

        public abstract decimal Pris();

        public abstract string Køretøj();

        public decimal CalcBrobizz(decimal pris) // Smarteste måde? Kunne ikke få det til at fungere.
        {
            if (AnvendtBrobizz)
            {
                return pris * Rabat;
            }

            return pris;
        }
    }
    }

