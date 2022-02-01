using System;

namespace BuildFailureRepro
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new ReproSample();

            if (r?.DoSomething(out int result) ?? false)
            {
                Console.WriteLine(result);
            }

            //if (r?.DoSomething(out int result) ?? false/*caret*/)
            //{
            //    Console.WriteLine(result);
            //}
            //Console.WriteLine("Hello World!");
        }

        private class ReproSample
        {
            public bool DoSomething(out int result)
            {
                C c = new C();

                if ((c != null && c.M(out object obj1)) == true)
                {
                    obj1.ToString(); // undesired error
                }

                if ((c != null && c.M(out object obj2)) is true)
                {
                    obj2.ToString(); // undesired error
                }
                result = 4;
                return true;
            }
        }

        public class C
        {
            public bool M(out object obj)
            {
                obj = new object();
                return true;
            }
        }
    }
}