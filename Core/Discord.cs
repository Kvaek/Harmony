namespace DSharp.Core {
	public abstract class DiscordClient {
		public string Token { private get; set; }

		public char Prefix { get; set; } = '!';

		public bool AutoReconnect { private get; set; } = true;
	}
}