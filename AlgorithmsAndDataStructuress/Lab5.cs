Queue<string> playlist = new Queue<string>();
Stack<string> history = new Stack<string>();

while (true)
{
    Console.WriteLine("\nChoose an option:");
    Console.WriteLine("1. Add a song to your playlist");
    Console.WriteLine("2. Play the next song in your playlist");
    Console.WriteLine("3. Skip the next song");
    Console.WriteLine("4. Rewind one song");
    Console.WriteLine("5. Exit");

    int option = int.Parse(Console.ReadLine());

    if (option == 1)
    {
        Console.Write("Enter Song Name: ");
        var songName = Console.ReadLine();
        playlist.Enqueue(songName);
        Console.WriteLine($"\"{songName}\" added to your playlist.");
    }
    else if (option == 2)
    {
        if (playlist.Count > 0)
        {
            var songName = playlist.Dequeue();
            history.Push(songName);
            Console.WriteLine($"Now Playing \"{songName}\"");
        }
        else
        {
            Console.WriteLine("No song in the playlist.");
        }
    }
    else if (option == 3)
    {
        if (playlist.Count > 1)
        {
            playlist.Dequeue();
            Console.WriteLine($"Skipped to next song.");
        }
        else
        {
            Console.WriteLine("No song to skip.");
        }
    }
    else if (option == 4)
    {
        if (history.Count > 0)
        {
            playlist.Enqueue(history.Pop());
            Console.WriteLine("Rewinded to previous song.");
        }
        else
        {
            Console.WriteLine("No song in the history to rewind.");
        }
    }
    else if (option == 5)
    {
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("Invalid option. Please try again.");
    }

    if (playlist.Count > 0)
    {
        Console.WriteLine($"Next song - \"{playlist.Peek()}\"");
    }
    else
    {
        Console.WriteLine("No song queued in your playlist.");
    }
}
    }
}