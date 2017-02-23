using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            
            System.IO.StreamWriter T1TextLines = new System.IO.StreamWriter("T1TextLines.txt");

            Console.Write("Give a text line (enter ends): ");
            string line = Console.ReadLine();
            T1TextLines.WriteLine(line);
            
            while (line != "")
            {
                Console.Write("Give a text line (enter ends): ");
                line = Console.ReadLine();
                T1TextLines.WriteLine(line);
                
            }
            T1TextLines.Close();

            try
            {
                string text = System.IO.File.ReadAllText("T1TextLines.txt");
                System.Console.WriteLine("Contents of T1 Text Lines:\n" + text);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }            
        }
    }
}
