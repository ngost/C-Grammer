using System;
using _Net_Grammer.Grammer.etcs;
using System.Collections.Generic;
using System.Linq;

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

            //advanced exam
            AdvancedExam();

        }

        public void AdvancedExam()
        {
            //step1 creaet List data (using Syste.Collections)
            List<string> str_list = new List<string> {"이진영","이상아","s을용","기유비","이지은" };

            //step2 using Where() extend fucntion, para lambda func (use way of 2)
            //step3 get IEnumeratable<Type>

            // # way 1
            IEnumerable<string> enumer_str = str_list.Where(p => p.StartsWith("이"));

            // # way 2
            var searched_str = str_list.Where(p => p.StartsWith("이"));

            //step4 convert IEnumeratable to List
            List<string> m_list = searched_str.ToList();

            //step5 result
            Console.WriteLine("\n==========Advanced Test==========");
            foreach(string str in m_list)
            {
                Console.WriteLine("-- List Search Result from data --");
                Console.WriteLine(str);
            }
        }

    }
}
