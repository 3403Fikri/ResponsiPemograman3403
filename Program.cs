using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ResponsiPemograman3403
{
    class Program
    {
        static string formatuang(int angka)
        {
            return String.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N}", angka);
        }
        static void Main(string[] args)
        {
            Karyawan kar1 = new Karyawan("123123", "Fikri", 200000);
            Karyawan kar2 = new Karyawan("423432", "Orang", 500000);
            Console.WriteLine("\nNO Nik/Nama            Gaji Bulanan");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1. {0} {1}       {2}", kar1.nik, kar1.nama, formatuang((int) kar1.gaji));
            Console.WriteLine("1. {0} {1}       {2}", kar2.nik, kar2.nama, formatuang((int)kar2.gaji));

            kar1.NaikGaji();
            kar2.NaikGaji();
            Console.WriteLine("\nAlhamdulilah naik gaji 10%");
            Console.WriteLine("\nNO Nik/Nama            Gaji Bulanan");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1. {0} {1}       {2}", kar1.nik, kar1.nama, formatuang((int)kar1.gaji));
            Console.WriteLine("1. {0} {1}       {2}", kar2.nik, kar2.nama, formatuang((int)kar2.gaji));
        }   
        
    }
}
