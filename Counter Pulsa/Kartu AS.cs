using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Counter_Pulsa
{
    class Kartu_AS
    {
        public int deposit;
        public int depositTambah;
        public string tanyaUlang;
        public string jenisPulsa;
        public int pulsaDibeli;
        public int pulsaJual;
        public int hargaPulsa;
        public int laba;
        public string hp;
        
        public void KartuAS()
        {
            //input deposit
            Console.Clear();
            Console.Write("Deposit Awal : Rp. ");
            deposit = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.Clear();
                Stock stock = new Stock();
                stock.utama();
                Console.SetCursorPosition(5, 6); Console.WriteLine("Deposit = {0}", deposit);
                Console.SetCursorPosition(5, 9); Console.WriteLine("1.AS");
                Console.SetCursorPosition(5, 11); Console.WriteLine("2.SIMPATI");
                Console.SetCursorPosition(5, 13); Console.WriteLine("3.XL");
                Console.SetCursorPosition(50, 9); Console.WriteLine("4.IM3");
                Console.SetCursorPosition(50, 11); Console.WriteLine("5.MENTARI");
                Console.SetCursorPosition(50, 13); Console.WriteLine("6.AXIS");
                Console.SetCursorPosition(5, 15); Console.Write("Jenis pulsa yang dibeli : ");
                jenisPulsa = Console.ReadLine();
                Console.SetCursorPosition(5, 16); Console.Write("Masukkan nomer HP       : ");
                hp = Console.ReadLine();
                if (hp.Trim().Length <= 9 || hp.Trim().Length >= 12)
                {
                    Console.WriteLine("Digit Nomor min-10 max-12 digit");
                }
                else
                    Console.SetCursorPosition(5, 17); Console.Write("Besar pulsa yang dibeli : Rp. ");
                pulsaDibeli = Convert.ToInt32(Console.ReadLine());

                //Seleksi harga pulsa
                if (pulsaDibeli <= 25000)
                { pulsaJual = pulsaDibeli + 1000; }
                else { pulsaJual = pulsaDibeli + 500; }

                //Seleksi operator
                switch (jenisPulsa)
                {
                    case "1":
                        hargaPulsa = pulsaJual;
                        break;
                    case "2":
                        hargaPulsa = pulsaJual + 500;
                        break;
                    case "3":
                        hargaPulsa = pulsaJual - 500;
                        break;
                    case "4":
                        if (pulsaJual >= 25000)
                        {
                            hargaPulsa = pulsaJual - 500;
                        }
                        else { hargaPulsa = pulsaJual - 1000; }
                        break;
                    case "5":
                        hargaPulsa = pulsaJual + 1000;
                        break;
                }

                //Proses
                Console.WriteLine();
                deposit = deposit - pulsaDibeli;
                laba = laba + (hargaPulsa - pulsaDibeli);

                //sisa deposit
                if (deposit < pulsaDibeli)
                {
                    Console.WriteLine("\tMaaf deposit pulsa anda tidak mencukupi transaksi ini");
                    Console.Write("\tMasukkan tambahan deposit : Rp. ");
                    depositTambah = Convert.ToInt32(Console.ReadLine());
                    deposit = deposit + depositTambah;
                    Console.WriteLine();
                }

                //Laporan
                Console.WriteLine("\tharga jual   : Rp. {0}",
                                 hargaPulsa.ToString());
                Console.WriteLine("\tDeposit sisa : Rp. {0} ",
                                 deposit.ToString());
                Console.WriteLine("\t-----------------------------");
                Console.WriteLine();
                Console.Write("\tApakah ada transaksi lagi? [Y/T] : ");
                tanyaUlang = Console.ReadLine();
            } while (tanyaUlang.ToLower() == "y");
            
            Console.WriteLine();
            Console.WriteLine("\t------------------------------");
            Console.WriteLine("\tSisa deposit : Rp {0}", deposit);
            Console.WriteLine("\tKeuntungan   : Rp {0}", laba);
            Console.WriteLine("\t------------------------------");
            Console.WriteLine();

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey();
        }
    }
}