using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Counter_Pulsa
{
    class pulsa
    {
        public int deposit;
        public int depositTambah;
        public int pulsaDibeli;
        public int pulsaJual;
        public int hargaPulsa = 0;
        public int laba = 0;
        public string hp { get; set; }
        ConsoleKeyInfo jenisPulsa;
        bool cek2,cek3 = true;


        public pulsa()
        {
            Console.SetCursorPosition(5, 17); Console.Write("Jenis pulsa yang dibeli : ");
            jenisPulsa = Console.ReadKey();
            do
            {
                cek2 = true;
                Console.SetCursorPosition(5, 19); Console.Write("Masukkan Nomor HP : ");
                hp = Console.ReadLine();
            } while (cek2 == false);
            if (hp.Length <= 9 || hp.Length >= 13)
            {
                Console.WriteLine("\tNomor HP error, Periksa Nomor HP");
            }
            else
            {
                 do
                {
                 cek3 = true;
                Console.SetCursorPosition(5, 21); Console.Write("Nominal Pulsa : ");
                pulsaDibeli = Convert.ToInt32(Console.ReadLine());
                } while (cek3 == false);
                if (pulsaDibeli != 5000 && pulsaDibeli != 10000 && pulsaDibeli != 20000
                    && pulsaDibeli != 50000 && pulsaDibeli != 100000)
                {
                    Console.WriteLine("Pulsa tidak tersedia !");
                    Console.WriteLine("Hanya tersedia pulsa 5000, 10000, 20000, 50000, 100000");
                    cek3 = false;
                }
                else
                {
                    if (pulsaDibeli <= 25000)
                    { pulsaJual = pulsaDibeli + 1000; }
                    else { pulsaJual = pulsaDibeli + 500; }

                    switch (jenisPulsa.KeyChar)
                    {

                        case '1':
                            hargaPulsa = pulsaJual;
                            break;
                        case '2':
                            hargaPulsa = pulsaJual + 500;
                            break;
                        case '3':
                            hargaPulsa = pulsaJual + 500;
                            break;
                        case '4':
                            hargaPulsa = pulsaJual - 500;
                            break;
                        case '5':
                            if (pulsaJual >= 25000)
                            {
                                hargaPulsa = pulsaJual - 500;
                            }
                            else { hargaPulsa = pulsaJual - 1000; }
                            break;
                        case '6':
                            hargaPulsa = pulsaJual + 1000;
                            break;
                        case '0':
                            cek2 = false;
                            break;
                        default:
                            break;
                    }
                    Console.SetCursorPosition(5, 22); Console.WriteLine("harga jual    : {0} IDR",
                                     hargaPulsa.ToString());
                    Console.SetCursorPosition(5, 23); Console.WriteLine("-----------------------------");
                }
            }
        }

        public void detailpulsa()
        {
            Console.WriteLine("[{0}] {1}",hp, pulsaDibeli);
        }
    }
}
