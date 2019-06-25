using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TasksLibrary
{
    public class UniqOrderer
    {
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> collection)
        {
            var enumerator = collection.GetEnumerator();

            var stack = new Stack<T>();

            while (enumerator.MoveNext())
            {
                if (!stack.Contains(enumerator.Current))
                {
                    if (stack.Count != 0)
                        stack.Pop();
                    yield return enumerator.Current;
                    stack.Push(enumerator.Current);
                }
            }
        }
    }
}
