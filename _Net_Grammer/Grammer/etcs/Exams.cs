using System;
namespace _Net_Grammer.Grammer
{
    public class Exams
    {
        //class values
        public const int Const_Grammer = 1;
        public const int String_Grammer = 2;
        public const int Array_Grammer = 3;

        //instants function
        public void RunExample(int grammer_name)
        {
            GrammerInterface? grammer = null;
            switch (grammer_name)
            {
                case Const_Grammer :
                    grammer = new ConstGrammer();
                    break;
                case String_Grammer:
                    grammer = new StringGrammer();
                    break;
                case Array_Grammer:
                    grammer = new ArrayGrammer();
                    break;
                default:
                    //grammer null
                    System.Console.WriteLine("Not exist example. Please using another Example");
                    return;
            }
            grammer.PrintConsole();
        }
    }
}
