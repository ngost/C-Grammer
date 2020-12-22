#define PreProcessor_Test
using System;
namespace _Net_Grammer.Grammer.Basic
{
    public class PreprocessorGrammer : GrammerInterface
    {
        string runState;

        //region directive

        #region propertys~
        private string name;
        private int age;
        private bool isMan;
        private string address;
        #endregion

        #region public method~

        public int Add(int num1,int num2)
        {
            return num1 + num2;
        }

        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        #endregion

        public PreprocessorGrammer()
        {
            
//define directive
#if (DEBUG)
            runState = "Debug Run";
#elif (!DEBUG)
            runState = "Debug Run But Runded from Realse";
#else
            runState = "Don't know";
#endif



        }

        public void PrintConsole()
        {
            Console.WriteLine(runState);
            // progma directive test
            //에러 강제로 끄기
#pragma warning disable
            if (false)
            {

                Console.WriteLine("This is some error");
            }

            //            //에러 강제로 끄기
            //#pragma warning restore
            //            if (false)
            //            {

            //                Console.WriteLine("This is some error");
            //            }

            //특정 에러 끄기
#pragma warning disable CS0162
            if (false)
            {
                Console.WriteLine("접근 불가 코드만 끄기");
            }

        }
    }
}
