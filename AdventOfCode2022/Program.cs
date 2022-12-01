using System.IO;

void DayOne(string path)
{
    List<int> result = new List<int>();
    int elf = 0;
    int sum = 0;

    using (var reader = new StreamReader(path))
    {
        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine();
            if (line == "")
            {
                result.Add(sum);
                //Console.WriteLine("Elf " + elf + " added.");
                //Console.WriteLine("Total: " + result[elf]);
                elf++;
                sum = 0;
            }
            else
            {
                //Console.WriteLine(line.ToString());
                sum += Int32.Parse(line);
            }
        }
        result.Add(sum);
        //Console.WriteLine("Elf " + elf + " added.");
        //Console.WriteLine("Total: " + result[elf]);
        elf++;
        sum = 0;
    }
    result.Sort();
    result.Reverse();
    Console.WriteLine("Highest number is " + result[0].ToString());

    for (int i = 0; i <= 2; i++)
    {
        sum += result[i];
    }
    Console.WriteLine("Top 3 Sum is " + sum.ToString());
}
void DayTwo()
{

}