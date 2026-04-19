namespace Route;

internal class Program
{
    private static void Main(string[] args)
    {
        var table = new Xobex.Net.Routing.RoutingTable();
        table.GetEntires();
    }
}
