internal class Program
{
    private static void Main(string[] args)
    {
        HaloGeneric.SapaUser<string>("Dhafa");
    }
}

public class HaloGeneric
{
    public static void SapaUser<T>(T InputanUser)
    {
        Console.WriteLine("Halo user " + InputanUser);
    }
}