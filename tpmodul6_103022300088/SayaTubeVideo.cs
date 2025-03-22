using System;
using System.Diagnostics;

namespace tpmodul6_103022300088
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Debug.Assert(!string.IsNullOrEmpty(title) && title.Length <= 100, "Judul video tidak boleh null atau lebih dari 100 karakter.");

            this.title = title;
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count > 0 && count <= 10000000, "Penambahan play count harus di antara 1 dan 10.000.000.");
            try
            {
                checked
                {
                    this.playCount += count;
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID: {this.id}");
            Console.WriteLine($"Title: {this.title}");
            Console.WriteLine($"Play Count: {this.playCount}");
        }
    }
}