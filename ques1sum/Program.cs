using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ques1sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the first number:");
            //int first = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the second number:");
            //int second= int.Parse(Console.ReadLine());

            //int add = sum(first, second);
            //Console.WriteLine(add);
            //int diff = difference(first, second);
            //Console.WriteLine(diff);
            //int pr = product(first, second);
            //Console.WriteLine(pr);

            //Console.WriteLine("Enter the base number:");
            //int basenum = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the exponent number:");
            //int exponent= int.Parse(Console.ReadLine());

            //double res = Power(basenum, exponent);
            //Console.WriteLine("The positive integer of power is:"+res);

            //Console.WriteLine("Enter the value:");
            //float value = float.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the number:");
            //float num = float.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the +valuess:");
            //float val = float.Parse(Console.ReadLine());


            //double res = prod(value,num.val);
            //Console.WriteLine("The value of product is:"+res);

           


         
        }

        #region MyRegion (Q1 sum)
        public static int sum(int i, int j)
        {
            return i + j;
        }
        #endregion

        #region MyRegion
        public static int difference(int i, int j)
        {
            return Math.Abs(i - j);
        }
        #endregion
        
        #region MyRegion

        public static int product(int i, int j)
        {
            return i * j;
        }
        #endregion
        #region MyRegion Q2(power)
    
        public static double Power(int a,int b)
        {
            return Math.Pow(a, b);

        }

          #endregion

        #region MyRegion(Q3 rectangular)

        public static float ( float l,float w, float h)
        {
            return l*w*h;
        }


        #endregion

        #region MyRegion
        public static float circle(float i, float pi, float r)
        {
            return i * pi * r;
        }
        #endregion






    }
}
