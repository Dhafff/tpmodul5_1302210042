internal class Program
{
    private static void Main(string[] args)
    {
        HaloGeneric.SapaUser<string>("Dhafa");
        Console.WriteLine();
        DataGeneric<int> DataNIM = new DataGeneric<int>(1302210042);
        DataNIM.PrintData();
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
    public T data;

    public DataGeneric(T InputData)
    {
        this.data = InputData;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }
}