using System;

namespace Harmony.Core.Utils {
	[Flags]
	public enum LogLevel {
		/// <summary>
		/// Log a TRACE message
		/// </summary>
		TRACE,
		/// <summary>
		/// Log an INFO message
		/// </summary>
		INFO,
		/// <summary>
		/// Log a DEBUG message
		/// </summary>
		DEBUG,
		/// <summary>
		/// Log a WARN message
		/// </summary>
		WARNING,
		/// <summary>
		/// Log an ERROR message
		/// </summary>
		ERROR,
		/// <summary>
		/// Log a FATAL message
		/// </summary>
		FATAL
	}
}