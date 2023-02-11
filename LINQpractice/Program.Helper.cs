
using System.Text;

namespace LINQpractice;

public partial class Program
{
    public static void PrintTitle(string title)
    {
        ConsoleColor previousColor = ForegroundColor;
        ForegroundColor = ConsoleColor.Yellow;
        WriteLine(new string('*', title.Length + 4));
        WriteLine($"* {title} *");
        WriteLine(new string('*', title.Length + 4));
        ForegroundColor = previousColor;
    }

    public static string FilesFolder()
    {
        DirectoryInfo currentDirectory = new(Directory.GetCurrentDirectory()); // [solution folder]\LINQpractice\bin\Debug\net7.0
        DirectoryInfo? solutionFolder = currentDirectory.Parent!.Parent!.Parent; // [solution folder]
        string filesFolder = Path.Combine(solutionFolder!.FullName, "Files"); // Files folder
        return filesFolder;
    }

    public static string[] Aranyember()
    {
        try
        {
            return File.ReadAllLines(Path.Combine(FilesFolder(), "Aranyember.txt"));
        }
        catch (Exception)
        {
            throw;
        }
    }

    public static List<string[]> Toldi()
    {
        using StreamReader sr = new(Path.Combine(FilesFolder(), "Toldi.txt"), Encoding.UTF7);

        List<string[]> result = new();
        string? line = string.Empty;
        int rowNumber = 0;

        while ((line = sr.ReadLine()) is not null)
        {
            line = line.Trim();
            if (int.TryParse(line, out int sectionNumber))
            {
                result.Add(new string[8]);
                rowNumber = 0;
            }
            else if(line.Length > 0)
            {
                result[^1][rowNumber++] = line;
            }
        }

        return result;
    }

    public static List<Order> Orders()
    {
        using StreamReader sr = new(Path.Combine(FilesFolder(), "Orders.csv"));

        List<Order> result = new();
        string? line = string.Empty;
        sr.ReadLine();

        while((line = sr.ReadLine()) is not null)
        {
            string[] args = line.Split(';');

            result.Add(new Order
            {
                OrderId = int.Parse(args[0]),
                CustomerId = args[1],
                EmployeeId = int.Parse(args[2]),
                OrderDate = DateOnly.Parse(args[3]),
                RequiredDate = DateOnly.Parse(args[4]),
                ShippedDate = args[5] == "NULL" ? null : DateOnly.Parse(args[5]),
                ShipVia = int.Parse(args[6]),
                Freight = double.Parse(args[7].Replace('.', ',')),
                ShipName = args[8],
                ShipAddress = args[9],
                ShipCity = args[10],
                ShipRegion = args[11] == "NULL" ? null : args[11],
                ShipPostalCode = args[12],
                ShipCountry = args[13],
            });
        }

        return result;
    }

    public static int[] Ints()
    {
        int[] result =  new int[100];

        using StreamReader sr = new(Path.Combine(FilesFolder(), "Ints.txt"));

        string line = sr.ReadLine()!;
        string[] numbers = line.Split(" ");
        for (int i = 0; i < 100; i++)
        {
            result[i] = int.Parse(numbers[i]);
        }

        return result;
    }
}
