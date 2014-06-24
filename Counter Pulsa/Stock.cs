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
            voucher = new List<Voucher>();
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
            Console.WriteLine("Transaksi Penjualan Pulsa");
            foreach (pulsa j in pulsa)
                j.detailpulsa();
            Console.WriteLine("Transaksi Penjualan Voucher Pulsa");
            foreach (Voucher j in voucher)
                j.detailvoucher();
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
    }
}
