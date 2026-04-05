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
        // Design by Contract: Precondition checks
        if (this.title.Length > 100)
            throw new ArgumentException("Judul track tidak boleh lebih dari 100 karakter.");

        if (this.title == null)
            throw new ArgumentNullException("Judul track tidak boleh null.");

        if (count > 10000000)
            throw new ArgumentException("Penambahan play count melebihi batas maksimum.");

        // Menggunakan 'checked' untuk memastikan tidak ada overflow
        checked
        {
            int currentPlayCount = int.Parse(this.playCount);
            currentPlayCount += count;
            this.playCount = currentPlayCount.ToString();
        }
    }

    // Method untuk mencetak track details
    public void PrintTrackDetails()
    {
        Console.WriteLine("Judul: " + this.title);
        Console.WriteLine("Nomor ID: " + this.id);
        Console.WriteLine("Jumlah Pemutaran: " + this.playCount);
    }
}