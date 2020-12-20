using System;
using System.Collections;
namespace _Net_Grammer.Grammer.Basic
{
    class TestList
    {
        int[] m_list = { 0, 1, 2, 3, 4, 5 };

        public IEnumerator GetEnumerator()
        {
            int i = 0;
            while (i < m_list.Length)
            {
                yield return m_list[i];
                i++;
            }
        }
    }

    public class IEnumeratorGrammer : GrammerInterface
    {
        TestList m_list;

        public IEnumeratorGrammer()
        {
            m_list = new TestList();
        }

        public void PrintConsole()
        {
            Console.WriteLine("--출력--");
            IEnumerator enumerator = m_list.GetEnumerator();
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);

        }
    }
}
