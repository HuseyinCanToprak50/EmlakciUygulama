using System;

namespace EmlakciUygLib
{
    public class Ev
    {

       

      
        public int OdaSayisi { get; set; }
        public int Katno { get; set; }
        public int Alan { get; set; }



        public Ev()
        {
        }
        public Ev(int odasayisi , int katno , int alan)
        {
            this.OdaSayisi = odasayisi ;  
            this.Katno = katno ;
            this.Alan = alan ;  
        }

        public  string EvBilgileri()
        {
            return $" Oda Sayısı: {this.OdaSayisi} \n Kat No: {this.Katno}  \n Alan: {this.Alan} \n";
        }


    }
}
