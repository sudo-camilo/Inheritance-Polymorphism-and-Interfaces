using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIT265_Truman_T_A3
{
	class Ship : Vessel, IRefillable
	{
		public Ship(float speed, string name, int fuel, int maxfuel) : base(speed, name)
		{
			Fuel = fuel;
			MaxFuel = maxfuel;
			Speed = speed;
			Name = name;
		}
		private int fuel;

		public int Fuel
		{
			get { return fuel; }
			set { fuel = value; }
		}

		private int maxfuel;

		public int MaxFuel
		{
			get { return maxfuel; }
			set { maxfuel = value; }
		}

		public override void Move()
		{
			if (fuel > 0)
			{
				Console.WriteLine($"Your ship, {Name}, has moved {Speed} squares.");
			}
			else
			{
				Console.WriteLine($"Your ship, {Name}, can't move, no fuel!");
			}
		}


		public void Refill(int amount)
		{
			//throw new NotImplementedException();
			Fuel += amount;
			if (Fuel > MaxFuel)
			{
				int mytemp;
				mytemp = Fuel - MaxFuel; //gets the overage amount
				Fuel = Fuel - mytemp; //then sets fuel to whatever the max is
			}
			Console.WriteLine($"You now have {Fuel} out of {MaxFuel} fuel!");
		}


		float IRefillable.FuelPercentage 
		{
			get => (float)Fuel / MaxFuel * 100;
			//get { return Fuel / MaxFuel; }
		}

		//float IRefillable.FuelPercentage => throw new NotImplementedException();
	}
}
