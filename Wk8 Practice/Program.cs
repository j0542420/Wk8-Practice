using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk8_Practice
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person() 
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //string writeText = "Hello World!";  // Create a text string
            //File.WriteAllText("filename.txt", writeText);  // Create a file and write the content of writeText to it

            //File.AppendAllText("D:\\filename.txt", Environment.NewLine + "This is a second line"); // Append new text to the file

            //string readText = File.ReadAllText("D:\\filename.txt");  // Read the contents of the file
            //Console.WriteLine(readText); //outputs content

            //StreamWriter writer = new StreamWriter("C:\\temp\\stream1.txt");

            //writer.Write("Line1");

            //writer.WriteLine("Line2");

            //writer.WriteLine("Line3");

            //writer.Close();

            StreamReader reader = new StreamReader("C:\\temp\\newperson.csv");

            string line = "";
            while ((line = reader.ReadLine()) != null) //read line until end of file
            {
                if (line.Contains("Name"))
                {
                    continue;//skip first line
                }
                else
                {
                    //john1, 21
                    string[] parts = line.Split(','); // chop line into 2 part, name and age

                    Person p = new Person(parts[0], Convert.ToInt32(parts[1])));

                    persons.Add(p);
                }
            }

            foreach(Person p in persons)
            { 
                Console.WriteLine(p.Name + " " + p.Age);
            }
            //try to create a new csv file with letter grade pass or faild
            StreamReader reader = new StreamReader("C:\\temp\\newperson.csv");
            writer.WriteLine("Name, Age, Grade");
            foreach (Person p in persons)
            {
                if(p.Age > 70)
                {
                    Console.WriteLine(p.Name + " " + p.Age);
                }
                else
            }

            Console.Read();
        }
    }
}
