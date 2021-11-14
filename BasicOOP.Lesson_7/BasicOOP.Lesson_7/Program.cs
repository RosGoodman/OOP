using Coder;

public class Program
{
    public static void Main(String[] args)
    {
        string str = "Какая-то белиберда.";
        string codeStr = string.Empty;

        ACoder coder = new ACoder();

        //кодируем
        codeStr = coder.Encode(str);
        Console.WriteLine(codeStr);
        //декодируем
        codeStr = coder.Decode(codeStr);
        Console.WriteLine(codeStr);

        Console.Read();
    }
}