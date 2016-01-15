using System;

namespace WebProofIdentitySync.services
{
    /// <summary>
    /// Definition for the NLogService.
    /// </summary>
    public interface INLogService
    {
        /// <summary>
        /// Writes the diagnostic message at the trace level.
        /// </summary>
        /// <param name="message">Log message</param>
        void Trace(string message);

        /// <summary>
        /// Writes the diagnostic message at the Debug level.
        /// </summary>
        /// <param name="message">Log message.</param>
        void Debug(string message);

        /// <summary>
        /// Writes the diagnostic message at the Info level.
        /// </summary>
        /// <param name="message">Log message.</param>
        void Info(string message);

        /// <summary>
        /// Writes the diagnostic message at the Warn level.
        /// </summary>
        /// <param name="message">Writes the diagnostic message at the Warn level.</param>
        void Warning(string message);

        /// <summary>
        /// Writes the diagnostic message and the exception at the Warn level using the specified exception.
        /// </summary>
        /// <param name="message">The message to be written.</param>
        /// <param name="exception">The exception to be written.</param>
        void Warning(Exception exception, string message);

        /// <summary>
        /// Writes the diagnostic message at the Error level.
        /// </summary>
        /// <param name="message">Log message.</param>
        void Error(string message);

        /// <summary>
        /// Writes the diagnostic message and exception at the Error level.
        /// </summary>
        /// <param name="ex">An exception to be logged.</param>
        /// <param name="message">A string to be written.</param>
        void Error(Exception ex, string message);

        /// <summary>
        /// Writes the diagnostic message at the Fatal level.
        /// </summary>
        /// <param name="message">Log message.</param>
        void Fatal(string message);

        /// <summary>
        /// Writes the diagnostic message and exception at the Fatal level.
        /// </summary>
        /// <param name="exception">An exception to be logged.</param>
        /// <param name="message">A string to be written.</param>
        void Fatal(Exception exception, string message);
    }
}
