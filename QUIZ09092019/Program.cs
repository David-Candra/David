using System;

namespace QUIZ09092019
{
    class Program
    {
        static void Main(string[] args)
        {
            BangunDatar kelas = new BangunDatar();

            kelas.Luas_Persegi();
            kelas.Luas_Segitiga();
            kelas.Luas_Lingkaran();

            BangunRuang kelas2 = new BangunRuang();

            kelas2.Volume_Balok();
            kelas2.Volume_Kubus();
        }
    }
}
