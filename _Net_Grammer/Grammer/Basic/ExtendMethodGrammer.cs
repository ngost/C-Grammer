using System;
using _Net_Grammer.Grammer.etcs;
namespace _Net_Grammer.Grammer.Basic
{
    public class ExtendMethodGrammer : GrammerInterface
    {

        public ExtendMethodGrammer()
        {

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
