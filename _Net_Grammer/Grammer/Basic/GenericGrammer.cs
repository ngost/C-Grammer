using System;
namespace _Net_Grammer.Grammer.Basic
{
    public class GenericGrammer : GrammerInterface
    {
        MyGeneric<int> myGeneric_int;
        MyGeneric<string> myGeneric_string;
        MyGeneric<double> myGeneric_double;

        public GenericGrammer()
        {
            myGeneric_int = new MyGeneric<int>();
            myGeneric_string = new MyGeneric<string>();
            myGeneric_double = new MyGeneric<double>();

            myGeneric_int.push(1);
            myGeneric_int.push(2);
            myGeneric_int.push(3);

            myGeneric_string.push("a");
            myGeneric_string.push("b");
            myGeneric_string.push("c");

            myGeneric_double.push(1.0);
            myGeneric_double.push(2.0);
            myGeneric_double.push(3.0);
        }

        public void PrintConsole()
        {
            Console.WriteLine("int stack : " + myGeneric_int.pop());
            Console.WriteLine("int stack : " + myGeneric_int.pop());
            Console.WriteLine("int stack : " + myGeneric_int.pop());

            Console.WriteLine("string stack : " + myGeneric_string.pop());
            Console.WriteLine("string stack : " + myGeneric_string.pop());
            Console.WriteLine("string stack : " + myGeneric_string.pop());

            Console.WriteLine("double stack : " + myGeneric_double.pop());
            Console.WriteLine("double stack : " + myGeneric_double.pop());
            Console.WriteLine("double stack : " + myGeneric_double.pop());

        }
    }

    //generic class
    public class MyGeneric<T>
    {
        T[] elements = new T[100];
        int index = 0;

        public void push(T element)
        {
            index++;
            elements[index] = element;

        }

        public T pop()
        {
            return elements[index--];
        }

        public MyGeneric()
        {

        }
    }
}
