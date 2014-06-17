using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Counter_Pulsa
{
    class Kartu_AS
    {
        public bool cek2;
        public struct hargaSatuan
        {
            public int pulsa5;
            public int pulsa10;
            public int pulsa20;
            public int pulsa50;
            public int pulsa100;
        }
        //public string hp;
        public int harga, kembalian;

        public Kartu_AS()
        {
            hargaSatuan a;
            ConsoleKeyInfo key1;
            do
            {
               cek2 = true;                    
                    Console.Clear();
                    Stock stock = new Stock();
                    stock.utama();
                    Console.WriteLine("\nPilih Nominal Pulsa : ");
                    Console.SetCursorPosition(5, 9); Console.WriteLine("1. 100.000");
                    Console.SetCursorPosition(5, 11); Console.WriteLine("2. 50.000");
                    Console.SetCursorPosition(5, 13); Console.WriteLine("3. 20.000");
                    Console.SetCursorPosition(50, 9); Console.WriteLine("4. 10.000");
                    Console.SetCursorPosition(50, 11); Console.WriteLine("5. 5.000");
                    Console.SetCursorPosition(50, 13); Console.WriteLine("0. Kembali");
                    Console.Write("\n\n\nPilihan: ");
                    key1 = Console.ReadKey();
                    switch (key1.KeyChar)
                    {
                        case '1':
                            a.pulsa100 = 99000;
                            Console.SetCursorPosition(5, 20); Console.WriteLine("Harga       = Rp. " + a.pulsa100);
                            Console.SetCursorPosition(5, 21); Console.Write("Bayar       = Rp. ");
                            harga = Convert.ToInt32(Console.ReadLine());
                            kembalian = harga - a.pulsa100;
                            Console.SetCursorPosition(5, 22); Console.WriteLine("Kembalian   = Rp. " + kembalian);
                            Console.WriteLine("\nPulsa Berhasil Diisi Silakan Dicek");
                            Console.ReadKey();
                            break;
                        case '2':
                            a.pulsa50 = 49000;
                            Console.SetCursorPosition(5, 20); Console.WriteLine("Harga       = Rp. " + a.pulsa50);
                            Console.SetCursorPosition(5, 21); Console.Write("Bayar       = Rp. ");
                            harga = Convert.ToInt32(Console.ReadLine());
                            kembalian = harga - a.pulsa50;
                            Console.SetCursorPosition(5, 22); Console.WriteLine("Kembalian   = Rp. " + kembalian);
                            Console.WriteLine("\nPulsa Berhasil Diisi Silakan Dicek");
                            Console.ReadKey();
                            break;
                        case '3':
                            a.pulsa20 = 22000;
                            Console.SetCursorPosition(5, 20); Console.WriteLine("Harga       = Rp. " + a.pulsa20);
                            Console.SetCursorPosition(5, 21); Console.Write("Bayar       = Rp. ");
                            harga = Convert.ToInt32(Console.ReadLine());
                            kembalian = harga - a.pulsa20;
                            Console.SetCursorPosition(5, 22); Console.WriteLine("Kembalian   = Rp. " + kembalian);
                            Console.WriteLine("\nPulsa Berhasil Diisi Silakan Dicek");
                            Console.ReadKey();
                            break;
                        case '4':
                            a.pulsa10 = 11000;
                            Console.SetCursorPosition(5, 20); Console.WriteLine("Harga       = Rp. " + a.pulsa10);
                            Console.SetCursorPosition(5, 21); Console.Write("Bayar       = Rp. ");
                            harga = Convert.ToInt32(Console.ReadLine());
                            kembalian = harga - a.pulsa10;
                            Console.SetCursorPosition(5, 22); Console.WriteLine("Kembalian   = Rp. " + kembalian);
                            Console.WriteLine("\nPulsa Berhasil Diisi Silakan Dicek");
                            Console.ReadKey();
                            break;
                        case '5':
                            a.pulsa5 = 6000;
                            Console.SetCursorPosition(5, 20); Console.WriteLine("Harga       = Rp. " + a.pulsa5);
                            Console.SetCursorPosition(5, 21); Console.Write("Bayar       = Rp. ");
                            harga = Convert.ToInt32(Console.ReadLine());
                            kembalian = harga - a.pulsa5;
                            Console.SetCursorPosition(5, 22); Console.WriteLine("Kembalian   = Rp. " + kembalian);
                            Console.WriteLine("\nPulsa Berhasil Diisi Silakan Dicek");
                            Console.ReadKey();
                            break;
                        case '0':
                            cek2 = false;
                            stock.utama();
                            break;
                        default:
                            break;
                    }
            } while (cek2 == true);
        }
    }
}