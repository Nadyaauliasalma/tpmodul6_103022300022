using System;
using tpmodul6_103022300022;

class Program
{
    static void Main()
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – [Nadya]");
        video.IncreasePlayCount(10);
        video.PrintVideoDetails();
    }
}
