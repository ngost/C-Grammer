using System;
namespace _Net_Grammer.Grammer.Basic
{
    public class ArrayGrammer : GrammerInterface
    {
        //array init type
        //1
        int[] numbers_type1 = new int[5];
        //2
        int[] numbers_type2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public ArrayGrammer()
        {
            //1 init
            int temp_index = 0;
            foreach (int number in numbers_type1)
            {
                if(number == 0)
                {
                    numbers_type1[temp_index] = temp_index + 1;
                    temp_index++;
                }
            }
            temp_index = 0;

        }

        public void PrintConsole()
        {
            System.Console.Write("[");
            foreach(int num in numbers_type1)
            {
                System.Console.Write(num);
            }
            System.Console.WriteLine("]");

            System.Console.Write("[");
            foreach (int num in numbers_type2)
            {
                System.Console.Write(num);
            }
            System.Console.WriteLine("]");
        }
    }
}
