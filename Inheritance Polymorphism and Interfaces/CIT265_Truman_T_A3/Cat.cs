using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIT265_Truman_T_A3
{
	class Cat : IRefillable
	{
		public Cat(int hunger, int maxhunger)
		{
			Hunger = hunger;
			MaxHunger = maxhunger;
		}

		private int hunger;

		public int Hunger
		{
			get { return hunger; }
			set { hunger = value; }
		}

		private int maxhunger;

		public int MaxHunger
		{
			get { return maxhunger; }
			set { maxhunger = value; }
		}

		public float FuelPercentage 
		{
			get => (float)Hunger / MaxHunger * 100;
			//get { return Hunger / MaxHunger; }
		}	

		public void Refill(int amount)
		{
			Hunger = Hunger - amount; //hunger gets reduced by the amount provided, because
									  //although it gets subtracted, having 0 hunger is a good thing
			if (Hunger < 0)
			{
				Hunger = Hunger - Hunger; //then sets hunger to 0, since they're negative
				//it gets easier than within ship, like -9 - -9 is 0.
			}
			Console.WriteLine($"Cat now has {Hunger} out of {MaxHunger} hunger!");
		}
	}
}
