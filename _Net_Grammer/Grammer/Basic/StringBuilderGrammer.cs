using System;
using System.Text;
namespace _Net_Grammer.Grammer.Basic
{
    public class StringBuilderGrammer : GrammerInterface
    {
        StringBuilder stringBuilder = new StringBuilder();
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        public StringBuilderGrammer()
        {
            foreach(int num in numbers)
            {
                stringBuilder.Append(num.ToString() + ", ");
            }
            stringBuilder.Remove(stringBuilder.Length - 2,2);
        }
        public void PrintConsole()
        {
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
