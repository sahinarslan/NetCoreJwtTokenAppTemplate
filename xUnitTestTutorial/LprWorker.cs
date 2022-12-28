using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTestTutorial
{
    public class LprWorker
    {
        public int Add(int a, int b){
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Add(int[] numbers)
        {
            int sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }
            return sum;
        }

        public int subtraction(int mainNumber, int b)
        {
            return mainNumber - b;
        }
        public int subtraction(int mainNumber, int b, int c)
        {
            return mainNumber - b - c;
        }

        public int subtraction(int[] numbers)
        {
            int sum = numbers[0]*2;
            foreach (var item in numbers)
            {
                sum -= item;
            }
            return sum;
        }

        public bool isOdd(int value)
        {
            return value % 2 == 1;
        }
    }
}
