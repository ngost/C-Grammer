using System;
namespace _Net_Grammer.Grammer.Basic
{
    public class DelegateGrammer : GrammerInterface
    {
        delegate int StringToIntDelegate(string str);

        StringToIntDelegate m_delegate;

        public DelegateGrammer()
        {
            //m_delegate = new StringToIntDelegate(StringToInt);
            m_delegate = StringToInt;
        }

        public int StringToInt(string str)
        {
            return int.Parse(str);
        }


        

        //now, you can use parameter method..!
        int ToInt(StringToIntDelegate dele, string num_msg)
        {
            int result = dele(num_msg);// you can also use -> dele.Invoke(num_msg);
            return result;
        }


        public void PrintConsole()
        {
            //
            Console.WriteLine("string parse result : " + ToInt(m_delegate,"90000"));
        }
    }
}
