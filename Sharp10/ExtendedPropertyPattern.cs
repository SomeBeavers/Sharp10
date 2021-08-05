using System.Collections.Generic;
using System;
using System.Linq;

namespace Sharp10
{
    public class ExtendedPropertyPattern
    {
        public record Point(int X, int Y);
        public record Segment(Point Start, Point End);

        static bool IsAnyEndAtOrigin(Segment segment)
        {
            return segment is { Start: { X: 0, Y: 0 } } or { End: { X: 0, Y: 0 } };
        }

        private string name;
        public int Age { get; set; }

        static string TakeFive(object input) => input switch
        {
            string { Length: >= 5 } s => s.Substring(0, 5),
            string s => s,

            ICollection<char> { Count: >= 5 } symbols => new string(symbols.Take(5).ToArray()),
            ICollection<char> symbols => new string(symbols.ToArray()),

            null => throw new ArgumentNullException(nameof(input)),
            _ => throw new ArgumentException("Not supported input type."),
        };
    }
}