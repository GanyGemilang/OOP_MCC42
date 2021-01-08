using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_MCC42
{
    class Lingkaran : PersegiPanjang
    {
        private float phi = 3.14F;

        public override void luas()
        {
            float hasil = phi * Nilai1 * Nilai1;
            Console.WriteLine("\nLuas Lingkaran Adalah " + hasil);
        }
    }
}
