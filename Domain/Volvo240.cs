using System;
using System.Collections.Generic;
using System.Text;

namespace CarSimulator.Domain
{
    class Volvo240 : Car
    {
        public Volvo240 (string registrationNumber) 
            : base("Volvo", "240", registrationNumber)
        {

        }

        public override void Accelerate(int seconds)
        {
            Velocity = (int)(seconds * 4 * 2.6);
        }
    }
}
