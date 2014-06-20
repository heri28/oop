using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Counter_Pulsa
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            
            Console.Clear();
            bool cek, cek1 = true;
            
            do
            {
                cek1 = true;
                Console.Clear();
                Console.Title = "Counter_Pulsa";
                Stock stock = new Stock();
                stock.utama();
               
                Kartu_AS kartuas = new Kartu_AS();
                Console.SetCursorPosition(5, 8); Console.WriteLine("1. Isi Pulsa Elektrik"); Console.SetCursorPosition(50, 8); Console.Write("Isi Pulsa Listrik .3");
                Console.SetCursorPosition(5, 10); Console.Write("2. Pulsa Voucher"); Console.SetCursorPosition(50, 10); Console.Write("Pembayaran PDAM   .4");
                Console.SetCursorPosition(50, 12); Console.Write("Lihat Laporan     .5");
                Console.Write("\nPilihan: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        do
                        {
                            cek = true;
                            kartuas.KartuAS();
                        } while (cek == true);
                        break;
                    case "2":
                        stock.isivoucer();
                    break;
                }
            } while (cek1);
            
                
        }
    }
}
