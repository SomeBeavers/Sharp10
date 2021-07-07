using System;
#nullable enable
namespace Sharp10
{
    public class ListPatterns
    {
        
    }


    class PatternMatching
    {
        public record Order(int Items, decimal Cost);

        public decimal CalculateDiscount(Order order) =>
            order switch
            {
                (Items: > 10, Cost: > 1000.00m) => 0.10m,
                (Items: > 5, Cost: > 500.00m) => 0.05m,
                Order { Cost: > 250.00m } => 0.02m,
                null => throw new ArgumentNullException(nameof(order), "Can't calculate discount on null order"),
                var someObject => 0m,
            };

        void Test(object obj)
        {
            var str = obj as string;
            if (str != null)
            {
                // do something
            }
        }

        public static decimal GetGroupTicketPrice(int visitorCount) => visitorCount switch
        {
            1 => 12.0m,
            2 => 20.0m,
            3 => 27.0m,
            4 => 32.0m,
            0 => 0.0m,
            _ => throw new ArgumentException($"Not supported number of visitors: {visitorCount}", nameof(visitorCount)),
        };

        public decimal CalculateDiscount2(Order order) =>
            order switch
            {
                ( > 10,  > 1000.00m) => 0.10m,
                ( > 5, > 50.00m) => 0.05m,
                Order { Cost: > 250.00m } => 0.02m,
                null => throw new ArgumentNullException(nameof(order), "Can't calculate discount on null order"),
                var someObject => 0m,
            };

        private void PM1()
        {
            int? maybe = 12;

            if (maybe is int number)
            {
                Console.WriteLine($"The nullable int 'maybe' has the value {number}");
            }
            else
            {
                Console.WriteLine("The nullable int 'maybe' doesn't hold a value");
            }

            string? message = "This is not the null string";

            if (message is not null)
            {
                Console.WriteLine(message);
            }

            int? xNullable = 7;
            int y = 23;
            object yBoxed = y;
            if (xNullable is int a && yBoxed is int b)
            {
                Console.WriteLine(a + b);  // output: 30
            }
        }

        string WaterState(int tempInFahrenheit) =>
            tempInFahrenheit switch
            {
                (> 32) and (< 212) => "liquid",
                < 32 => "solid",
                > 212 => "gas",
                32 => "solid/liquid transition",
                212 => "liquid / gas transition",
            };

        public State PerformOperation(Operation command)
        {
            return command switch
            {
                Operation.SystemTest => RunDiagnostics(),
                Operation.Start => StartSystem(),
                Operation.Stop => StopSystem(),
                //Operation.Reset => ResetToReady(),
                //_ => throw new ArgumentException(nameof(command), "Invalid enum value for command")
            };
        }

        private State ResetToReady()
        {
            throw new NotImplementedException();
        }

        private State StopSystem()
        {
            throw new NotImplementedException();
        }

        private State StartSystem()
        {
            throw new NotImplementedException();
        }

        private State RunDiagnostics()
        {
            throw new NotImplementedException();
        }
    }

    internal class State
    {
    }

    internal enum Operation
    {
        SystemTest,
        Start,
        Stop,
        Reset
    }
}