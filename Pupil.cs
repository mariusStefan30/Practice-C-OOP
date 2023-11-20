//Pupil.cs
using System;

namespace MagicalInheritance
{
  //define class with two members
  class Pupil
  {
    //name of the pupil
    public string Title {get; private set;}
    //define constructor
    public Pupil(string title)
    {
      //set Title property
      Title = title;
    }
    //give the Pupil its spell: a CastWindStorm() method
    public Storm CastWindStorm()
    {
      //construct new Storm and return it
      return new Storm("wind", false, Title);
    }
  }
}
