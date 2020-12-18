using System;
using _Net_Grammer.Grammer;
namespace _Net_Grammer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello C# with easyJin");
            StringGrammerExam();
        }

        public static void ConstGramerExam()
        {
            ConstGrammer grammerClass = new ConstGrammer();
        }
        public static void ArrayGrammerExam()
        {
            ArrayGrammer arrayGrammer = new ArrayGrammer();
            arrayGrammer.PrintConsole();
        }
        public static void StringGrammerExam()
        {
            StringGrammer stringGrammer = new StringGrammer();
            stringGrammer.PrintConsole();
        }

    }
}
