using System;
using System.Collections.Generic;
using System.Text;

namespace CarSimulator.Domain
{
    // TeslaModel3 is a Car
    class TeslaModel3 : Car
    {
        // Vi behöver skapa en konstruktor som skickar vidare värden nere till 
        // base classen ---> Car. 
        // Den konstruktor tar in registrationNumber.
        // Den Car har en konstruktor som tar in brand, model, registrationNumber.
        // Om vi vill ärva från Car måste vi anroppa den.
        // Det gör vi här att skriva base då vi anroppar den ärvda klassen konstruktor.
        public TeslaModel3 (string registrationNumber)
            // base är motsvarar(corresponds), det är Car som vill ha in parameters
            // brand, model, registrationNumber. Det registrationNumber tar vi in utefrån 
            // och skickar in till registration i den konstruktor 
            : base("Tesla", "Model 3", registrationNumber)
        {

        }

        public override void Accelerate(int seconds)
        {
            Velocity = (int)(seconds * 4 * 3.6);
        }
    }
}
