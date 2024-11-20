using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_basics_cs
{
    internal class Matte
    {
        internal static float Procent(int arg, int[] array)
        {
            const int procentage = 100;

            int sum = 0;
            float prosent = arg;

            // sum the counts
            foreach (int n in array)
            {
                sum += n;
            }

            // Followed the solution https://www.nettavisen.no/prosenter/prosentregning/kvart-prosent/hvordan-regne-prosent-en-enkel-guide-til-prosentregning/s/5-95-1084570
            return prosent / sum * procentage;
        }
    }
}
