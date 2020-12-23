using System;
namespace _Net_Grammer.Grammer.Basic
{
    public class InheritanceGrammer : GrammerInterface
    {
        Bear bear;

        public InheritanceGrammer()
        {
            bear = new Bear(15,"black bear");
        }

        public void PrintConsole()
        {
            //base 클래스의 함수 호출
            bear.Info();

            //derived 클래스의 함수 호출
            bear.Print();
        }
    }

    //parent class (base)
    public class Animal
    {
        public string Name { get; set; }
        public int age;

        public void Info()
        {
            Console.WriteLine(this.Name + "," + this.age);
        }
    }
    //child class (derived)
    public class Bear : Animal
    {
        public Bear(int age, string name)
        {
            this.age = age;
            this.Name = name;
        }

        public void Print()
        {
            Console.WriteLine("나이 : " + this.age + ", 이름 : " + this.Name);
        }
    }
}
