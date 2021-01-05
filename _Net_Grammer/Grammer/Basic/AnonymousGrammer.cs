using System;
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

            var Infos = new[] {
                new {Name = "LeeJinYoung", phone = "010-8230-0004", gender = "man"},
                new {Name = "JinMinGyong", phone = "010-6786-6030", gender = "man"},
                new {Name = "KimJaYoung", phone = "010-2167-7182", gender = "woman"}
            };

        }
    }
}
