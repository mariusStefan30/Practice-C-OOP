using System;

namespace MagicalInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
        //test class
        //construct new Storm with "wind" Essence, NOT be strong, be cast by "Zul'rajas". 
      //Storm testStorm = new Storm("wind", false, "Zul'rajas");
        //call Announce and print the result in the console
      //Console.WriteLine(testStorm.Annouce());

      //construct a new Pupil named Mezil-kree
      Pupil pupilOne = new Pupil("Mezil-kree");

      // after constructing a new object, call CastWindStorm() and store the result in a variable.
      Storm windStorm = pupilOne.CastWindStorm();
      //call Announce and print the result in the console
      Console.WriteLine(windStorm.Announce());

      //construct a new Mage named Gul’dan. 
      Mage mageOne = new Mage("Gul'dan");

      //after constructing a new object, call CastRainStorm() and store the result in a variable.
      Storm rainStorm = mageOne.CastRainStorm();
      //call Announce and print the result in the console
      Console.WriteLine(rainStorm.Announce());

      //construct a new Archmage named Nielas Aran. 
      Archmage archmageOne = new Archmage("Nielas Aran");

      //after constructing a new object, call CastRainStorm() and CastLightningStorm() and store the results in variables
      Storm archmageRainStorm = archmageOne.CastRainStorm();
      Storm archmageLightningStorm = archmageOne.CastLightningStorm();

      //call Announce to make sure they are correct
      Console.WriteLine(archmageRainStorm.Announce());
      Console.WriteLine(archmageLightningStorm.Anonunce());
    }
  }
}
