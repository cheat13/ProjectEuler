using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.ConsoleApp
{
    public class Calculate
    {
        public int Calc(int number)
        {
            var sequence = FindSequence(number);
            var result = sequence.Where(it => it % 2 == 0).Sum();
            return result;
        }

        public int[] FindSequence(int number)
        {
            var sequence = new List<int>();
            sequence.Add(1);
            sequence.Add(2);

            for (int i = 0; ; i++)
            {
                if (sequence[i + 1] + sequence[i] <= number)
                {
                    sequence.Add(sequence[i + 1] + sequence[i]);
                }
                else
                {
                    break;
                }
            }

            return sequence.ToArray();
        }
    }
}