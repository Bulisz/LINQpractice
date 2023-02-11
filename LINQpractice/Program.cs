
using Microsoft.EntityFrameworkCore;

namespace LINQpractice;

public partial class Program
{
    private readonly static List<Order> orders = Orders();
    private readonly static string[] aranyember = Aranyember();
    private readonly static List<string[]> toldi = Toldi();
    private readonly static int[] ints = Ints();

    public static void Main()
    {
        using var db = new AdventureWorksContext();
    }

    public static void PrintLongestSentence()
    {

    }

    public static void PrintPoemBySection()
    {

    }
}

