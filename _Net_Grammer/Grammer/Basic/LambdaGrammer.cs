using System;
using System.Linq;
namespace _Net_Grammer.Grammer.Basic
{
    public class LambdaGrammer : GrammerInterface
    {
        delegate void SquareFunc(int value);
        delegate int AddFunc(int a, int b);

        SquareFunc square_delegate;
        AddFunc add_delegate;

        public LambdaGrammer()
        {
            square_delegate = (int value) => { int result = value * value; Console.WriteLine(result); };
            add_delegate = (int para1, int para2) => para1 + para2;
        }
        



        public void PrintConsole()
        {
            //lambda test 1
            square_delegate(5);

            //lambda test 2
            Console.WriteLine(add_delegate(500, 501));
        }


    }
}
