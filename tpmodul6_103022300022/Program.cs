using System;
using tpmodul6_103022300022;

class Program
{
    static void Main()
    {
        try
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – [Nadya]");
            video.PrintVideoDetails();

            video.IncreasePlayCount(5000);
            video.PrintVideoDetails();

            for (int i = 0; i < 10; i++)
            {
                video.IncreasePlayCount(10000000);
            }

            video.PrintVideoDetails();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception: {e.Message}");
        }
    }
}