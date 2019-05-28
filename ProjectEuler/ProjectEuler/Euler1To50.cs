using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    public class Euler1To50
    {
        public int MultiplesOf3And5()
        {
            int sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 5 == 0 || i % 3 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
