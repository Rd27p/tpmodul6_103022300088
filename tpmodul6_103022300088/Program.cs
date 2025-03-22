using tpmodul6_103022300088;
using System;
class Program
{
    static void Main()
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Gusti Agung Raka Darma Putra Kepakisan");
        video.IncreasePlayCount(100000);
        video.PrintVideoDetails();

        try
        {
            for (int i = 0; i < 1000; i++)
            {
                video.IncreasePlayCount(10000000);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Terjadi kesalahan: {e.Message}");
        }
    }
}