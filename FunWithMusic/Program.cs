using System;
namespace FunWithMusic
{  
    class Program
    {
        enum Genre
        {
            Pop,
            Country,
            Classical,
            Jazz,
            RnB
        }
        struct Music
        {
            private string Title;
            private string Artist;
            private string Album; 
            private double Length;
            private Genre? Genre;

            public Music(string title, string artist, string album, double length, Genre genre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                Genre = genre;
            }
            public void setValues(string title, string artist, string album, double length, Genre genre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                Genre = genre;
            }
            public void setTitle(string title)
            {
                Title = title;
            }
            public void setLength(double length)
            {
                Length = length;
            }
            public string Display()
            {
                return "Title: " + Title + "\nArtist: " + Artist + "\nAlbum: " + Album + "\nLength: " + Length + "\nGenre: " + Genre;
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("What is the title of your favorite song?");
            string temptTitle = Console.ReadLine();
            Console.WriteLine("Who is the artist?");
            string temptArtist = Console.ReadLine();
            Console.WriteLine("What is the name of the album?");
            string temptAlbum = Console.ReadLine();
            Console.WriteLine("What is the length of the song?");
            double temptLength = double.Parse(Console.ReadLine());
            Console.WriteLine("What is the genre?");
            Console.WriteLine(" P - Pop\n C - Country\n L - Classical\n J - Jazz\n R - RnB");
            Genre temptGenre = Genre.Pop;
            char g = char.Parse(Console.ReadLine());
            switch (g)
            {
                case'P':
                    temptGenre = Genre.Pop;
                    break;
                case'C':
                    temptGenre = Genre.Country;
                    break;
                case'L':
                    temptGenre = Genre.Classical;
                    break;
                case'J':
                    temptGenre = Genre.Jazz;
                    break;
                case'R':
                    temptGenre = Genre.RnB;
                    break;
            }

            Music music = new (temptTitle, temptArtist, temptAlbum, temptLength, temptGenre);
            Console.WriteLine($"{music.Display()}");
            Console.ReadKey();
            Console.WriteLine();

            //Music musicTwo = new Music(temptTitle, temptArtist, temptAlbum, temptLength, temptGenre);

            Music moreMusic = music;

            moreMusic.setTitle("Delicate");
            moreMusic.setLength(3.28);

            Console.WriteLine("Here's the second song!");
            Console.WriteLine($"{moreMusic.Display()}");
            Console.WriteLine();

            Console.WriteLine("Here's the first song!");
            Console.WriteLine($"{music.Display()}");
            Console.ReadKey();
        }

    }
}