using System;

namespace TAFramework
{
    public class Datastore
    {
        public class Config
        {
            // This is effectively the configuration file.
            public static string AQPointer = " >> "; // The pointer that the askQuestion() function uses after the question.
        }

        public class Internal
        {
            // Do not change anything in here (unless you are a developer).
            public static string Version = "0.0.3";
            public static string Name = "TAFramework"; // I'm not even sure why this exists - ItsEntDev
            public static string Author = "ItsEntDev";
            public static string Description = "A framework for creating text adventures without needing extra functions.";
        }
    }
}