using System.Collections.Generic;
namespace DataStructureProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filpath = @"D:\OneDrive\Documents\BridgeLabz\DataStructureProgram\DataStructureProgram\WordList.txt";
            string filepath = @"D:\OneDrive\Documents\BridgeLabz\DataStructureProgram\DataStructureProgram\ParanthesisList.txt";
            Console.WriteLine("Welcome to Data Structure Program");
            List<string> list = new List<string>();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nSelect the operation to perform \n1.UnOrdered List \n2.Display List \n3.Search value " +
                    "\n4.Ordered List \n5.Balanced Parantheses \n6.Exit");
                int options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        string file = File.ReadAllText(filpath);
                        string[] fileList = file.Split(",");
                        foreach (var data in fileList)
                        {
                            list.Add(data);
                        }
                        break;
                    case 2:
                        list.DisplayList();
                        break;
                    case 3:
                        Console.WriteLine("Enter value u want to search");
                        string value = Console.ReadLine();
                        list.Search(value);
                        break;
                    case 4:
                        string listFile = File.ReadAllText(filpath);
                        string[] FileList = listFile.Split(",");
                        foreach (var word in FileList)
                        {
                            list.Add(word);
                        }
                        list.SortList();
                        Console.WriteLine("\nAfter Sorting list :");
                        list.DisplayList();
                        break;
                    case 5:
                        BalancedParantheses balancedParantheses = new BalancedParantheses();
                        balancedParantheses.ReadTextFile(filepath);
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}