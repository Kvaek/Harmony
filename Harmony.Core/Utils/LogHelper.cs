using System;

namespace Harmony.Core.Utils {
	// TODO: Make useful and pretty
	/// <summary>
	/// Simple Console.WriteLine() wrapper with LogLevel, colors etc.
	/// </summary>
	public class LogHelper {
		private static readonly object _lock = new object();
		private const string DatetimeFormat = "yyyy-MM-dd HH:mm:ss";

		/// <summary>
		/// Initiate an instance of LogHelper class constructor.
		/// </summary>
		public LogHelper() {
		}

		/// <summary>
		/// Print a message with a specific "level" to the console
		/// <param name="level">Severity</param>
		/// <param name="text">Message</param>
		/// </summary>
		public static void Log(LogLevel level, string text) {
			lock (_lock) {
				Console.WriteLine($"{DateTime.Now.ToString(DatetimeFormat)} [{level}]		{text}");
			}
		}
	}
}