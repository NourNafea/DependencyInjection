namespace DependencyInjection;

public class user
{
    ApplicationDbContext Db;
    public user(ApplicationDbContext _db)
    {
        Db = _db;
    }
    public void show()
    {
        Console.WriteLine("users data");
        Db.connect();
        Db.fetch();
    }
}