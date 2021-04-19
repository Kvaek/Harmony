using DSharp.Core;

namespace DSharp.Example {
	internal class Program : DiscordClient {
		public Program() {
			Token = "";
			Prefix = '.';
			AutoReconnect = true;
			
		}

		private static void Main(string[] args) { }
	}
}