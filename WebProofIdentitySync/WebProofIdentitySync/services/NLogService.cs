using System;
using System.Diagnostics;
using NLog;

namespace WebProofIdentitySync.services
{
    /// <summary>
    /// NLogg Service used for DI
    /// </summary>
    /// <seealso cref="WebProofIdentitySync.services.INLogService" />
    public sealed class NLogService : INLogService
    {
        private readonly Logger _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="NLogService"/> class.
        /// </summary>
        public NLogService()
        {
            var stackFrame = new StackFrame(1, false);
            var method = stackFrame.GetMethod();
            if (method != null && method.DeclaringType != null)
            {
                _logger = LogManager.GetLogger(method.DeclaringType.FullName);
            }
            else
            {
                _logger = LogManager.GetLogger("unknown");
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NLogService"/> class.
        /// </summary>
        /// <param name="loggerName">Name of the logger.</param>
        public NLogService(string loggerName)
        {
            _logger = LogManager.GetLogger(loggerName);
        }

        /// <summary>
        /// Writes the diagnostic message at the trace level.
        /// </summary>
        /// <param name="message">Log message</param>
        public void Trace(string message)
        {
            _logger.Trace(message);
        }

        /// <summary>
        /// Writes the diagnostic message at the Debug level.
        /// </summary>
        /// <param name="message">Log message.</param>
        public void Debug(string message)
        {
            _logger.Debug(message);
        }

        /// <summary>
        /// Writes the diagnostic message at the Info level.
        /// </summary>
        /// <param name="message">Log message.</param>
        public void Info(string message)
        {
            _logger.Info(message);
        }

        /// <summary>
        /// Writes the diagnostic message at the Warn level.
        /// </summary>
        /// <param name="message">Writes the diagnostic message at the Warn level.</param>
        public void Warning(string message)
        {
            _logger.Warn(message);
        }

        /// <summary>
        /// Writes the diagnostic message and the exception at the Warn level using the specified exception.
        /// </summary>
        /// <param name="exception">The exception to be written.</param>
        /// <param name="message">The message to be written.</param>
        public void Warning(Exception exception, string message)
        {
            _logger.Warn(exception, message);
        }

        /// <summary>
        /// Writes the diagnostic message at the Error level.
        /// </summary>
        /// <param name="message">Log message.</param>
        public void Error(string message)
        {
            _logger.Error(message);
        }

        /// <summary>
        /// Writes the diagnostic message and exception at the Error level.
        /// </summary>
        /// <param name="ex">An exception to be logged.</param>
        /// <param name="message">A string to be written.</param>
        public void Error(Exception ex, string message)
        {
            _logger.Error(ex, message);
        }

        /// <summary>
        /// Writes the diagnostic message at the Fatal level.
        /// </summary>
        /// <param name="message">Log message.</param>
        public void Fatal(string message)
        {
            _logger.Fatal(message);
        }

        /// <summary>
        /// Writes the diagnostic message and exception at the Fatal level.
        /// </summary>
        /// <param name="exception">An exception to be logged.</param>
        /// <param name="message">A string to be written.</param>
        public void Fatal(Exception exception, string message)
        {
            _logger.Fatal(exception, message);
        }
    }
}
