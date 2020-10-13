using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIT265_Truman_T_A3
{
    public interface IRefillable
    {
        void Refill(int amount);

        float FuelPercentage { get; }
    }
}
