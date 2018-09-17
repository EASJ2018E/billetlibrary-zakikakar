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
        public bool AnvendtBrobizz;
        public double Rabat = 0.95;

        public decimal Pris()
        {
            throw new NotImplementedException();
        }

        public string Køretøj()
        {
            throw new NotImplementedException();
        }
        //public decimal Brobizz() // Smarteste måde? Kunne ikke få det til at fungere.
        //{ 
            //throw new NotImplementedException();
        
            //if (AnvendtBrobizz == true)
            //{
            //    return Pris() * (decimal)Rabat;

            //}

            //return Pris();
        //}
        }
    }

