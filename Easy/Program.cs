using System;

namespace Easy
{
	class Program
	{
		static void Main(string[] args)
		{
			var player = new Player();
			player.Health -= 10;

			Console.WriteLine(player.CheckAlive());
			Console.ReadKey();
		}
	}
}
