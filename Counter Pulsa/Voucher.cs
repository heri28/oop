using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Counter_Pulsa
{
    class Voucher
    {
        public string novoucher;
        public string jenisVoucher;

        public Voucher()
        {
            Random rnd = new Random();
            int angka = rnd.Next(100000000, 999999999);
            int angka1 = rnd.Next(888888888, 999999999);
            novoucher = Convert.ToString(angka + angka1 + 9999999);
            Console.SetCursorPosition(5, 9); Console.WriteLine("1.10000");
            Console.SetCursorPosition(5, 11); Console.WriteLine("2.20000");
            Console.SetCursorPosition(5, 13); Console.WriteLine("3.50000");
            Console.SetCursorPosition(50, 9); Console.WriteLine("4.100000");
            Console.SetCursorPosition(50, 11); Console.WriteLine("5.500000");
            Console.SetCursorPosition(50, 13); Console.WriteLine("0.KEMBALI");
            Console.WriteLine("");
            Console.Write("Pilihan => ");
            jenisVoucher = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n");
            switch (jenisVoucher)
            {
                case "1":
                    Console.WriteLine("Kode voucer pulsa 10 Ribu {0}", novoucher);
                    break;
                case "2":
                    Console.WriteLine("Kode voucer pulsa 20 Ribu {0}", novoucher);
                    break;
                case "3":
                    Console.WriteLine("Kode voucer pulsa 50 Ribu {0}", novoucher);
                    break;
                case "4":
                    Console.WriteLine("Kode voucer pulsa 100 Ribu {0}", novoucher);
                    break;
                case "5":
                    Console.WriteLine("Kode voucer pulsa 500 Ribu {0}", novoucher);
                    break;
            }
            Console.ReadKey();
        }

        public void detailvoucher()
        {
            Console.WriteLine("[{0}] {1}",jenisVoucher,novoucher);
        }

    }
}
