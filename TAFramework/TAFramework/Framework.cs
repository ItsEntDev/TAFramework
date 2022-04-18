using System;
using System.Threading;

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
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
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
    }
}