using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace copyfile
{
    class Program
    {
        public static void Main()
        {
            CopyFile cp = new CopyFile();
            string file1 = @"C:\Users\Dell\source\repos\copyfile\copyfile\bin\Debug\file1.txt";
            string file2= @"C:\Users\Dell\source\repos\copyfile\copyfile\bin\Debug\file2.txt";
            cp.copyfile(file1, file2);
            Console.WriteLine("file copied from file1 to file2");
            Console.ReadLine();
        }

    }
    public class CopyFile
    {
        public void copyfile(string file1, string file2)
        {

            using (StreamReader reader = new StreamReader(file1))
            {
                using (StreamWriter writer = new StreamWriter(file2))
                {
                    String line = null;
                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine(line);
                    }
                }
            }


        }
    }
}
