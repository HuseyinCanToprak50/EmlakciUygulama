using EmlakciUygLib;
using System.Security.Cryptography;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace EmlakciUygulama
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            List<Ev> liste = new List<Ev>();

            string dosyaYolu = @"C:\Users\Asus\Desktop\kiralikEv.txt";
            string dosyaYolu1 = @"C:\Users\Asus\Desktop\SatilikkEv.txt";


          
            Console.Write(" 1-Kiralık Ev \n 2-Satılık Ev  \n Seçiminiz:> ");
            string cvp = Console.ReadLine(); 

            if (cvp == "1")
            {
                Console.WriteLine(" A-Kayıtlı Ev Görüntüleme \n B-Yeni Ev Girisi");
                string altCvp = Console.ReadLine();
                if (altCvp == "a".ToLower())
                {

                    EvBilgisiGoruntule(dosyaYolu);
                }
                if (altCvp == "b".ToLower())
                {
                    KEvBilgisiEkle(dosyaYolu,liste);

                }


            }
            else if (cvp == "2")
            {

                Console.WriteLine(" A-Kayıtlı Ev Görüntüleme \n B-Yeni Ev Girisi");
                string altCvp = Console.ReadLine();
                if (altCvp == "a".ToLower())
                {

                    EvBilgisiGoruntule(dosyaYolu1);
                }
                if (altCvp == "b".ToLower())
                {
                    SEvBilgisiEkle(dosyaYolu1,liste);
                }
            }
           
            foreach (var girilenEvler in liste) 
            {

               if(girilenEvler is SatilikEv)
                {
                    Console.WriteLine("GİRİLEN EV BİLGİLERİ");
                    SatilikEv Sev = (SatilikEv)girilenEvler;
                    Console.WriteLine(Sev.EvBilgileri());
                }
               else if(girilenEvler is KiralikEv)
                {
                    KiralikEv Kev = (KiralikEv)girilenEvler;
                    Console.WriteLine(Kev.EvBilgileri());
                }
            }

           


        }
        
       
        public static void EvBilgisiGoruntule(string FileRead)
        {
           

            using (StreamReader oku = new StreamReader(FileRead))
            {
                

                string icerik = oku.ReadToEnd();
                //  Console.WriteLine(icerik);
                
                 if (icerik == "")
                {
                    Console.WriteLine("EV KAYDI GÖRÜNTÜLENEMEDİ!");
                }
                else
                {
                    Console.WriteLine(icerik);

                }

            }

        }

        public static void KEvBilgisiEkle(string WrıteAdd , List<Ev> list)
        {


            string cvp;
            int sayac = 1;
            do
            {
                using (StreamWriter yaz = new StreamWriter(WrıteAdd,true))
                {
                    Console.WriteLine($"{sayac++}.KİRALIK EV BİLGİLERİNİ GİRİNİZ \n Oda Sayısı giriniz");
                    int katno = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{sayac++}. Evin Kat No Giriniz");
                    int odaSayisi = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{sayac++}. Evin Alan Giriniz");
                    int alan = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{sayac++}. Evin Depozito Giriniz");
                    int depozito = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{sayac++}. Evin Kira Fiyatı Girin>");
                    int kira = int.Parse(Console.ReadLine());

                    KiralikEv ev = new KiralikEv(kira, depozito, odaSayisi, katno, alan);
                    list.Add(ev);

                    yaz.WriteLine($" {sayac++}. EV \n Kira:{kira} \n Depozito {depozito} \n Oda Sayısı {odaSayisi} \n Kat No {katno} \n Alan: {alan}");
                    yaz.WriteLine("-------------------------------------------");

                    Console.WriteLine("Tamam/Devam?");
                    cvp = Console.ReadLine();

                }
            } while (cvp == "d".ToLower());
            Console.WriteLine("KAYDINIZ BAŞARI İLE EKLENMİŞTİR");



        }


        public static void SEvBilgisiEkle(string WrıteAdd , List<Ev> list)
        {

      
            string cvp;
            int sayac = 1;
          
            do
            {
                using (StreamWriter yaz = new StreamWriter(WrıteAdd, true))
                {
                    Console.WriteLine($" {sayac++} SATILIK EV BİLGİLERİ GİRİNİZ \n Oda Sayısı giriniz");
                    int  katno = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{sayac++}. Evin  Kat No Giriniz");
                    int odaSayisi = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{sayac++}. Evin Alan Giriniz");
                    int alan = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{sayac++}. Evin Depozito Giriniz");
                    int depozito = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{sayac++}. Evin Satış Fiyatı Girin");
                    int fiyat = int.Parse(Console.ReadLine());
                    
                    SatilikEv ev = new SatilikEv(fiyat, depozito, odaSayisi, katno, alan);
                    list.Add(ev);

                    yaz.WriteLine($" {sayac++}. EV \n Satış Fiyatı:{fiyat} \n Depozito {depozito} \n Oda Sayısı {odaSayisi} \n Kat No {katno} \n Alan: {alan}");
                    yaz.WriteLine("-------------------------------------------");

                    Console.WriteLine("Tamam/Devam?");
                    cvp = Console.ReadLine();

                }
            } while (cvp == "d".ToLower());

           
            Console.WriteLine("KAYDINIZ BAŞARI İLE EKLENMİŞTİR");

          
          


        }




    }
    

}