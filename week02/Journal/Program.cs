using System;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        
        Journal currentJournal = null;

        bool programActive = true;

        while(programActive){
            Console.WriteLine("Menu: ");
            Console.WriteLine("   1. Write");
            Console.WriteLine("   2. Display");
            Console.WriteLine("   3. Load");
            Console.WriteLine("   4. Save");
            Console.WriteLine("   5. Quit");

            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();


            switch (userInput)
            {
                case "1":
                    if(!checkForJournal(currentJournal))
                    {
                        currentJournal = new Journal();
                        currentJournal._owner.InputPersonalData();
                    }

                    currentJournal.CreateNewEntry();

                    break;
                case "2":
                    if(!checkForJournal(currentJournal))
                    {
                        currentJournal = new Journal();
                        currentJournal._owner.InputPersonalData();
                    }

                    currentJournal.DisplayJournal();

                    break;
                case "3":

                    // if(!checkForJournal(currentJournal))
                    // {
                    //     currentJournal = new Journal();
                    //     currentJournal._owner.InputPersonalData();
                    // }

                    Console.Write("Enter file to load: ");
                    string loadFileName = Console.ReadLine();

                    string load = File.ReadAllText($"{loadFileName}.json");
                    currentJournal = JsonSerializer.Deserialize<Journal>(load);

                    break;
                case "4":
                    Console.Write("Enter file name to save: ");
                    string saveFileName = Console.ReadLine();

                    // string json = JsonSerializer.Serialize(currentJournal);
                    // File.WriteAllText($"{saveFileName}.json", json);

                    // Serialize the list to a JSON string
                    string json = JsonSerializer.Serialize(currentJournal, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText($"{saveFileName}.json", json);

                    Console.WriteLine("List serialized and saved!");

                    break;
                case "5":
                    programActive = false;
                    break;
                default:
                    Console.WriteLine("\nPlease select a valid menu number. \n");
                    break;
            }



        }
    }

    static bool checkForJournal(Journal journal)
    {
        if(journal == null){
            return false;

        } else {
            return true;
        }
    }
}