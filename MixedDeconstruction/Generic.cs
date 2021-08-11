using System;

namespace MixedDeconstruction
{
    public class Generic
    {
        static void Main()
        {
            var stringCollection = new SampleCollection<string>();
            stringCollection[0] = "Hello, World";

            (stringCollection[0], int count) = ("", stringCollection.Count);

            Console.WriteLine(stringCollection[0]);
            Console.WriteLine(count);
        }

        class SampleCollection<T>
        {
            // Declare an array to store the data elements.
            private T[] arr = new T[100];

            // Define the indexer to allow client code to use [] notation.
            public T this[int i]
            {
                get { return arr[i]; }
                set { arr[i] = value; }
            }

            public int Count { get; set; }
        }
    }

    class Generic2<T> where T : new()
    {
        private void Test(string declared)
        {
            (var name, var t, declared) = ValueTuple();

            (name, string s) = ("", "");

            Console.WriteLine(name);
            Console.WriteLine(t);
        }

        private static (string, T, string) ValueTuple()
        {
            return ("", new T(), "");
        }
    }
}