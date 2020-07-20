using System;
using System.Collections;
using System.Collections.Generic;

namespace Types.Interfaces
{
    public class Enumerator : IEnumerator<int>, IEnumerable
    {
        public int Count { get; set; }

        public int Limit { get; set; }

        public int Current => Count;

        object IEnumerator.Current => Count;

        public Enumerator(int limit)
        {
            Count = 0;
            Limit = limit;
        }

        public bool MoveNext()
        {
            if (++Count == Limit)
                return false;
            else
                return true;
        }

        public void Reset() => Count = 0;

        public IEnumerator<int> GetEnumerator() => this;

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Dispose()
        {
        }

        public static void GetAnEnumerator()
        {
            var stringEnumerator = "Tet string".GetEnumerator();

            while (stringEnumerator.MoveNext())
            {
                Console.WriteLine(stringEnumerator.Current);
            }
        }
    }
}