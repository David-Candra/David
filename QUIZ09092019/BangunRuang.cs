using System;

namespace QUIZ09092019
{
     class BangunRuang
    {
        public void Volume_Balok()
        {
            Console.WriteLine("Menghitung Volume Balok");

            int panjang, lebar, tinggi, volume;

            Console.WriteLine("panjang=");
            panjang = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("lebar =");
            lebar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("tinggi =");
            tinggi = Convert.ToInt32(Console.ReadLine());

            volume = panjang * lebar * tinggi;

            Console.WriteLine("volume ="+volume);
        }
        public void Volume_Kubus()
        {
            Console.WriteLine("Menghitung Volume Kubus");

            int sisi, volume;

            Console.WriteLine("sisi =");
            sisi = Convert.ToInt32(Console.ReadLine());

            volume = sisi * sisi * sisi ;

            Console.WriteLine("volume = "+volume);
        }
    }
}