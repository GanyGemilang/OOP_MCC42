using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_MCC42
{
    class PersegiPanjang
    {
        private float nilai1;
        private float nilai2;

        public float Nilai1
        {
            get { return nilai1; }
            set { nilai1 = value; }
        }
        public float Nilai2
        {
            get { return nilai2; }
            set { nilai2 = value; }
        }

        public virtual void luas()
        {
            float hasil;
            hasil = nilai1 * nilai2;
            Console.WriteLine("\nLuas Persegi Panjang adalah " + hasil);
        }
    }
}
