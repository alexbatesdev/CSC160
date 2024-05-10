using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class Generics
    {
        public static void Execute()
        {
            int first = 12;
            int second = 45;

            Swap(ref first, ref second); 
            //print to see value

            float Schoobi = 3.454f;
            float grep = 10;

            Swap<float>(ref Schoobi, ref grep); 
            //print to see value

            Stack<int> stack = new Stack<int>();
            stack.Push(23);
            stack.Push(24);
            stack.Push(11);
            stack.Pop(); //print to see value
            stack.Pop();
            stack.Pop();

        }
        static void Swap(ref int first, ref int second)
        {
            int temp = first;
            first = second;
            second = temp;
        }

        static void Swap<GenericValueOfAnyName>(ref GenericValueOfAnyName first, ref GenericValueOfAnyName second)
        {
            GenericValueOfAnyName temp = first;
            first = second;
            second = temp;

        }


    }

    class Stack<Generic>
    {
        int index = 0;
        Generic[] elements = new Generic[100];

        public void Push(Generic element)
        {
            elements[index++] = element;
        }

        public Generic Pop()
        {
            if (index > 0)
            {
                return elements[--index];
            }
            return default(Generic);
        }
    }
}
