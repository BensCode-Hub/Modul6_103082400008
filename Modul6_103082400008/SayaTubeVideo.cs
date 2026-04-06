using System;
using System.Diagnostics;

namespace Modul6_103082400008
{
    public class SayaTubeVideo
    {
        private int id;
        public string judul;
        public int playCount;

        public SayaTubeVideo(string judul)
        {
            Debug.Assert(judul != null, "Judul video tidak boleh null.");
            Debug.Assert(judul.Length <= 200, "Judul video maksimal 200 karakter.");

            this.judul = judul;
            Random rnd = new Random();
            this.id = rnd.Next(10000, 99999);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count >= 0, "Input play count tidak boleh negatif.");
            Debug.Assert(count <= 25000000, "Penambahan play count maksimal 25.000.000 per panggilan.");

            try
            {
                checked { this.playCount += count; }
            }
            catch (OverflowException e)
            {
                Console.WriteLine($"\n[EXCEPTION] Overflow terjadi pada video '{this.judul}': {e.Message}");
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID Video    : {this.id}");
            Console.WriteLine($"Judul Video : {this.judul}");
            Console.WriteLine($"Play Count  : {this.playCount}");
        }

        public int GetPlayCount() { return this.playCount; }
        public string GetTitle() { return this.judul; }
    }
}