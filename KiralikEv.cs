using System;
using System.Collections.Generic;
using System.Text;

namespace EmlakciUygLib
{
    public class KiralikEv:Ev
    {
        private int kira;
        

        public int Kira { get=>this.kira; set=> kira=Math.Abs(value); }
        public int Depozito {  get; set; }

      public  KiralikEv()
        {
            //default
        }
      public  KiralikEv(int kira, int depozito , int odasayisi , int katno , int alan):base(odasayisi ,katno,alan)
        {
             this.Kira = kira;
            this.Depozito = depozito;
          
        }

        public  string  EvBilgileri()
        {
            return $" Kira :{this.Kira} \n  Depozito: {this.Depozito} \n  Oda Sayısı: {base.OdaSayisi} \n Katno: {base.Katno} \n Alan {base.Alan}";
        }
    }
}
