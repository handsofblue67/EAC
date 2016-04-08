using System;

namespace YOUR_NAMESPACE
{
	abstract public class Alive
	{
		public int Attack { get; set; }
		public int Defense { get; set; }
		public Image MyImage { get; set; }
	}

	public class Monster : Alive
	{

	}

	public class Hero : Alive

	{
		public int Health { get; set; }
		public int Runs { get; set; }
		public int KillCount { get; set; }
	}
}

