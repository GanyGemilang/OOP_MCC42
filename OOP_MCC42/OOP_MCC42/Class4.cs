using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_MCC42
{
    class BelahKetupat : PersegiPanjang
    {
        public override void luas()
        {
            float hasil = (Nilai1 * Nilai2) / 2;
            Console.WriteLine("\nLuas Belah Ketupat " + hasil);
        }
    }
}
