using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the Journal Program!");
        Journal myentry = new Journal();
        PromptGenerator promptgen = new PromptGenerator();

        int choice = -1;
        while (choice != 5)
    
        {

            Console.WriteLine("Welcome to the journal program!"); 
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit\n");
            Console.Write("What would you like to do? \n");
    
            choice = int.Parse(Console.ReadLine());

            switch(choice)
            {

            case 1:
                Entry newEntry = new Entry();
                

                newEntry.date = DateTime.Today.ToString("MM/dd/yyyy");
                newEntry.prompt = promptgen.GetPrompt();
                Console.WriteLine($"{newEntry.prompt}");
                newEntry.entry = Console.ReadLine();
                myentry.entries.Add(newEntry);
                break;
            
        
            case 2:
            Console.WriteLine();
            myentry.DisplayJournal();
            break;
        
            case 3:
            Console.WriteLine();
            Console.WriteLine("What is the filename?: ");
            string file = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(file);
            foreach (string line in lines)

            {

                string[] parts = line.Split("-");
                string date = parts[0];
                string prompt = parts[1];
                string answer = parts[2];

            }
            
            break;

            case 4:
            Console.WriteLine("What is the filename?: ");
            file = Console.ReadLine();
            Console.WriteLine("saving, please wait");
            using (StreamWriter outputFile = new StreamWriter(file))
            {
    
                foreach (Entry entry in myentry.entries)

                {

                    outputFile.WriteLine($"Date: {entry.date}");
                    outputFile.WriteLine($"Prompt: {entry.prompt}");
                    outputFile.WriteLine($"Entry: {entry.entry}");
                
                }     
            };

            Console.WriteLine("Saved!");          
            break;
            
            }    

        }
    }

}