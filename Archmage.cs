//Archmage.cs
using System;

namespace MagicalInheritance
{
  //define next rank Archmage class which inherits from Mage
  class Archmage : Mage
  {
    //add Archmage constructor with one string argument, it should call the base constructor with the same argument
    public Archmage(string title) : base(title)
    {
    }
    //override the CastRainStorm() spell, public with type of Storm
    public override Storm CastRainStorm()
    {
      //construct new Storm object and return it
      retun new Storm("rain", false, Title);
    }
    //add one more spell in Archmage, public type Storm
    public Storm CastLightStorm()
    {
      //construct new Storm object and return it
      return new Storm("linghtning", true, Title);
    }
  }
}
