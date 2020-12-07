using System;
using System.Collections.Generic;

class Riddle
{
  static void Main()
  {
    Console.WriteLine("The more I take the more I leave behind, what am I?");
    string answer = Console.ReadLine();
    bool word = answer == "Footsteps";
    bool word2 = answer == "footsteps";

    if (word || word2)
    {
      Console.WriteLine("Correct, how are you so smart! Im defeated, onto the next question.");
    }else 
    {
      Console.WriteLine("Wrong! I ate you");
    }

    Console.WriteLine("Alright, how about another one?");
    Console.WriteLine("What has to be broken before you can use it? Im defeated");
    string newanswer = Console.ReadLine();
    bool newword = newanswer == "Egg";
    bool newword2 = newanswer == "egg";

    if (newword || newword2)
    {
      Console.WriteLine("Correct, how are you so smart! Im defeated, onto the next question.");
    }else 
    {
      Console.WriteLine("Wrong! I ate you,");
    }

  }
}