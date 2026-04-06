using System;

namespace Modul6_103082400008
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kutipnya udah gua tambahin nih!
            Console.WriteLine("=== UJI NORMAL & POSTCONDITION ===");
            SayaTubeUser user = new SayaTubeUser("Ruben");

            for (int i = 1; i <= 10; i++)
            {
                SayaTubeVideo video = new SayaTubeVideo($"Review Film Keren ke-{i} oleh Ruben");
                video.IncreasePlayCount(100);
                user.AddVideo(video);
            }

            user.PrintAllVideoPlayCount();

            // Kutipnya udah gua tambahin juga!
            Console.WriteLine("\n=== PENGUJIAN EXCEPTION (OVERFLOW) ===");
            SayaTubeVideo videoError = new SayaTubeVideo("Review Film Error oleh Ruben");

            for (int i = 0; i < 90; i++)
            {
                videoError.IncreasePlayCount(25000000);
            }

            Console.WriteLine($"\nPlayCount video error berhenti di: {videoError.GetPlayCount()}");
            Console.ReadLine();
        }
    }
}