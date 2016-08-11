using MPD.Electio.SDK.Interfaces;

namespace MPD.Electio.SDK
{
    /// <summary>
    /// SDK Reference logger - writes diagnostic information
    /// </summary>
    /// <seealso cref="MPD.Electio.SDK.Interfaces.ILogger" />
    public class SdkReferenceLogger : ILogger
	{
		public void Debug(string format, params object[] args)
		{
			System.Diagnostics.Debug.WriteLine(format, args);
		}

		public void Info(string format, params object[] args)
		{
			System.Diagnostics.Debug.WriteLine(format, args);
		}

		public void Trace(string format, params object[] args)
		{
			System.Diagnostics.Debug.WriteLine(format, args);
		}

		public void Warn(string format, params object[] args)
		{
			System.Diagnostics.Debug.WriteLine(format, args);
		}

		public void Error(string format, params object[] args)
		{
			System.Diagnostics.Debug.WriteLine(format, args);
		}

		public void Fatal(string format, params object[] args)
		{
			System.Diagnostics.Debug.WriteLine(format, args);
		}
	}
}
