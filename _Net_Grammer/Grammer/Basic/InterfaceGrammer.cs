using System;
using _Net_Grammer.Grammer.Interface;
namespace _Net_Grammer.Grammer.Basic
{
    public class InterfaceGrammer : GrammerInterface
    {
        Temp_Object obj_a, obj_b;

        public InterfaceGrammer()
        {
            obj_a = new Temp_Object();
            obj_b = new Temp_Object();
            obj_a.Compare_Key = 1;
            obj_b.Compare_Key = 0;

        }

        public void PrintConsole()
        {
            //differnt key
            Console.WriteLine(obj_a.CompareTo(obj_b));

            obj_b.Compare_Key = 1;
            //same key
            Console.WriteLine(obj_a.CompareTo(obj_b));

        }




    }

    public class Temp_Object : IMyComparable
    {
        //field,property for compare between classes
        private int keys;

        public int Compare_Key
        {
            get
            {
                return this.keys;
            }
            set
            {
                this.keys = value;
            }
        }

        public int CompareTo(Object obj)
        {
            Temp_Object target_obj = (Temp_Object)obj;
            return this.keys.CompareTo(target_obj.keys);
        }
    }
}
