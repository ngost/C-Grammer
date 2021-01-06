using System;
using _Net_Grammer.Grammer.etcs;
namespace _Net_Grammer.Grammer.Basic
{
    public class ExtendMethodGrammer : GrammerInterface
    {

        public ExtendMethodGrammer()
        {
            //extend method는 반드시 static class에 작성되어야 합니다.
            //Static class를 따로 만들어서 확장 메소드를 정의하고, 불러다 사용함.
        }

        public void PrintConsole()
        {
            Console.WriteLine("=== Case Test ===");
            while (true)
            {
                Console.WriteLine("=== Please input the message (exit code : z) ===");
                string value = Console.ReadLine();
                if (value.Equals("z"))
                {
                    break;
                }

                Console.WriteLine("--- Test lower case converting ---");
                Console.WriteLine("result before case converting");
                Console.WriteLine(value);

                Console.WriteLine("result after case converting");
                value = value.CaseConverter(CaseEnumeration.LOWER_CASE_MODE);
                Console.WriteLine(value);
                Console.WriteLine("");

                //..

                Console.WriteLine("--- Test upper case converting ---");
                Console.WriteLine("result before case converting");
                Console.WriteLine(value);

                Console.WriteLine("result after case converting");
                value = value.CaseConverter(CaseEnumeration.UPPER_CASE_MODE);
                Console.WriteLine(value);
            }



        }
    }
}
