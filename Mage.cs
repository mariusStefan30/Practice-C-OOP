//Mage.cs
using System;

namespace MagicalInheritance
{
  //define a Mage class that inherits from Pupil
  class Mage : Pupil
  {
    //add Mage constructor with string argument. It should call the base constructor with same argument
    public Mage(string title) : base(title) 
    {
    }

    //give Mage new spell: CastRainStorm()
    public virtual Storm CastRainStorm()
    {
      //construct new Storm and return it, This is a weak storm cast by mage
      return new Storm("rain", false, Title);
    }
  }
}
