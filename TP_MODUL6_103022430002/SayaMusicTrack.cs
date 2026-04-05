using System;

class SayaMusicTrack
{
    // Properties
    public int id;
    public string title;
    public string playCount;

    // Constructor
    public SayaMusicTrack(string title)
    {
        Random rand = new Random();
        this.id = rand.Next(10000, 99999);  // ID acak 5 digit
        this.title = title;
        this.playCount = "0";  // Default playCount 0
    }

    // Method untuk menambah play count
    public void IncreasePlayCount(int count)
    {
        int currentPlayCount = int.Parse(this.playCount);
        currentPlayCount += count;
        this.playCount = currentPlayCount.ToString();
    }

    // Method untuk mencetak track details
    public void PrintTrackDetails()
    {
        Console.WriteLine("Judul: " + this.title);
        Console.WriteLine("Nomor ID: " + this.id);
        Console.WriteLine("Jumlah Pemutaran: " + this.playCount);
    }
}