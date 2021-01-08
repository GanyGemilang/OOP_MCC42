using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_MCC42
{
    class SegiTiga : PersegiPanjang
    {
        public override void luas()
        {
            float hasil = ( Nilai1 * Nilai2) / 2;
            Console.WriteLine("\nLuas Segitiga Adalah " + hasil);
        }
    }
}
