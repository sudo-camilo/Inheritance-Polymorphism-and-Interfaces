using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIT265_Truman_T_A3
{
    class Boat: Vessel
    {
		public Boat(float speed, string name, int oars) : base(speed, name)
		{
			Oars = oars;
			Speed = speed;
			Name = name;
		}
		private int oars;

		public int Oars
		{
			get { return oars; }
			set { oars = value; }
		}

		public override void Move()
		{
			if (oars > 0)
			{
				float tempvar = 0;
				tempvar = Speed * Oars;
				Console.WriteLine($"Your boat, {Name}, has moved {tempvar} squares.");
			}
			else
			{
				Console.WriteLine($"Your boat, {Name}, can't move, no oars!");
			}
		}

	}
}
