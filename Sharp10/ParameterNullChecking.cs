using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Sharp10
{
    #nullable enable
    public class ParameterNullChecking
    {
        public string Name { get; set; }

        void Insert(string s)
        {
            Console.WriteLine(s.Length);
        }
    }

    public record ParameterNullCheckingRecord(string Name)
    {
    }
}