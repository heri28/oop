using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Counter_Pulsa
{
    class Stock
    {
        List<pulsa> pulsa;
        List<Voucher> voucher;
        List<Token> token;

        public void utama()
        {
            Console.WriteLine("||===========================================================================||");
            Console.WriteLine("||                                                                           ||");
            Console.WriteLine("||                      SELAMAT DATANG DI COUNTER PULSA                      ||");
            Console.WriteLine("||                               MIKRO - CELL                                ||");
            Console.WriteLine("||                                                                           ||");
            Console.WriteLine("||===========================================================================||");
        }

        public Stock()
        {
            pulsa = new List<pulsa>();
            voucher = new List<Voucher>();
            token = new List<Token>();
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

        public void TampilTransaksi()
        {
            Console.Write("\n");
            Console.WriteLine("Laporan Transaksi Counter Pulsa Mikro-Cell");
            Console.WriteLine("===========================================");
            Console.WriteLine("Transaksi Penjualan Pulsa");
            Console.WriteLine("**************************");
            foreach (pulsa j in pulsa)
                j.detailpulsa();
            Console.Write("\n");
            Console.WriteLine("Transaksi Penjualan Voucher Pulsa");
            Console.WriteLine("**********************************");
            foreach (Voucher j in voucher)
                j.detailvoucher();
            Console.Write("\n");
            Console.WriteLine("Transaksi Penjualan Pulsa Listrik");
            Console.WriteLine("**********************************");
            foreach (Token j in token)
                j.detailToken();
        }

        public void jualVoucher()
        {
            voucher.Add(new Voucher());
            string tmp = voucher.Last().novoucher;
            if (voucher.Count >= 2)
                for (int i = 0; i < voucher.Count - 1; i++)
                    if (voucher[i].novoucher == tmp)
                    {
                        voucher.RemoveAt(i);
                        break;
                    }
        }

        public void jualToken()
        {
            token.Add(new Token());
            string tmp = token.Last().nometer;
            if (token.Count >= 2)
                for (int i = 0; i < token.Count - 1; i++)
                    if (token[i].nometer == tmp)
                    {
                        token.RemoveAt(i);
                        break;
                    }
        }
    }
}
