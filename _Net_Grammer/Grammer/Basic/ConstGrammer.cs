using System;
namespace _Net_Grammer.Grammer
{
    public class ConstGrammer
    {
        //클래스 변수 1

        public const string c_str = "This is Const String";
        public readonly string r_str = "This is onl Readable String";

        //생성자
        public ConstGrammer()
        {
            r_str = "This is only readable str";

            System.Console.WriteLine(c_str);
            System.Console.WriteLine(r_str);
        }
    }
}
