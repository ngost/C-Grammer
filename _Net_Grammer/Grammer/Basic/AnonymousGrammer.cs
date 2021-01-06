using System;
using System.Linq;
using _Net_Grammer.Grammer.etcs;

namespace _Net_Grammer.Grammer.Basic
{
    public class AnonymousGrammer : GrammerInterface
    {
        String name;
        int age;

        //delegate 프로토 타입 및 변수 정의
        delegate void Printf(string msg);
        Printf printf;

        public AnonymousGrammer()
        {
            //delegate 함수 설정
            printf = System.Console.WriteLine;

            // Anonymous Type은 LINQ를 사용할 때 많이 사용된다.
            // + 읽기전용(read only)이기 때문에 갱신 불가능, 참조만 가능

            var People = new { Name = "이진영", Age = 30 };
            this.name = People.Name;
            this.age = People.Age;
        }

        public void PrintConsole()
        {
            //test 1 (delegate + anonymouse)
            printf("name : " + this.name + ", age : " + this.age);

            //test 2
            Anonymouse_LINQ_Test();
        }

        public void Anonymouse_LINQ_Test()
        {
            //step1 init anonymouse value

            var Datas = new[] {
                new {Name = "LeeJinYoung", phone = "010-8230-0004", gender = "man"},
                new {Name = "JinMinGyong", phone = "010-6786-6030", gender = "man"},
                new {Name = "KimJaYoung", phone = "010-2167-7182", gender = "woman"}
            };
            //Linq lib을 반드시 사용해야 where, select 등을 사용할 수 있습니다.
            //아래 식은 익명 타입 + 람다식 + Linq 사용 예제

            var info_list = Datas.Where(value => value.gender.Equals("man")).Select(value => new {value.Name, value.phone});

            Console.WriteLine("--- Anonymouse_Linq_Test ---");
            int i = 0;
            foreach (var query_info in info_list)
            {
                i++;
                Console.Write(i + "###------------------------\n");
                //앞선 확장 메소드 응용
                Console.WriteLine(i + "### Name : "+query_info.Name.ToString().CaseConverter(CaseEnumeration.UPPER_CASE_MODE));
                Console.WriteLine(i + "### Phone : " + query_info.phone.ToString().CaseConverter(CaseEnumeration.UPPER_CASE_MODE));
            }
        }
    }
}
