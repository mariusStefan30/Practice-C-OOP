//Storm.cs
using System;

//namespace
namespace MagicalInheritance 
{
  class Storm 
  {
    //define three automatic properties
    //the type of storm, like wind or rain
    public string Essence {get; private set;}
    //true if storm is strong
    public bool IsStrong {get; private set;}
    //the title of the magician casting the storm
    public string Caster {get; private set;}

    //define a constructor that takes three arguments
    public Storm(string essence, bool isStrong, string caster)
    {
      //use arguments to set the properties
      Essence = essence;
      IsStrong = isStrong;
      Caster = caster;
    }

    //define a public Announce() method that returns a string
    public string Announce()
      //the string should use all three properties
    {
      //check IsStrong
      if(IsStrong == true)
      {
        return $"{Caster} cast a strong {Essence} storm!";
      }
      else
      {
        return $"{Caster} cast a weak {Essence} storm!";
      }
    }
}
