using System;

namespace Primitive_Types_and_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // byte number = 2;
            // int count = 10;
            // float totalPrice = 20.95f;
            // char character = 'A';
            // string firstName = "Yongsu";
            // bool isWorking = true;

            var number = 2;
            var count = 10;
            // Real Number는 따로 명시하지 않으면 Double로 정의된다.
            var totalPrice = 20.95;
            var character = 'A';
            var firstName = "Yongsu";
            var isWorking = true;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, byte.MaxValue);

            const float Pi = 3.14f;
            // Cannot be used 
            // Pi = 1;  
            Console.WriteLine(Pi);

            // Implicit Type Conversion
            byte b = 1; // 1 byte
            int i = b;  // 4 bytes
            Console.WriteLine(i);

            // int i = 1;
            // byte b = i;
            int bigger = 1000;
            byte s = (byte) bigger;
            // Data Loss인해 232가 출력되는 것을 확인할 수 있다.
            Console.WriteLine(s);

            // Non-compatible Types
            // string test2 = "1234";
            // int i = (int) test2;
            string test2 = "1234";
            int test2_result = Convert.ToInt32(test2);
            Console.WriteLine(test2_result);

            // System.OverflowException: Value was either too large or too small
            // byte test3_result = Convert.ToByte(test2);
            // Console.WriteLine(test3_result);
            // Exception 처리하는 방법 (나중에 자세히 배울 것)
/*
            try
            {
                var test3 = "1234";
                byte test3_result = Convert.ToByte(test3);
                Console.WriteLine(test3_result);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte...")
            }

*/        
            try
            {
                string str = "true";
                bool str_to_bool = Convert.ToBoolean(str);
                Console.WriteLine(str_to_bool);
            } catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte...");
            }

            var aa = 1;
            var bb = 2;
            var cc = 3;

            Console.WriteLine(aa + bb);
            Console.WriteLine(aa / bb);
            Console.WriteLine(aa + bb * cc);
            Console.WriteLine((aa + bb) * cc);
            Console.WriteLine(aa == bb);
            Console.WriteLine(aa != bb);
            Console.WriteLine(!(aa != bb));
            Console.WriteLine(cc > bb && aa > bb);
            Console.WriteLine(cc > bb || aa > bb);
        }
    }
}
