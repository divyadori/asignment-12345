﻿using System;
using System.IO;
namespace streamreaderexample
{
    public class streamreaderexample
    {
        public static void Main()
        {
            StreamReader reader = new StreamReader("teststream.txt");
            using (reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);
                    line = reader.ReadLine();
                }
            }
        }
    }
}
