using System;
using System.IO;


class Program
{
    static void Main(string[] args)
    {   

        Random randomgen1 = new Random();
        
        List<Scripture> scriptures = new List<Scripture>();

        string file = "script.txt";
        string exit = "";

        Console.Clear();
        Console.WriteLine("This is a program to memorize scriptures! Are you ready to do some memerizing?");
        Console.WriteLine("Enter anytime the word 'quit' to exit this program.");
        Console.WriteLine("Press ENTER to continiue");
        Console.WriteLine("");
        Console.Write("> ");

        exit = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(file);
        int scriptNumber = 0;
        
        foreach (string script in lines)
            {

                scriptNumber += 1;
                string[] part = script.Split("|");
                string book = part[0];
                int chapter = Int32.Parse(part[1]);
                int startverse = Int32.Parse(part[2]);
                int endverse = Int32.Parse(part[3]);
                string verse = part[4];


                if(startverse == endverse)
                {

                    Reference ref1 = new Reference(book,chapter,startverse);
                    Scripture script1 = new Scripture(ref1, verse);
                    scriptures.Add(script1);

                }

                else
                {
                    Reference ref1 = new Reference(book,chapter,startverse,endverse);
                    Scripture script1 = new Scripture(ref1, verse);
                    scriptures.Add(script1);
                    
                }
                
            }


        int scriptPick = randomgen1.Next(0,scriptNumber);
        Console.Clear();
        Scripture script2 = scriptures[scriptPick];
        string script3 = script2.GetDisplayText();
        Console.WriteLine(script3);
        exit = Console.ReadLine();
        while(exit != "quit")
        {

            Console.Clear();

            script2.HideRandomWords();
            script3 = script2.GetDisplayText();
            Console.WriteLine(script3);


            if(script2.IsCompletelyHidden() == true)

            {

                Console.WriteLine("That is every word!");
                exit = "quit";

            }

            else
            
            {

                exit = Console.ReadLine();

            }


        }
        
    }
}