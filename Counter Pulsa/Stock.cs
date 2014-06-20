using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Counter_Pulsa
{
    class Stock
    {
        List<Kartu_AS> kartu;

        public void utama()
        {
            Console.WriteLine("||===========================================================================||");
            Console.WriteLine("||                                                                           ||");
            Console.WriteLine("||                      SELAMAT DATANG DI COUNTER PULSA                      ||");
            Console.WriteLine("||                                HEMAT FULL                                 ||");
            Console.WriteLine("||                                                                           ||");
            Console.WriteLine("||===========================================================================||");
        }
        Random rnd = new Random();
        public void isivoucer()
        {
            int angka = rnd.Next(0,10);
            int angka1 = rnd.Next(0, 10);
            int angka2 = rnd.Next(0, 10);
            int angka3 = rnd.Next(0, 10);
            int angka4 = rnd.Next(0, 10);
            int angka5 = rnd.Next(0, 10);
            int angka6 = rnd.Next(0, 10);
            int angka7 = rnd.Next(0, 10);
            int angka8 = rnd.Next(0, 10);
            int angka9 = rnd.Next(0, 10);
            int angka10 = rnd.Next(0, 10);
            int angka11 = rnd.Next(0, 10);
            int angka12 = rnd.Next(0, 10);
            int angka13 = rnd.Next(0, 10);
            int angka14 = rnd.Next(0, 10);
            int angka15 = rnd.Next(0, 10);
            Console.WriteLine("kode voucer pulsa anda adalah {0}{1}{2}{3} {4}{5}{6}{7} {8}{9}{10}{11} {12}{13}{14}{15} ", angka, angka1, angka2, angka3, angka4, angka5, angka6, angka7, angka8, angka9, angka10, angka11, angka12, angka13, angka14, angka15);
            Console.ReadKey();
        }// creates a number between 1 and 12

        public Stock()
        {

            kartu = new List<Kartu_AS>(); 
        }
     
    }
}
