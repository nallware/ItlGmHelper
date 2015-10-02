using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ItlGmHelper
{
    public class Randomizer
    {
        public int RandNumber(int Low, int High)
        {
            Random rndNum = new Random(int.Parse(Guid.NewGuid().ToString().Substring(0, 8), System.Globalization.NumberStyles.HexNumber));
            int rnd = rndNum.Next(Low, High);
            return rnd;
        }
    }
}
