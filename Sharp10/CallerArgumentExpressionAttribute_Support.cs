using System.Runtime.CompilerServices;
using System;

namespace Sharp10
{
    public static class CallerArgumentExpressionAttribute_Support
    {
        static T Single<T>(this T[] array)
        {
            Verify.NotNull(array); // paramName: "array"
            Verify.Argument(array.Length == 1, "Array must contain a single element."); // paramName: "array.Length == 1"

            return array[0];
        }

        static T ElementAt<T>(this T[] array, int index)
        {
            Verify.NotNull(array); // paramName: "array"
            // paramName: "index"
            // message: "index (-1) cannot be less than 0 (0).", or
            //          "index (6) cannot be greater than array.Length - 1 (5)."
            Verify.InRange(index, 0, array.Length - 1);

            return array[index];
        }
    }

    public static class Verify
    {
        public static void Argument(bool condition, string message, [CallerArgumentExpression("condition")] string conditionExpression = null)
        {
            if (!condition) throw new ArgumentException(message: message, paramName: conditionExpression);
        }

        public static void InRange(int argument, int low, int high,
            [CallerArgumentExpression("argument")] string argumentExpression = null,
            [CallerArgumentExpression("low")] string lowExpression = null,
            [CallerArgumentExpression("high")] string highExpression = null)
        {
            if (argument < low)
            {
                new ArgumentNullException("argument1");
                throw new ArgumentOutOfRangeException(paramName: argumentExpression,
                    message: $"{argumentExpression} ({argument}) cannot be less than {lowExpression} ({low}).");
            }

            if (argument > high)
            {
                throw new ArgumentOutOfRangeException(paramName: argumentExpression,
                    message: $"{argumentExpression} ({argument}) cannot be greater than {highExpression} ({high}).");
            }
        }

        public static void NotNull<T>(T argument, [CallerArgumentExpression("argument")] string argumentExpression = null)
            where T : class
        {
            if (argument == null) throw new ArgumentNullException(paramName: argumentExpression);
        }
    }


}