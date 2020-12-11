using System;
using System.Collections.Generic;

public class Riddle
{
  public string Question;
  public string Answer;

  public Riddle(string question, string answer)
  {
    Question = question;
    Answer = answer;
  }
}

public class Program
{
  public static void Main()
  {
    Random rnd = new Random();
    
    Riddle riddle1 = new Riddle("The more I take the more I leave behind, what am I?", "Footsteps");
    Riddle riddle2 = new Riddle("What has to be broken before you can use it?", "Egg");
    Riddle riddle3 = new Riddle("What month of the year has 28 days?", "All");
    Riddle riddle4 = new Riddle("What gets wet while drying?", "Towel");

    List<Riddle> Riddles = new List<Riddle>(){riddle1, riddle2, riddle3, riddle4};
    
    int num = rnd.Next(0,4);

    string thisRiddde = Riddles[num].Question;
    string thisRiddleAnswer = Riddles[num].Answer;
    Console.WriteLine(thisRiddde);

    string answer = Console.ReadLine();
    bool word = answer == thisRiddleAnswer;


    if (word)
    {
      Console.WriteLine("Correct, how are you so smart! Im defeated, onto the next question.");
    }else 
    {
      Console.WriteLine("Wrong! I ate you");
    }  
  }
}