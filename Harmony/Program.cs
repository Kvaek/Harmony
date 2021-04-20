using System.Threading;
using Harmony.Core.Utils;

namespace Harmony {
	public class Harmony : Core.Harmony {
		public string Token { get; set; }
		public char Prefix { get; set; }
		public bool AutoReconnect { get; set; }

		public override void Tick() {
			LogHelper.Log(LogLevel.DEBUG, "Tick()");
		}

		public override void Start() {
			LogHelper.Log(LogLevel.DEBUG, "Start()");
		}

		public override void Stop() {
			LogHelper.Log(LogLevel.DEBUG, "Stop()");
		}

		private static void Main(string[] args) {
			Harmony bot = new Harmony();
			bot.Init();
			new CancellationTokenSource().Token.WaitHandle.WaitOne();
		}
	}
}