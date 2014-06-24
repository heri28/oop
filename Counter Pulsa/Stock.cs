using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Counter_Pulsa
{
    class Stock
    {
        List<pulsa> pulsa;

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
            pulsa = new List<pulsa>(); 
        }

        public void jualPulsa()
        {
            pulsa.Add(new pulsa());
            string tmp = pulsa.Last().hp;
            if (pulsa.Count >= 2)
                for (int i = 0; i < pulsa.Count - 1; i++)
                    if (pulsa[i].hp == tmp)
                    {
                        pulsa.RemoveAt(i);
                        break;
                    }
        }

        public void TampilPulsa()
        {
            Console.WriteLine("Terdapat beberapa transaksi");
            foreach (pulsa j in pulsa)
                j.detailpulsa();
        }

        public void isivoucer()
        {
            ConsoleKeyInfo jenisVoucher;
            Random rnd = new Random();
            int angka = rnd.Next(100000, 999999);
            int angka1 = rnd.Next(2000000, 8888888);
            Console.SetCursorPosition(5, 9); Console.WriteLine("1.10000");
            Console.SetCursorPosition(5, 11); Console.WriteLine("2.20000");
            Console.SetCursorPosition(5, 13); Console.WriteLine("3.50000");
            Console.SetCursorPosition(50, 9); Console.WriteLine("4.100000");
            Console.SetCursorPosition(50, 11); Console.WriteLine("5.500000");
            Console.SetCursorPosition(50, 13); Console.WriteLine("0.KEMBALI");
            Console.WriteLine("");
            Console.Write("Pilihan => ");
            jenisVoucher = Console.ReadKey();
            Console.WriteLine("\n");
            switch (jenisVoucher.KeyChar)
            {
                case '1' :
                    Console.WriteLine("Kode voucer pulsa 10 Ribu {0}{1} ", angka, angka1);
                    break;
                case '2':
                    Console.WriteLine("Kode voucer pulsa 20 Ribu {0}{1} ", angka, angka1);
                    break;
                case '3':
                    Console.WriteLine("Kode voucer pulsa 50 Ribu {0}{1} ", angka, angka1);
                    break;
                case '4':
                    Console.WriteLine("Kode voucer pulsa 100 Ribu {0}{1} ", angka, angka1);
                    break;
                case '5':
                    Console.WriteLine("Kode voucer pulsa 500 Ribu {0}{1} ", angka, angka1);
                    break;
            }
            Console.ReadKey();
        }
    }
}
