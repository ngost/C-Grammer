using System;
using Microsoft.CSharp;
using System.Dynamic;
using System.Collections.Generic;

namespace _Net_Grammer.Grammer.Basic
{
    public class DynamicGrammer : GrammerInterface
    {
        public DynamicGrammer()
        {

            

        }

        public void PrintConsole()
        {
            TestClass t_class = new TestClass();

            dynamic d_value = new ExpandoObject();

            d_value.Name = "Lee";
            d_value.Phone = "8230-0004";
            t_class.RunTest(d_value);

            d_value.Name = "Lee";
            d_value.Phone = 8230;
            t_class.RunTest(d_value);

            t_class.Dynamic_Query(d_value);
        }
    }

    public class TestClass
    {
        public void RunTest(dynamic obj)
        {
            
            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.Phone);
        }

        public void Dynamic_Query(dynamic obj)
        {
            // ExpandoObject를 IDictionary로 변환
            var dict = (IDictionary<string, object>)obj;

            // person 의 속성,메서드,이벤트는
            // IDictionary 해시테이블에 저정되어 있는데
            // 아래는 이를 출력함
            foreach (var d in dict)
            {
                Console.WriteLine("{0}: {1}", d.Key, d.Value);
            }
        }
    }
}
