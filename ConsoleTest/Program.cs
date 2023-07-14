using SHA256_Checksum;

if (args.Length < 2)
{
    Console.WriteLine("Not enough arguments");
    Console.WriteLine("\nCorrect usage\n----------------\ncheckmatch.exe FILE_A_PATH FILE_B_PATH");
    return;
}
else
{
    CheckFile a = new CheckFile(args[0]);
    CheckFile b = new CheckFile(args[1]);


    if (a.Checksum == b.Checksum)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("File hashes match");
        Console.WriteLine($"File hash: {a.Checksum}");
        Console.ForegroundColor = ConsoleColor.White;

    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("File hashes do not match");
        Console.WriteLine($"File A Hash: {a.Checksum}");
        Console.WriteLine($"File B Hash: {b.Checksum}");
        Console.ForegroundColor = ConsoleColor.White;
    }

}