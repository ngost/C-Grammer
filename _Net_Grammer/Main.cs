using System;
using _Net_Grammer.Grammer.etcs;
namespace _Net_Grammer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Make Exams Class instantce
            Exams exams = new Exams();

            //Run Some Examples...
            exams.RunExample((int)Example_Code.Indexer_Grammer);

        }
    }
}
