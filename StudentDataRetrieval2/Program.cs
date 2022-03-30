// See https://aka.ms/new-console-template for more information
using System.IO;
using System.Collections;



string directory = (@"C:\ProjStudentData\");

if (!Directory.Exists(directory))
{
    DirectoryInfo dirInf = Directory.CreateDirectory(directory);
}

Console.WriteLine("Student Directory will be read\n");
Console.WriteLine($"Directory Location: {directory}\n");

string[] filePaths = Directory.GetFiles(directory, "*.txt");


foreach (string filePath in filePaths)
{
    string text = File.ReadAllText(filePath);
    Console.WriteLine($"Filename: {filePath}\n");
    Console.WriteLine($"{text}\n");
}

