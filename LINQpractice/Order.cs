
using System.Text;

namespace LINQpractice;
public class Order
{
    public int OrderId { get; set; }
    public string CustomerId { get; set; } = string.Empty;
    public int EmployeeId { get; set; }
    public DateOnly OrderDate { get; set; }
    public DateOnly RequiredDate { get; set; }
    public DateOnly? ShippedDate { get; set; }
    public int ShipVia { get; set; }
    public double Freight { get; set; }
    public string ShipName { get; set; } = string.Empty;
    public string ShipAddress { get; set; } = string.Empty;
    public string ShipCity { get; set; } = string.Empty;
    public string? ShipRegion { get; set; }
    public string ShipPostalCode { get; set; } = string.Empty;
    public string ShipCountry { get; set; } = string.Empty;

    public int? OrderExecutionTimeInDays() => ShippedDate is null ? null : ((DateOnly)ShippedDate).DayNumber - OrderDate.DayNumber;

    public static string GetEmployerNameById(int employeeId)
    {
        Dictionary<int, string> employerNames = new()
        {
            {1,"Nancy Davolio"},
            {2,"Andrew Fuller"},
            {3,"Janet Leverling"},
            {4,"Margaret Peacock"},
            {5,"Steven Buchanan"},
            {6,"Michael Suyama"},
            {7,"Robert King"},
            {8,"Laura Callahan"},
            {9,"Anne Dodsworth"},
        };

        return employerNames[employeeId];
    }

    public override string? ToString()
    {
        StringBuilder sb = new();
        sb.AppendLine($"{"OrderId:",-17}{OrderId}");
        sb.AppendLine($"{"CustomerId:",-17}{CustomerId}");
        sb.AppendLine($"{"EmployeeId:",-17}{EmployeeId}");
        sb.AppendLine($"{"OrderDate:",-17}{OrderDate}");
        sb.AppendLine($"{"RequiredDate:",-17}{RequiredDate}");
        sb.AppendLine($"{"ShippedDate:",-17}{ShippedDate}");
        sb.AppendLine($"{"ShipVia:",-17}{ShipVia}");
        sb.AppendLine($"{"Freight:",-17}{Freight:N2}kg");
        sb.AppendLine($"{"ShipName:",-17}{ShipName}");
        sb.AppendLine($"{"ShipAddress:",-17}{ShipAddress}");
        sb.AppendLine($"{"ShipCity:",-17}{ShipCity}");
        sb.AppendLine($"{"ShipRegion:",-17}{ShipRegion}");
        sb.AppendLine($"{"ShipPostalCode:",-17}{ShipPostalCode}");
        sb.AppendLine($"{"ShipCountry:",-17}{ShipCountry}");
        return sb.ToString();
    }
}

