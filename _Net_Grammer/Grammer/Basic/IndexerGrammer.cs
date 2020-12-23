using System;
namespace _Net_Grammer.Grammer.Basic
{
    public class IndexerGrammer : GrammerInterface
    {
        IndexerExampleClass indexer;
        public IndexerGrammer()
        {
            indexer = new IndexerExampleClass();
            indexer[0] = "Hello.";
            indexer[1] = "My name is";
            indexer[2] = "jinyoung lee";
        }

        public void PrintConsole()
        {
            Console.WriteLine(indexer[0]);
            Console.WriteLine(indexer[1]);
            Console.WriteLine(indexer[2]);
        }
    }

    public class IndexerExampleClass
    {
        private const int MAX = 10;
        string[] strs = new string[MAX];

        public IndexerExampleClass()
        {
            //pass
        }

        public string this[int i]
        {
            get
            {
                return strs[i];
            }
            set
            {
                strs[i] = value;
            }
        }
    }
}
