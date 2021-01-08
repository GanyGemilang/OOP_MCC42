using System;

namespace OOP_MCC42
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Program Menghitung Luas Bangun Datar");
            
            PersegiPanjang hitung1 = new PersegiPanjang();
            hitung1.Nilai1 = 3;
            hitung1.Nilai2 = 4;
            hitung1.luas();

            Persegi hitung2 = new Persegi();
            hitung2.Nilai1 = 6;
            hitung2.luas();

            SegiTiga hitung3 = new SegiTiga();
            hitung3.Nilai1 = 6;
            hitung3.Nilai2 = 3;
            hitung3.luas();

            BelahKetupat hitung4 = new BelahKetupat();
            hitung4.Nilai1 = 6;
            hitung4.Nilai2 = 3;
            hitung4.luas();

            Lingkaran hitung5 = new Lingkaran();
            hitung5.Nilai1 = 6;
            hitung5.luas();
        }
    }   
}
