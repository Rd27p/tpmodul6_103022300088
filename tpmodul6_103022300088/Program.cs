using System;

namespace tpmodul6_103022300088;
class Program
{
    static void Main()
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Gusti Agung Raka Darma Putra Kepakisan");
        video.IncreasePlayCount(1000);
        video.PrintVideoDetails();
    }
}