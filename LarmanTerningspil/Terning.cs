using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarmanTerningspil
{
    class Terning
    {
        public int FaceValue { get; set; }
        private Random rand;

        public Terning()
        {
            rand = new Random(DateTime.Now.Millisecond);
        }

        public void Roll()
        {
            FaceValue = rand.Next(1, 6);
        }

        public int ReadFaceValue()
        {
            return FaceValue;
        }

    }
}
