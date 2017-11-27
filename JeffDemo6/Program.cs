using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeffDemo6
{
    class Program
    {
        //Start with this example
        //static string Tool;
        //static void GetTool()
        //{
        //    Console.WriteLine("Enter the name of the tool");
        //    Tool = Console.ReadLine();
        //}

        //Demonstrate PrintTool next
        static void PrintTool(int index, string[] tools)
        {
            if (index < tools.Length && index >= 0) //demonstrate bounds of array once more as well as &&
            {
                Console.WriteLine("The name of the tool at position {0} is {1}", index, tools[index]);
            }
            else
            {
                Console.WriteLine("Index {0} is outside the bounds of the array", index);
            }
        }

        //Show this example last to demonstrate return values
        static int GetIndex(string[] tools, string query)
        {
            int index = -1;
            for (int i = 0; i < tools.Length; i++)
            {
                if (tools[i] == query)
                {
                    index = i;
                }
            }
            return index;
        }

        static void Main(string[] args)
        {
            string[] tools = { "Hammer", "Shovel", "Hoe" };
            int index;

            for(int i = 0; i < tools.Length; i++)
            {
                PrintTool(i, tools);
            }

            do
            {
                //Wait to show this until ready to show return values
                Console.WriteLine("Enter the name of an item to view it's index");
                index = GetIndex(tools, Console.ReadLine());
                if (index >= 0)
                {
                    Console.WriteLine("You searched for {0} and the index for your search was {1}", tools[index], index);
                }
                else
                {
                    Console.WriteLine("Could not find your search");
                }

                do //Opportunity to show nested looping and show another use of do...while
                {
                    Console.WriteLine("Enter the index number you would like to view");
                } while (!int.TryParse(Console.ReadLine(), out index));
                PrintTool(index, tools);
            } while (index > 0);

            Console.WriteLine("Enter a tool name");
            PrintTool(GetIndex(tools, Console.ReadLine()), tools);
            Console.ReadLine();
        }
    }
}
