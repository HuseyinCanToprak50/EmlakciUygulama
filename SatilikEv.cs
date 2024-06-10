using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace EmlakciUygLib
{
    public class SatilikEv:Ev
    {

        
        public int Fiyat { get; set; }
        public int Depozito { get; set; }

        public SatilikEv()
        {
            //default
        }
        public SatilikEv(int fiyat, int depozito , int odasayisi , int katno , int alan ):base(odasayisi ,katno , alan ) 
        {
           this. Fiyat = fiyat;
           this. Depozito = depozito;
        }

        public  string EvBilgileri() 
        {
            return $" Fiyat :{this.Fiyat} \n  Depozito: {this.Depozito} \n  Oda Sayısı: {base.OdaSayisi} \n Katno: {base.Katno} \n Alan {base.Alan}";
        }
    }
}
