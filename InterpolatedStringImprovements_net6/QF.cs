using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace MyNamespace
{
    // The handler that will actually "build" the interpolated string"
    [InterpolatedStringHandler]
    public ref struct TraceLoggerParamsInterpolatedStringHandler
    {
        private bool _logLevelEnabled;

        public TraceLoggerParamsInterpolatedStringHandler(int literalLength, int formattedCount, Logger logger, out bool handlerIsValid)
        {
            handlerIsValid = false;
            this._logLevelEnabled = false;
        }

        public bool AppendLiteral(string s)
        {
            // Store and format part as required
            return true;
        }

        public bool AppendFormatted<T>(T t)
        {
            // Store and format part as required
            return true;
        }
    }

    // The logger class. The user has an instance of this, accesses it via static state, or some other access
    // mechanism
    public class Logger
    {
        public void LogTrace([InterpolatedStringHandlerArgument("")] TraceLoggerParamsInterpolatedStringHandler handler)
        {
            // Impl of logging
        }
    }

    class Use
    {
        private void Test()
        {
            Logger logger = new Logger();

            // Given the above definitions, usage looks like this:
            var name = "Fred Silberberg";
            logger.LogTrace($"{name} will never be printed because info is < trace!");

            //// This is converted to:
            //var receiverTemp = logger;
            //var handler = new TraceLoggerParamsInterpolatedStringHandler(literalLength: 47, formattedCount: 1, receiverTemp, out var handlerIsValid);
            //_ = handlerIsValid &&
            //    handler.AppendFormatted(name) &&
            //    handler.AppendLiteral(" will never be printed because info is < trace!");
            //receiverTemp.LogTrace(handler);
        }

        private void PassStringInterpolation()
        {
            Debug.Assert(true, "true {0}", String.Empty, "test");
        }
    }
}