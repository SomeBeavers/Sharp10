#nullable enable warnings
#nullable disable annotations
using System;
using System.Linq;

static class Program
{
    static void Main()
    {


        bool b = true;
        object x = null;
        int y;
        if (b ? x != null && Set(out y) : x != null && Set(out y))
        {
            y.ToString();
        }



        bool Set(out int x) { x = 0; return true; }


        Bla0("asd");
        Bla1("asd");
        Bla2("asd");
    }

    static void M11(bool b, object? x)
    {
        if (b ? x != null : false)
        {
            x.ToString(); // ok
        }
    }


    static void Bla0<T>(params T[] val) where T : IComparable
        => Console.WriteLine(val.Select(v => v.CompareTo(v)).Single()); //Dereference of a possibly null reference.

    static void Bla1<T>(params T[] val) where T : IComparable
        => Console.WriteLine(val.Single().CompareTo(val.Single())); //no warning

    static void Bla2(params IComparable[] val)
        => Console.WriteLine(val.Select(v => v.CompareTo(v)).Single()); // no warning

}