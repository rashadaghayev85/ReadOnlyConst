using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readonly_Const_Inheritance
{
    internal class CustomMath
    {
        public int GetSumOfArrayItems(int[]nums)=> nums.Where(m => m%2==1).Sum();
        public string CheckNumber(int number)=> number % 2 == 0 ? "even" : "odd";
        public int SquareOfEvenNumbers(int[] nums)
        {
            int sum=nums.Where(m => m%2==0).Sum();
            return (int)Math.Pow(sum, 2);
        }
        public int  MultipleOfNumber(int number)
        {
            int multiple = 1;
            for (int i = 1; i <= number; i++)
            {
                multiple *= i;
            }
            return multiple;
        }

    }
}
