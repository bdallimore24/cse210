using System;

class Program
{
    static void Main(string[] args)
    {

        Address lectureAddress = new Address("578 Main St", "Rexburg", "Idaho", "84562");
        Address receiptionAddress = new Address("987 May Ave", "Ammon", "ID", "83403");
        Address outdoorAddress = new Address("123 Hoops Ave", "Idaho Falls", "ID", "83402");


        Lecture lecture = new Lecture("Learn Volleyball", "Joe Smith will teach you trick in Volleyball", new DateTime(2024, 6, 19), new TimeSpan(15, 00, 00), lectureAddress, "Joe Smith", 120);
        Reception reception = new Reception("Joe and Jane's 50th", "Come celebrate with Joe and Jane!", new DateTime(2024, 5, 23), new TimeSpan(17, 00, 00), receiptionAddress, "rsvp@example.com");
        Outdoor outdoor = new Outdoor("Apocalypse 101", "Learn How to Prep for the End!", new DateTime(2024, 3, 18), new TimeSpan(11, 00 , 00), outdoorAddress, "Sunny with Cloud, with a high of 80F");


        Event[] events = new Event[] { lecture, reception, outdoor };


        foreach (Event eventInstance in events)
        {

            System.Console.WriteLine("Standard Details:\n" + eventInstance.GetStandardDetails());
            System.Console.WriteLine("\nFull Details:\n" + eventInstance.GetFullDetails());
            System.Console.WriteLine("\nShort Description:\n" + eventInstance.GetShortDescription());
            System.Console.WriteLine("\n---------------------\n"); 
            
        }
    }
}