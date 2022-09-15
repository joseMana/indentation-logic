using System;
using System.Collections.Generic;

namespace Logger
{
    class Program
    {

        static void Main(string[] args)
        {
            var newList = new List<string>();
            var indent = 0;
            var list = new List<string> {
                "Entered",
                "Setting",
                "Entered",
                "Setting",
                "Entered",
                "Setting",
                "Entered",
                "Setting",
                "Exiting",
                "Doing Something",
                "Exiting",
                "Exiting",
                "Exiting",
            };


            foreach (var item in list)
            {
                if (item.Contains("Entered"))
                {
                    newList.Add(new string(' ', indent) + item);
                    indent += 4;
                }
                else if (item.Contains("Exiting"))
                {
                    indent -= 4;
                    newList.Add(new string(' ', indent) + item);
                }
                else
                {
                    newList.Add(new string(' ', indent) + item);
                }
            }

            foreach (var item in newList)
                Console.WriteLine(item);

            Console.ReadLine();
        }
    }
}
