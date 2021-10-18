using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Notepad_Auto_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:/Users/prest/OneDrive/Desktop/HPADocument.txt";
            System.Console.Write("Start Notepad? (y/n): ");

            string runNotePadAnswer = System.Console.ReadLine();

            if (runNotePadAnswer == "n")
            {
                System.Console.WriteLine("Goodbye");
            }
            else if (runNotePadAnswer == "y")
            {
                NotePadCheck();
                IsFileCreated(filePath);
                WriteToNotePadFile(filePath);
                Console.WriteLine("Document saved");
            }
            else
            {
                System.Console.WriteLine($"Please select an answer");
            }

        }

        //check to see if notepad is open as well as open it if it isnt open.
        static void NotePadCheck()
        {
            Process[] processes = Process.GetProcessesByName("notepad");
            if (processes.Length == 0)
            {
                Console.WriteLine("Notepad is not running, starting now.");
                System.Diagnostics.Process.Start("Notepad.exe");
            }
            else
            {
                Console.WriteLine("NotePad is already running.");
            }
        }

        static bool IsFileCreated(string filePath)
        {
            if (File.Exists(filePath))
            {
                Console.WriteLine("This file already exists, overwriting it.");
                return true;
            }
            else
            {
                Console.WriteLine("Creating File");
                return false;
            }
        }

/*        static void OpenSpecifiedFile()
        {
            
        }*/



            static void WriteToNotePadFile (string filePath)
            {
            /*        https://www.youtube.com/watch?v=hs74fKPJpFw */
            Console.WriteLine("Writing content to HPADocument.TXT");
            StreamWriter File = new StreamWriter(filePath);
            File.Write("Hello World");
            File.Close();


            /*        https://www.youtube.com/watch?v=j6ShXTjG5fg */
            /*          THIS IS THE ORIGINAL CODE I USED BUT THE CODE BELOW WAS SIMPLER AND DID ITS JOB BETTER
             *          string filePath = @"C:\Users\prest\OneDrive\Desktop\HPADocument.txt";

                        List<string> lines = new List<string>();
                        lines = File.ReadAllLines(filePath).ToList();

                        foreach (String line in lines)
                        {
                            Console.WriteLine(line);
                        }

                        lines.Add("Hello World");
                        File.WriteAllLines(filePath, lines);

                        Console.ReadLine();*/



        }
    }
}
