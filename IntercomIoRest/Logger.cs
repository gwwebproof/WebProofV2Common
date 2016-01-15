using Segment.Model;

namespace IntercomIoRest
{
    /// <summary>
    /// Intercom Logging
    /// </summary>
    public class Logger
    {

        /// <summary>
        /// The logging level of the message
        /// </summary>
        public enum Level
        {
            // ReSharper disable InconsistentNaming
            TRACE,
            DEBUG,
            INFO,
            WARN,
            ERROR
        }

        #region Events

        /// <summary>
        /// A logging event handler.   
        /// </summary>
        /// <param name="level">The <see cref="Logger.Level"/> of the log event (debug, info, warn, error)</param>
        /// <param name="message">The log message</param>
        /// <param name="args">Optional arguments for the message</param>
        public delegate void LogHandler(Level level, string message, Dict args);
        public static event LogHandler Handlers;

        #endregion

        private static void _Log(Level level, string message, Dict args)
        {
            if (Handlers != null)
                Handlers(level, message, args);
        }

        internal static void Trace(string message)
        {
            _Log(Level.TRACE, message, null);
        }

        internal static void Debug(string message)
        {
            _Log(Level.DEBUG, message, null);
        }

        internal static void Debug(string message, Dict args)
        {
            _Log(Level.DEBUG, message, args);
        }

        internal static void Info(string message)
        {
            _Log(Level.INFO, message, null);
        }

        internal static void Info(string message, Dict args)
        {
            _Log(Level.INFO, message, args);
        }
        internal static void Warn(string message)
        {
            _Log(Level.WARN, message, null);
        }

        internal static void Warn(string message, Dict args)
        {
            _Log(Level.WARN, message, args);
        }
        internal static void Error(string message)
        {
            _Log(Level.ERROR, message, null);
        }

        internal static void Error(string message, Dict args)
        {
            _Log(Level.ERROR, message, args);
        }

    }
}
