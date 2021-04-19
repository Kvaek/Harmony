namespace Harmony.Core {
	public abstract class Discord {
		public string Token { private get; set; }

		public char Prefix { get; set; } = '!';

		public bool AutoReconnect { private get; set; } = true;
	}
}