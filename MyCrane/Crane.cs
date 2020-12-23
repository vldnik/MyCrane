using System;
namespace MyCrane
{
    public class Crane
    {
        bool On;
        int Direction;
        int CargoOnBoard;

        public Crane()
        {
            On = false;
            Direction = 0;
            CargoOnBoard = 0;
        }

        public void ToOn()
        {
            if (On == true)
            {
                throw new InvalidOperationException("Crane already on!");
            }
            else
            {
                On = true;
            }
        }
        public void ToOff()
        {
            if (On == false)
            {
                throw new InvalidOperationException("Crane already off!");
            }
            else
            {
                On = false;
            }
        }
        public void GetCargo(int cargo)
        {
            if (On == true && cargo > 0 && cargo < 200)
            {
                CargoOnBoard += cargo;
            }
            else
            {
                throw new InvalidOperationException("Crane couldn`t get cargo!");
            }
        }
        public void ToLeft()
        {
            if (On == false)
            {
                throw new InvalidOperationException("Turn on the crane!");
            }
            if (Direction == 0)
            {
                Direction = 270;
            }
            else
            {
                Direction -= 90;
            }
        }
        public void ToRight()
        {
            if (On == false)
            {
                throw new InvalidOperationException("Turn on the crane!");
            }
            if (Direction == 270)
            {
                Direction = 0;
            }
            else
            {
                Direction += 90;
            }
        }
        public string CraneNow()
            {
                return "Crane engine works = " + On + " ,now holds " + CargoOnBoard + " kg, and it`s direction on " + Direction + " degrees.";
            }
        
    }
}