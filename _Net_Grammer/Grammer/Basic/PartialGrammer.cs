using System;
namespace _Net_Grammer.Grammer.Basic
{
    public class PartialGrammer : GrammerInterface
    {
        public PartialGrammer()
        {

        }

        public void PrintConsole()
        {
            Console.WriteLine("partial class, struct, interface");
        }
    }

    // class
    partial class PartialClass : GameInterface
    {
        string name;

        public string getName()
        {
            return "dummy Name";
        }
    }

    partial class PartialClass : GameInterface
    {
        string phone_num;

        public void setName(string name)
        {
            this.name = name;
        }
    }

    // struct
    partial struct PartialStruct
    {
        string name;
    }

    partial struct PartialStruct
    {
        string phone_num;

        public PartialStruct(string name,string phone_num)
        {
            this.name = name;
            this.phone_num = phone_num;
        }
    }

    // interface

    partial interface GameInterface
    {
        public string getName();
    }

    partial interface GameInterface
    {
        public void setName(string name);
    }


}