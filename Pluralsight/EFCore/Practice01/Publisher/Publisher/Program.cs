using PublisherData;


public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Main is called");
        using (PubContext context = new PubContext())
        {
            context.Database.EnsureCreated();
        }

        GetAuthors();

    }

    static void GetAuthors()
    {
        Console.WriteLine("Getting Authrors");
        using var context = new PubContext();
        var authors = context.Authors.ToList();

        foreach (var auth in authors)
        {
            Console.WriteLine(auth.Name);
        }
    }
}

