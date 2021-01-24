using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer oyuncu1 = new Customer();
            oyuncu1.TcNo = "1532123";
            oyuncu1.Ad = "Ali";
            oyuncu1.Soyad = "Akar";
            oyuncu1.Dogumyili = "10.01.1989";
           

            Customer oyuncu2 = new Customer();
            oyuncu2.TcNo = "1123523";
            oyuncu2.Ad = "Samet";
            oyuncu2.Soyad = "Kalem";
            oyuncu2.Dogumyili = "10.08.1999";

            //----------------------------------------
            Games oyun1= new Games();
            oyun1.OyunAdi = "FİFA";
            oyun1.Fiyati = "120";

            Games oyun2 = new Games();
            oyun2.OyunAdi = "GTA";
            oyun2.Fiyati = "100";

            Console.WriteLine("Tc Numarası : "+oyuncu1.TcNo+" | "+"Oyuncu Adı :  "+oyuncu1.Ad+ " | " + "Soyadı :  "+oyuncu1.Soyad+ " | " + "Doğum Tarihi :  "+oyuncu1.Dogumyili);
            Console.WriteLine("Tc Numarası : " + oyuncu2.TcNo + " | " + "Oyuncu Adı :  " + oyuncu2.Ad + " | " + "Soyadı :  " + oyuncu2.Soyad + " | " + "Doğum Tarihi :  " + oyuncu2.Dogumyili);

            Console.WriteLine("---------------------");

            Console.WriteLine(oyun1.OyunAdi + " Fiyat--> " + oyun1.Fiyati);
            Console.WriteLine(oyun2.OyunAdi + " Fiyat--> " + oyun2.Fiyati);

            Console.WriteLine("---------------------");

      

            Console.WriteLine(oyuncu2.Ad + " Adlı Kulanıcı Satın Aldı :  " + oyun2.OyunAdi + " Fiyat--> " + oyun2.Fiyati);
            Console.WriteLine(oyuncu1.Ad+" Adlı Kulanıcı Satın Aldı :  " +oyun1.OyunAdi + " Fiyat--> " + oyun1.Fiyati);

            Console.WriteLine("---------------------");

            Kampanya kampanya = new Kampanya();
            kampanya.Add(oyun1);
            kampanya.Add(oyun2);

            Console.WriteLine("---------------------");

            Manager manager1 = new Manager();
            manager1.ekle();

            Manager manager2 = new Manager();
            manager2.güncelle();

            Manager manager3 = new Manager();
            manager3.sil();




            Console.ReadKey();
        }

    }
}
