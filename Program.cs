internal class Program
{
    private static void Main(string[] args)
    {
        HaloGeneric.SapaUser<string>("Dhafa");
        Console.WriteLine();
        DataGeneric<int> DataNIM = new DataGeneric<int>(1302210042);
        Console.WriteLine(DataNIM.PrintData(InputData));
    }
} 

public class HaloGeneric
{
    public static void SapaUser<T>(T InputanUser)
    {
        Console.WriteLine("Halo user " + InputanUser);
    }
}

public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T InputData)
    {
        this.data = InputData;
    }

    public static void PrintData(T InputData)
    {
        Console.WriteLine("Data yang tersimpan adalah: " + InputData);
    }
}