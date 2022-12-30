namespace DataStructureProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filpath = @"D:\OneDrive\Documents\BridgeLabz\DataStructureProgram\DataStructureProgram\WordList.txt";
            Console.WriteLine("Welcome to Data Structure Program");
            List<string> list = new List<string>();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nSelect the operation to perform \n1.UnOrdered List \n2.Display List \n3.Search value \n4.Exit");
                int options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        string file = File.ReadAllText(filpath);
                        string[] fileList = file.Split(",");
                        foreach (var word in fileList)
                        {
                            list.Add(word);
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
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}