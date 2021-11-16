using Coder;

public class Program
{
    public static void Main()
    {
        string str = "Какая-то белиберда.";
        string codeStr = string.Empty;

        ACoder coder = new ACoder();

        //изначальный текст
        Console.WriteLine($"изначальный текст: {str}");
        //кодируем
        codeStr = coder.Encode(str);
        Console.WriteLine($"закодированный текст: {codeStr}");
        //декодируем
        codeStr = coder.Decode(codeStr);
        Console.WriteLine($"раскодированный текст: {codeStr}");
        Console.WriteLine();

        BCoder bCoder = new BCoder();
        codeStr = bCoder.Encode(str);
        Console.WriteLine($"закодированный текст: {codeStr}");
        codeStr = bCoder.Decode(codeStr);
        Console.WriteLine($"раскодированный текст: {codeStr}");

        Console.Read();
    }
}