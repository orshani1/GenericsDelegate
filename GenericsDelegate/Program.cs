using System.Collections.Generic;
using System;


namespace GenericsDelegate
{
    public delegate T4 GenericDelegate<in T1,in T2, in T3,out T4>(T1 t1,T2 t2,T3 t3);
    public delegate T2 GenericDelForOddMiddle<in T1, out T2>(T1 t1);
class Program
    {
        static void Main() 
        {
            
            GenericDelegate<int, int, int, int> threeNumMethod = (a, b, c) =>
            {
                int finalnum = 0;
                if (a > finalnum)
                {
                    finalnum = a;
                }
                if (b > finalnum)
                {
                    finalnum = b;
                }
                if (c > finalnum)
                {
                    finalnum = c;
                }
                return finalnum;
            };
            GenericDelegate<int, int, int, int> avarageMethod = (a, b, c) =>
               {
                   int avg = 0;
                   avg = a + b + c;
                   avg /= 3;

                   return avg;
               };
            GenericDelForOddMiddle<string,string> oddEvenMethod = (a) => 
            {
                
                int length = 0;
                int pos = 0;
                if (a.Length % 2 == 0)
                {
                    pos = a.Length / 2 + 1;
                    length = 2;
                }
                else
                {
                    pos = a.Length / 2;
                    length = 1;
                }



                return a.Substring(pos,pos + length);    

            };
            GenericDelForOddMiddle<string,int> countVolwes = (str) =>
            {
                if (string.IsNullOrEmpty(str))
                {
                    throw new NullReferenceException("is null");
                }
                int count = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == 'a' ||str[i] == 'e' ||str[i] == 'i' ||str[i] == 'o'||str[i] =='u')
                    {
                        count++;
                    }
                }
                return count;
            };
            GenericDelForOddMiddle<string, int> numInString = (str) =>
             {
                 int count = 0;
                 if (!(" ".Equals(str.Substring(0,1)))|| !(" ".Equals(str.Substring(str.Length -1))))
                 {
                     for (int i = 0; i < str.Length; i++)
                     {
                         if (str[i] == ' ')
                         {
                             count++;
                         }
                     }
                 }

                 return count;
             };
            GenericDelForOddMiddle<int, int> sumDigits = (myint) =>
             {
                 int result = 0;

                 while (myint > 0)
                 {
                     result += myint % 10;
                     myint /= 10;   
                 }

                 return result;
             };





            
            Console.WriteLine(threeNumMethod(12, 1,40));
            Console.WriteLine("Second Quest\n" +
                 avarageMethod(20,30,40));
            Console.WriteLine(oddEvenMethod("412"));
            Console.WriteLine("Enter Input");
            var input = Console.ReadLine();
            Console.WriteLine(countVolwes(input));
            Console.WriteLine(numInString("or shani meir"));
            Console.WriteLine(sumDigits(45));

        }
    }
}