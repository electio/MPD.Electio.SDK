namespace MPD.Electio.SDK.Interfaces
{
    /// <summary>
    /// Electio SDK logging interface
    /// </summary>
    public interface ILogger
	{
        /// <summary>
        /// Logs a debug message
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The arguments.</param>
        void Debug(string format, params object[] args);

        /// <summary>
        /// Logs an information message
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The arguments.</param>
        void Info(string format, params object[] args);

        /// <summary>
        /// Logs a trace message
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The arguments.</param>
        void Trace(string format, params object[] args);

        /// <summary>
        /// Logs a warning message
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The arguments.</param>
        void Warn(string format, params object[] args);

        /// <summary>
        /// Logs an error message
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The arguments.</param>
        void Error(string format, params object[] args);

        /// <summary>
        /// Logs a fatal error message
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The arguments.</param>
        void Fatal(string format, params object[] args);
	}
}
