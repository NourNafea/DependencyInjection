namespace DependencyInjection;

public class ApplicationDbContext
{
   public void connect()
    {
        Console.WriteLine("Connect to database");
    }

    public void fetch()
    {
        Console.WriteLine("data is is fetching......");
    }
}