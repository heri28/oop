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
            string hp;
            Console.Clear();
            ConsoleKeyInfo key;
            bool cek1 = true;
            do
            {
                cek1 = true;
                Console.Clear();
                Console.Title = "Counter_Pulsa";
                Stock stock = new Stock();
                stock.utama();

                Console.SetCursorPosition(5, 9); Console.WriteLine("1. AS");
                Console.SetCursorPosition(5, 11); Console.WriteLine("2. Simpati");
                Console.SetCursorPosition(5, 13); Console.WriteLine("3. Axis");
                Console.SetCursorPosition(50, 9); Console.WriteLine("4. XL");
                Console.SetCursorPosition(50, 11); Console.WriteLine("5. IM3");
                Console.SetCursorPosition(50, 13); Console.WriteLine("6. Tree");
                Console.SetCursorPosition(5, 15); Console.WriteLine("0. kembali");
                Console.Write("\nPilihan: ");
                key = Console.ReadKey();
                    switch (key.KeyChar)
                    {
                        case '1':
                            Console.SetCursorPosition(5, 18); Console.Write("\nMasukan Nomor Handphone : ");
                            hp = Console.ReadLine();
                            if (hp.Length <= 9 || hp.Length >= 13)
                            {
                                Console.WriteLine("\nDigit Nomor min-10 max-12 digit");
                            }
                            else
                            {
                                if (hp.Substring(0, 4) == "0852" || hp.Substring(0, 4) == "0853" || hp.Substring(0, 4) == "0823")
                                {
                                    Kartu_AS kartuas = new Kartu_AS();
                                }
                                else
                                    Console.WriteLine("Nomor tidak sesuai dengan jenis kartu !");
                            }
                            Console.ReadKey();
                            break;
                        case '2':
                                Console.SetCursorPosition(5, 18); Console.Write("\nMasukan Nomor Handphone : ");
                                hp = Console.ReadLine();
                                if (hp.Length <= 9 || hp.Length >= 13)
                                {
                                    Console.WriteLine("\nDigit Nomor min-10 max-12 digit");
                                }
                                else
                                {
                                    if (hp.Substring(0, 4) == "0821" || hp.Substring(0, 4) == "0812" || hp.Substring(0, 4) == "0813"
                                            || hp.Substring(0, 4) == "0822" || hp.Substring(0, 4) == "0811")
                                    {
                                        Kartu_AS kartuas = new Kartu_AS();
                                    }
                                    else
                                        Console.WriteLine("Nomor tidak sesuai dengan jenis kartu !");
                                }
                                Console.ReadKey();
                            break;
                        case '3':
                                Console.SetCursorPosition(5, 18); Console.Write("\nMasukan Nomor Handphone : ");
                                hp = Console.ReadLine();
                                if (hp.Length <= 9 || hp.Length >= 13)
                                {
                                    Console.WriteLine("\nDigit Nomor min-10 max-12 digit");
                                }
                                else
                                {
                                    if (hp.Substring(0, 4) == "0831" || hp.Substring(0, 4) == "0838")
                                    {
                                        Kartu_AS kartuas = new Kartu_AS();
                                    }
                                    else
                                        Console.WriteLine("Nomor tidak sesuai dengan jenis kartu !");
                                }
                                Console.ReadKey();
                            break;
                        case '4':
                                Console.SetCursorPosition(5, 18); Console.Write("\nMasukan Nomor Handphone : ");
                                hp = Console.ReadLine();
                                if (hp.Length <= 9 || hp.Length >= 13)
                                {
                                    Console.WriteLine("\nDigit Nomor min-10 max-12 digit");
                                }
                                else
                                {
                                    if (hp.Substring(0, 4) == "0817" || hp.Substring(0, 4) == "0818" || hp.Substring(0, 4) == "0819"
                                            || hp.Substring(0, 4) == "0859" || hp.Substring(0, 4) == "0877" || hp.Substring(0, 4) == "0878"
                                            || hp.Substring(0, 4) == "0879")
                                    {
                                        Kartu_AS kartuas = new Kartu_AS();
                                    }
                                    else
                                        Console.WriteLine("Nomor tidak sesuai dengan jenis kartu !");
                                }
                                Console.ReadKey();
                            break;
                        case '5':
                                Console.SetCursorPosition(5, 18); Console.Write("\nMasukan Nomor Handphone : ");
                                hp = Console.ReadLine();
                                if (hp.Length <= 9 || hp.Length >= 13)
                                {
                                    Console.WriteLine("\nDigit Nomor min-10 max-12 digit");
                                }
                                else
                                {
                                    if (hp.Substring(0, 4) == "0856" || hp.Substring(0, 4) == "0857")
                                    {
                                        Kartu_AS kartuas = new Kartu_AS();
                                    }
                                    else
                                        Console.WriteLine("Nomor tidak sesuai dengan jenis kartu !");
                                }
                                Console.ReadKey();
                            break;
                        case '6':
                                Console.SetCursorPosition(5, 18); Console.Write("\nMasukan Nomor Handphone : ");
                                hp = Console.ReadLine();
                                if (hp.Length <= 9 || hp.Length >= 13)
                                {
                                    Console.WriteLine("\nDigit Nomor min-10 max-12 digit");
                                }
                                else
                                {
                                    if (hp.Substring(0, 4) == "0896" || hp.Substring(0, 4) == "0897" || hp.Substring(0, 4) == "0898"
                                            || hp.Substring(0, 4) == "0899")
                                    {
                                        Kartu_AS kartuas = new Kartu_AS();
                                    }
                                    else
                                        Console.WriteLine("Nomor tidak sesuai dengan jenis kartu !");
                                }
                                Console.ReadKey();
                            break;

                        case '0':
                            cek1 = false;
                            break;
                    }
                
            } while (cek1);
            
                
        }
    }
}
