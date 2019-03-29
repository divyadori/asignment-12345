using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;*/
using System.IO;
namespace streamreaderexample
{
    public class streamreaderexample
    {
        public static void Main()
        {
            StreamReader reader = new StreamReader("test.txt");
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
                String[] array1 = Directory.GetFiles(@"C:\Users\Dell\source\repos");
                Console.WriteLine("files in the directory");
                foreach(string name in array1)
                {
                    Console.WriteLine(name);
                }


                Console.ReadLine();
            }
        }
    }
}
