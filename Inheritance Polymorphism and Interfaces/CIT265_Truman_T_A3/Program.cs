//Tyler Truman
//Dr. Mauro
//CIT 265
//Assignment 3
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIT265_Truman_T_A3
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating some ships and boats
            Ship unsinkable = new Ship(20, "The Unsinkable II", 15, 30);
            Ship beyonce = new Ship(25, "Buoyance", 25, 30);

            Boat butIgotTheboat = new Boat(10, "She Got The House", 2);
            Boat imInaMeeting = new Boat(20, "A Meeting", 4);

            Vessel[] vessels = new Vessel[4];
            vessels[0] = unsinkable;
            vessels[1] = beyonce;
            vessels[2] = butIgotTheboat;
            vessels[3] = imInaMeeting;

            foreach (var item in vessels)
            {
                item.Move();
            }

            Console.WriteLine("\n\n_______________________________________________\n\n");

            Cat Pinky = new Cat(25, 100);//no name is required for cat, per instructions

            IRefillable P = Pinky;
            //float someFloat = P.FuelPercentage; i just did this within the line instead using discarded float val. Quick actions suggested it to me
            Console.WriteLine($"We start off with {_ = P.FuelPercentage} percentage.");
            Pinky.Refill(10); //subtracts and works as should, because lower is better
            Console.WriteLine($"After doing refill, we have {_ = P.FuelPercentage} percentage.");

            IRefillable U = unsinkable;
            Console.WriteLine($"We start off with {_ = U.FuelPercentage} percentage.");
            unsinkable.Refill(260); //doesn't work, as intended, just caps you at full.
            //unsinkable.Refill(10); //this one does work, however!
            Console.WriteLine($"After doing refill, we have {_ = U.FuelPercentage} percentage.");

        }
    }
}
