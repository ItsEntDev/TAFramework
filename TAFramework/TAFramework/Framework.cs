using System;
using System.Threading;
using System.IO;

namespace TAFramework
{
    public class Framework
    {
        public class TextConsole
        {
            public static string AskQuestion(string question)
            {
                if (question == null) // can't ask question with value null
                {
                    Console.WriteLine("Invalid question.");
                    return "invalid";
                }
                else
                {
                    Console.Write(question + " >> ");
                    string? answer = Console.ReadLine();
                    if (answer == null) // prevent possible null returns
                    {
                        Console.WriteLine("Invalid response.");
                        return "invalid";
                    }
                    return answer; // return the answer as a string
                }
            }
            public static void Wait(int millisecondTime)
            {
                // wait for time millisecondTime by sleeping thread
                Thread.Sleep(millisecondTime);
                return;
            }

            public static void ClearConsole()
            {
                // clear the console
                Console.Clear();
                return;
            }
            public static void ExecuteProgram(string program)
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal; // standard window style
                startInfo.FileName = program;
                process.StartInfo = startInfo;
                process.Start(); // this is just a bunch of technical junk
                return;
            }
            public static void MultiPrint(string text, int amount)
            {
                // while loop that loops amount times
                while (amount > 0)
                {
                    Console.WriteLine(text);
                }
                return;
            }
        }
        public class Player
        {
            public static void PlayerLose(string failMessage)
            {
                Console.Clear();
                Framework.TextConsole.Wait(1000);
                Console.Write(".");
                Framework.TextConsole.Wait(1000);
                Console.Write(".");
                Framework.TextConsole.Wait(1000);
                Console.Write(".");
                Framework.TextConsole.Wait(1000);
                Console.Clear();
                Console.WriteLine(failMessage);
                Framework.TextConsole.Wait(5000);
                Console.Clear();
                Console.WriteLine("Goodbye!");
                Framework.TextConsole.Wait(3000);
                return;
            }
            public static void PlayerWin(string winMessage)
            {
                Console.Clear();
                Framework.TextConsole.Wait(1000);
                Console.Write(".");
                Framework.TextConsole.Wait(1000);
                Console.Write(".");
                Framework.TextConsole.Wait(1000);
                Console.Write(".");
                Framework.TextConsole.Wait(1000);
                Console.Clear();
                Console.WriteLine(winMessage);
                Framework.TextConsole.Wait(5000);
                Console.Clear();
                Console.WriteLine("Well done, and goodbye!");
                Framework.TextConsole.Wait(3000);
                return;
            }
        }
        public class Utilities
        {
            public static string ToUpper(string text)
            {
                // turn input text to uppercase
                string output = text.ToUpper();
                return output;
            }
            public static string ToLower(string text)
            {
                // turn input text to lowercase
                string output = text.ToLower();
                return output;
            }
            public static string Capitalise(string text)
            {
                // capitalise the first letter of the input text
                string output = text.Substring(0, 1).ToUpper() + text.Substring(1).ToLower();
                return output;
            }
            public static string Reverse(string text)
            {
                // reverse the input text
                string output = "";
                for (int i = text.Length - 1; i >= 0; i--)
                {
                    output += text[i];
                }
                return output;
            }
            public static string Shuffle(string text)
            {
                // shuffle the input text
                string output = "";
                Random rnd = new Random();
                for (int i = 0; i < text.Length; i++)
                {
                    int index = rnd.Next(0, text.Length);
                    output += text[index];
                }
                return output;
            }
            public static string ReverseShuffle(string text)
            {
                // reverse the input text and shuffle it
                string output = "";
                Random rnd = new Random();
                for (int i = text.Length - 1; i >= 0; i--)
                {
                    int index = rnd.Next(0, text.Length);
                    output += text[index];
                }
                return output;
            }
            public static string ReverseCapitalise(string text)
            {
                // reverse the input text and capitalise the first letter
                string output = "";
                for (int i = text.Length - 1; i >= 0; i--)
                {
                    output += text[i];
                }
                output = output.Substring(0, 1).ToUpper() + output.Substring(1).ToLower();
                return output;
            }
            public static string ReverseShuffleCapitalise(string text)
            {
                // reverse the input text, shuffle it and capitalise the first letter
                string output = "";
                Random rnd = new Random();
                for (int i = text.Length - 1; i >= 0; i--)
                {
                    int index = rnd.Next(0, text.Length);
                    output += text[index];
                }
                output = output.Substring(0, 1).ToUpper() + output.Substring(1).ToLower();
                return output;
            }
            /* disabled because it doesn't work. remember to fix
            public static void DrawASCII(string image)
            {
                // draw an ascii image based on the input image
                string[] lines = File.ReadAllLines(image);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
                return;
            }
            */
        }
    }
}