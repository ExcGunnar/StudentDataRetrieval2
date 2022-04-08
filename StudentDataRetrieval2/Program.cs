// See https://aka.ms/new-console-template for more information
using System.IO;
using System.Collections;



string directory = (@"C:\ProjStudentData\");
int op = 0;

if (!Directory.Exists(directory))
{
    DirectoryInfo dirInf = Directory.CreateDirectory(directory);
}

Console.WriteLine($"Directory Location: {directory}\n");
string[] filePath = Directory.GetFiles(directory, "*.txt");
string[] lines = System.IO.File.ReadAllLines(filePath[0]);

lines = lines.Select(x => x.ToLowerInvariant()).ToArray();


//foreach (string line in lines)
//{
//    line.ToLower();
//}


do
{
    Console.WriteLine("Type '1' for Sorting OR Type '2' for Searching");
    string selection = Console.ReadLine();

    if (selection == "1")
    {
        Console.WriteLine("Sorting by alphabetical order");
        InsertSort(lines);
        printContents(lines);
        op = 1;
    }
    else if (selection == "2")
    {
        bool cont;

        do
        {

            Console.WriteLine("Please search for a valid name:");
            string search = Console.ReadLine();
            search.ToLower();

            var results = Array.FindAll(lines, s => s.Contains(search));
            Console.WriteLine("Result: ");

            if (results.Any())
            {
                foreach (var result in results)
                {
                    Console.WriteLine(result.ToString());
                }
                cont = false;

            }
            else
            {
                Console.WriteLine("No Results Found!");
                
                cont = true;
            }


        } 
        while (cont == true);
        op = 1;

    }
    else
    {
        Console.WriteLine("Please retry and make a valid selection");
        op = 0;
    }
}
while (op == 0);


static void printContents(string [] printableString)
{
    foreach (string item in printableString)
    {
        Console.WriteLine(item);
    }

}

static void InsertSort(IComparable[] array)
{
    int i;
    int j;

    for (i = 1; i < array.Length; i++)
    {
        IComparable value = array[i];

        j = i - 1;

        while ((j >= 0) && (array[j].CompareTo(value) > 0))
        {
            array[j + 1] = array[j];
            j--;
        }
        array[j + 1] = value;
    }
}

static object BinarySearchDisplay(int[] arr, int key)
{
    int minNum = 0;
    int maxNum = arr.Length - 1;

    while (minNum <= maxNum)
    {
        int mid = (minNum + maxNum) / 2;
        if (key == arr[mid])
        {
            return ++mid;
        }
        else if (key < arr[mid])
        {
            int max = mid - 1;
        }
        else
        {
            int min = mid + 1;
        }
    }
    return "None";
}