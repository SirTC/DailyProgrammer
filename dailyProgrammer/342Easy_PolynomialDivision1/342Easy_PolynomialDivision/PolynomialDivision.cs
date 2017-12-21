using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _342Easy_PolynomialDivision
{
    public class PolynomailDivision
    {

        public static void Go()
        {
            Console.WriteLine("Enter the Numerator (Format Example 2x2 + x - 10");
            var numerator = Console.ReadLine();
            Console.WriteLine("Enter the Denominator (Same Format as Before)");
            var denominator = Console.ReadLine(); ;

            Console.WriteLine(numerator + " / " + denominator);

            Divide(numerator, denominator);
        }

        public static void Divide(string numerator, string denominator)
        {
            var nArray = numerator.Split(' ');
            var dArray = denominator.Split(' ');

            for (int i = 0; i < nArray.Count(); i++)
            {
                foreach(var n in nArray[i])
                {
                    if (n == 'x')
                    {
                        var hasX = nArray[i].ToString();
                        int index = hasX.IndexOf('x');
                        int indexLength = hasX.Length;
                        string constant = hasX.Substring(0, index) == "" ? "1" : hasX.Substring(0, index);
                        string exponent = hasX.Substring(index + 1, indexLength - index - 1) == "" ? "1" : hasX.Substring(index + 1, indexLength - index - 1);

                        nArray[i] = constant + n + exponent;
                        Console.WriteLine(nArray[i].ToString());
                    }
                }
            }

            for (int i = 0; i < dArray.Count(); i++)
            {
                foreach(var d in dArray[i])
                {
                    if (d == 'x')
                    {
                        var hasX = dArray[i].ToString();
                        int index = hasX.IndexOf('x');
                        int indexLength = hasX.Length;
                        string constant = hasX.Substring(0 , index) == "" ? "1" : hasX.Substring(0, index);
                        string exponent = hasX.Substring(index + 1 , indexLength - index - 1) == "" ? "1" : hasX.Substring(index + 1, indexLength - index - 1);

                        dArray[i] = constant + d + exponent;
                        Console.WriteLine(dArray[i].ToString());
                    }
                    
                }

            }

            Console.WriteLine(string.Join(" ", nArray) + " / " + string.Join(" ", dArray));


          
            
        }



    }
}
