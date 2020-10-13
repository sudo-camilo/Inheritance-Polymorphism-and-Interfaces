using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CIT265_Truman_T_A3
{
    public abstract class Vessel
    {
		public Vessel(float speed, string name)
		{
			Speed = speed;
			Name = name;
		}

		private float speed;

		public float Speed
		{
			get { return speed; }
			set { speed = value; }
		}

		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public virtual void Move()
		{
			//empty because abstract
		}

	}
}
