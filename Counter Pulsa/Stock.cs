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

        public Stock()
        {

            kartu = new List<Kartu_AS>(); 
        }
     
    }
}
