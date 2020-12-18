using System;
namespace _Net_Grammer.Grammer.Basic
{
    public class LoopGrammer : GrammerInterface
    {
        //3 dimention [2][2][5] size array
        int[,,] sample = { { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 } }, { { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 } } };

        public LoopGrammer()
        {

        }

        public void PrintConsole()
        {
            // what do you think about [ for ] and [ foreach ]
            //extually, for grammer is a little fast.

            //for
            for(int i=0;i<sample.GetLength(0); i++)
            {
                for (int j = 0; j < sample.GetLength(1); j++)
                {
                    for (int k = 0; k < sample.GetLength(2); k++)
                    {
                        Console.WriteLine(sample[i,j,k]);
                    }
                }
            }

            //foreach
            foreach(int sam in sample)
            {
                Console.WriteLine(sam);
            }
        }
    }
}
