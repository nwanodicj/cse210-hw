using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        int i = 0;
        while (i != 5)
        {
                Console.WriteLine("");
                Console.WriteLine("Welcome to the Journal Program!");
                Console.WriteLine("Please select one of the following options:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                Console.WriteLine("");
                Console.Write("What would you like to do? ");
                string Option = Console.ReadLine();
                int OptionNumber = int.Parse(Option);
                Console.WriteLine("");

                if (OptionNumber == 1)
                {
                        
                        Entry AddEntry1 = new Entry();
                        AddEntry1._date = DateTime.Now.ToString();
                        AddEntry1._promptText = "Who was the most interesting person I interacted with today? ";
                        Console.WriteLine($"DateTime: {AddEntry1._date}");
                        Console.Write(AddEntry1._promptText);
                        AddEntry1._EntryText = Console.ReadLine();
                        Console.WriteLine("");
        //      
                        Entry AddEntry2 = new Entry();
                        AddEntry2._date = DateTime.Now.ToString();
                        AddEntry2._promptText = "What was the best part of my day? ";
                        Console.WriteLine($"DateTime: {AddEntry2._date}");
                        Console.Write(AddEntry2._promptText);
                        AddEntry2._EntryText = Console.ReadLine();
                        Console.WriteLine("");
        //      
                        Entry AddEntry3 = new Entry();
                        AddEntry3._date = DateTime.Now.ToString();
                        AddEntry3._promptText = "How did I see the hand of the Lord in my life today? ";
                        Console.WriteLine($"DateTime: {AddEntry3._date}");
                        Console.Write(AddEntry3._promptText);
                        AddEntry3._EntryText = Console.ReadLine();
                        Console.WriteLine("");
        //      
                        Entry AddEntry4 = new Entry();
                        AddEntry4._date = DateTime.Now.ToString();
                        AddEntry4._promptText = "What was the strongest emotion I felt today? ";
                        Console.WriteLine($"DateTime: {AddEntry4._date}");
                        Console.Write(AddEntry4._promptText);
                        AddEntry4._EntryText = Console.ReadLine();
                        Console.WriteLine("");

                        Entry AddEntry5 = new Entry();
                        AddEntry5._date = DateTime.Now.ToString();
                        AddEntry5._promptText = "If I had one thing I could do over today, what would it be? ";
                        Console.WriteLine($"DateTime: {AddEntry5._date}");
                        Console.Write(AddEntry5._promptText);
                        AddEntry5._EntryText = Console.ReadLine();
                        Console.WriteLine("");
        //      
                        List<Entry> _entries = new List<Entry>();
                        _entries.Add(AddEntry1);
                        _entries.Add(AddEntry1);
                        _entries.Add(AddEntry2);
                        _entries.Add(AddEntry3);
                        _entries.Add(AddEntry4);
                        _entries.Add(AddEntry5);

                        Console.WriteLine("My Journal Entry:");    
                        Console.WriteLine("");  
                        foreach (Entry entry in _entries)
                        {  
                        Console.WriteLine($"DateTime: {entry._date}");
                        Console.WriteLine($"{entry._promptText}");

                        // I added a String "Answer" as my exceeding requirement
                        Console.WriteLine($"Answer: {entry._EntryText}");
                        Console.WriteLine("");
                        }

                        SaveToFile(_entries);
                }

                //string Journal = new Journal
                


                else if (OptionNumber == 2)
                {
                        List<Entry> newEntry = ReadFromFile();
                        foreach (Entry thenewEntry in newEntry)
                        {
                                Console.WriteLine(thenewEntry._date);
                                Console.WriteLine(thenewEntry._promptText);
                                Console.WriteLine(thenewEntry._EntryText);
                        }
                }

                else if (OptionNumber == 5)
                {
                        Console.WriteLine("");
                        Console.WriteLine("You are about to close the Journal Program!");
                        Console.WriteLine("Please enter 0 to Quit!");
                        Console.WriteLine("0. Close");
                        Console.WriteLine("");
                        Console.Write("Enter It Here: ");
                        string Option2 = Console.ReadLine();
                        int OptionNumber2 = int.Parse(Option);
                        Console.WriteLine("");

                        // I added this if-statement as my exceeding requirement
                        if (OptionNumber2 == 0)
                        {
                                Console.WriteLine("");
                        }
        
                }
                i += 1;
        }
        
    }

    public static void SaveToFile(List<Entry> _entries)
    {
        Console.WriteLine("Saving to file...");
        string file = "_entries.txt";
        using (StreamWriter outputfile = new StreamWriter(file))// Close and clean up the file when done
        {
            foreach (Entry entry in _entries)
            {
                outputfile.WriteLine(entry._date);
                outputfile.WriteLine(entry._promptText);
                outputfile.WriteLine($"Answer: ~~{entry._EntryText}");
                Console.WriteLine("");
            }
        }
    }

    public static List<Entry> ReadFromFile()
    {
        
        Console.WriteLine("Reading List from file...");
        List<Entry> _entries = new List<Entry>();
        
        string file = "_entries.txt";

        string[] Lines = System.IO.File.ReadAllLines(file);

        foreach(string line in Lines)
        {
                Console.WriteLine(line);
                //string [] parts = line.Split("~~");

                //Entry newEntry = new Entry();
                //newEntry._date = parts[0];
                //newEntry._promptText = parts[1];
                //newEntry._EntryText = parts[2];
//
                //_entries.Add(newEntry);
        }

        return _entries;
    }

}
