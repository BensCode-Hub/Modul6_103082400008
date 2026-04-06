using System;
using System.Collections.Generic;
using System.Text;

public class sayaTubeVideo
{
    private int id;
    private string judul;
    private int playCount;

    public sayaTubeVideo(string judul)
    {
        this.judul = judul;
        Random rnd = new Random();
        this.id = rnd.Next(10000, 99999);
        this.playCount = 0;

    }
    public void IncreasePlayCount(int count)
    {
        this.playCount += count;

    }
    public void PrintVideoDetails()
    {
        Console.WriteLine($"Id Video : {this.id}");
        Console.WriteLine($"judul Video : {this.judul}");
        Console.WriteLine($"Play Count : {this.playCount}");
    }
    public int GetPlayCount ()
    {
        return this.playCount;
    }
    public string getJudul()
    {
        return this.judul;
    }

}
