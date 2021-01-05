using System;
using System.Linq;
namespace _Net_Grammer.Grammer.Basic
{
    public class LambdaGrammer : GrammerInterface
    {
        delegate void SquareFunc(int value);
        SquareFunc square_delegate;

        public LambdaGrammer()
        {
            square_delegate = (int value) => { int result = value * value; Console.WriteLine(result); };
        }
        



        public void PrintConsole()
        {
            square_delegate(5);
        }


    }
}
