using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarmanTerningspil
{
    class Spil
    {
        private Terning t1;
        private Terning t2;

        public Spil()
        {
            t1 = new Terning();
            t2 = new Terning();
        }

        public bool Play()
        {
            t1.Roll();
            int t1Value = t1.ReadFaceValue(); // t1.FaceValue

            t2.Roll();
            int t2Value = t2.ReadFaceValue(); // t1.FaceValue

            int sum = t1Value + t2Value;

            if (sum == 7)
                return true;
            
            return false;
            // return (sum == 7)
        }

    }
}
