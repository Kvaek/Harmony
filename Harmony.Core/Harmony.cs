using System;
using System.Threading;

namespace Harmony.Core {
	public class Harmony : HarmonyBase {
		public Thread TickTask { get; private set; }
		public string Token { get; set; }
		public char Prefix { get; set; }
		public bool AutoReconnect { get; set; }

		public void TickHarmony() {
			const double ns = 1000000000.0 / 20.0;
			double delta = 0;

			long lastTime = DateTime.Now.Ticks * 100;

			while (true) {
				long now = DateTime.Now.Ticks * 100;
				delta += (now - lastTime) / ns;
				lastTime = now;
				while (delta >= 1) {
					Tick();
					delta--;
				}
			}
		}
		
		public void Init() {
			Start();
			TickTask = new Thread(TickHarmony);
			TickTask.Start();
		}

		public void Dispose() {
			TickTask.Abort();
			Stop();
		}

		public override void Tick() => throw new NotImplementedException();

		public override void Start() => throw new NotImplementedException();

		public override void Stop() => throw new NotImplementedException();
	}
	public abstract class HarmonyBase {
		public string Token { get; set; }
		public char Prefix { get; set; }
		public bool AutoReconnect { get; set; }
		public abstract void Tick();
		public abstract void Start();
		public abstract void Stop();
	}
}