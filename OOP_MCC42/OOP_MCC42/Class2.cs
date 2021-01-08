using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_MCC42
{
    class Persegi : PersegiPanjang
    {
        public override void luas()
        {
            float hasil = Nilai1 * Nilai1;
            Console.WriteLine("\nLuas Persegi Adalah " + hasil);
        }
    }
}
