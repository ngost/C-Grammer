using System;
namespace _Net_Grammer.Grammer.Basic
{
    public class StringGrammer : GrammerInterface
    {
        string string_a, string_b;
        char dot;


        public StringGrammer()
        {
            string_a = "Now you";
            string_b = " See me";
            dot = '.';


        }

        public void PrintConsole()
        {
            //using string format
            System.Console.WriteLine(string_a + string_b + "!!{0}{1}", dot, dot);
        }
    }
}
