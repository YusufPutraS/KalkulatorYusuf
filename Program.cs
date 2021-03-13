using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pilih menu")
            Console.WriteLine("1.Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");

            Console.Write("Pilih [1...4]: ");
            string operand = Console.ReadLine();

            if (operand == "1")
            {
                Console.Write("Bilangan 1: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Bilangan 2: ");
                int b = int.Parse(Console.ReadLine());

                Console.Write("{0} + {1} = {2}", a, b, penambahan(a, b));
            }
            else if (operand == "1")
            {
                Console.Write("Bilangan 1: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Bilangan 2: ");
                int b = int.Parse(Console.ReadLine());

                Console.Write("{0} - {1} = {2}", a, b, pengurangan(a, b));
            }
            else if (operand == "1")
            {
                Console.Write("Bilangan 1: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Bilangan 2: ");
                int b = int.Parse(Console.ReadLine());

                Console.Write("{0} * {1} = {2}", a, b, pengalian(a, b));
            }
            else if (operand == "1")
            {
                Console.Write("Bilangan 1: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Bilangan 2: ");
                int b = int.Parse(Console.ReadLine());

                Console.Write("{0} / {1} = {2}", a, b, pembagian(a, b));
            }
        }


                    static int penambahan(int a, int b)
        {
            return a + b;
        }

        static int pengurangan(int a, int b);
        {
            return a - b;
        }

        static int pembagian(int a, int b);
        {
            return a / b;
        }

        static int perkalian(int a, int b);
        {
            return a * b;
        }
}

Console.ReadLine();
        }

Console.Title = "Aplikasi Kalkulator";

            int a = 10; // declarasi variabel a,dg  nilai awal 10;
            int a = 6; // declarasi variabel b,dg  nilai awal 6;)

            Console.WriteLine(Hasil Penambahan " + a + " + " + b + " = +Penambahan(a, b));
            Console.Write("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            Console.Write("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            Console.Write("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            console.ReadKey(

            Console.WriteLine();
            Console.WriteLine("Tekan sembarang key untuk keluar");
            Console.ReadKey();

Environment.Exit(0);
  
        }


    }
// Credit : Yusuf Putra Santoso [20.11.3337]
