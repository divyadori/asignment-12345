using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3
{
    public class Add
    {
        public void add()
        {
            int[,] m1 = new int[50, 50];
            int[,] m2 = new int[50, 50];
            int[,] m3 = new int[50, 50];
            Console.WriteLine("enter size of array:");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter first array:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    m1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("enter second array:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    m2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    m3[i, j] = m1[i, j] + m2[i, j];
                }
            }
            Console.WriteLine("addition array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < size; j++)
                {
                    Console.Write("{0}\t", m3[i, j]);
                }
                Console.Write("\n");
            }
        }
        public int add(int a, int b)
        {
            return (a + b);
        }
    }
        public class Vector
        {
            public void add()
            {
                Console.WriteLine("enter first vector");
                int x = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());
                int z = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter second vector");
                int x1 = Convert.ToInt32(Console.ReadLine());
                int y1 = Convert.ToInt32(Console.ReadLine());
                int z1 = Convert.ToInt32(Console.ReadLine());
                int x2 = x + x1;
                int y2 = y + y1;
                int z2 = z + z1;
                Console.WriteLine("<" + x2 + "," + y2 + "," + z2 + ">");

            }
        }

      
        
   
    


    class Program
    {
        static void Main(string[] args)
        {
            
            Add a1 = new Add();
            Vector v1 = new Vector();
            v1.add();
            a1.add();
            int res=a1.add(1, 2);
            Console.Write("method overloading for addtion{0}",res);
            Console.ReadLine();
            
        }
    }
}
