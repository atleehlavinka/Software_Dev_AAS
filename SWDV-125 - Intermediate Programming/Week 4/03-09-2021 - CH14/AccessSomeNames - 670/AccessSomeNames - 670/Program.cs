using System;
using static System.Console;
using System.IO;
class AccessSomesNames
{
    static void Main()
    {
        FileStream file = new FileStream(@"\\Remote-School\G\School\SWDV-125\Week 4\03-09-2021 - CH14\CreateNameFile\CreateNameFile\bin\Debug\netcoreapp3.1\Names.txt", FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(file);

        const int END = 999;
        int count = 0;
        int num;
        int size;
        string name;

        name = reader.ReadLine();
        while(name != null)
        {
            ++count;
            name = reader.ReadLine();
        }
        size = (int)file.Length / count;

        Write("\nWith which number do you want to start? >> ");
        num = Convert.ToInt32(ReadLine());

        while(num != END)
        {
            WriteLine("Starting with name " + num + ": ");
            file.Seek((num - 1) * size, SeekOrigin.Begin);

            name = reader.ReadLine();
            WriteLine(" " + name);
            while(name != null)
            {
                name = reader.ReadLine();
                WriteLine(" " + name);
            }

            WriteLine("\nWith which number do you " + "want to start?");
            Write("    (Enter " + END + " to quit) >> ");
            num = Convert.ToInt32(ReadLine());
        }
        reader.Close();
        file.Close();
    }
}