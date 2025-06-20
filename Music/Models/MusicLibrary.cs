using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Music.Models
{
    public class MusicLibrary
    {
        public List<Artist> Artists { get; set; } = new List<Artist>();

        public MusicLibrary()
        {

        }

        private void InitializeTestData()
        {
            Artist artist1 = new Artist
            {
                Name = "Imagine Dragons",
                Genre = "Alternative Rock",
                Country = "USA"
            };

            Album album1 = new Album
            {
                Title = "Evolve",
                Year = 2017
            };

            album1.Songs.Add(new Song { Title = "Believer", Duration = new System.TimeSpan(0, 3, 24) });
            album1.Songs.Add(new Song { Title = "Thunder", Duration = new System.TimeSpan(0, 3, 7) });
            album1.Songs.Add(new Song { Title = "I Don’t Know Why"	, Duration = new System.TimeSpan(0, 3, 10) });
            album1.Songs.Add(new Song { Title = "Whatever It Takes", Duration = new System.TimeSpan(0, 3, 21) });
            album1.Songs.Add(new Song { Title = "Walking the Wire", Duration = new System.TimeSpan(0, 3, 52) });
            album1.Songs.Add(new Song { Title = "Rise Up", Duration = new System.TimeSpan(0, 3, 51) });
            album1.Songs.Add(new Song { Title = "I’ll Make It Up to You", Duration = new System.TimeSpan(0, 4, 22) });
            album1.Songs.Add(new Song { Title = "Yesterday", Duration = new System.TimeSpan(0, 3, 25) });
            album1.Songs.Add(new Song { Title = "Mouth of the River", Duration = new System.TimeSpan(0, 3, 41) });
            album1.Songs.Add(new Song { Title = "Start Over", Duration = new System.TimeSpan(0, 3, 6) });
            album1.Songs.Add(new Song { Title = "Dancing in the Dark", Duration = new System.TimeSpan(0, 3, 53) });

            artist1.Albums.Add(album1);

            Artists.Add(artist1);


            Artist artist2 = new Artist
            {
                Name = "Adele",
                Genre = "Pop",
                Country = "UK"
            };

            Album album2 = new Album
            {
                Title = "25",
                Year = 2015
            };

            album2.Songs.Add(new Song { Title = "Hello", Duration = new System.TimeSpan(0, 4, 55) });
            album2.Songs.Add(new Song { Title = "Send My Love", Duration = new System.TimeSpan(0, 3, 43) });


            artist2.Albums.Add(album2);

            
            Artists.Add(artist2);

            Artist artist3 = new Artist
            {
                Name = "Misfits",
                Genre = "Punk-rock",
                Country = "USA"
            };

            Album album3 = new Album
            {
                Title = "The Devil's Rain",
                Year = 2011
            };

            album3.Songs.Add(new Song { Title = "The Devil's Rain", Duration = new TimeSpan(0, 3, 22) });
            album3.Songs.Add(new Song { Title = "Vivid Red", Duration = new TimeSpan(0, 1, 55) });
            album3.Songs.Add(new Song { Title = "Land of the Dead", Duration = new TimeSpan(0, 2, 13) });
            album3.Songs.Add(new Song { Title = "The Black Hole", Duration = new TimeSpan(0, 1, 50) });
            album3.Songs.Add(new Song { Title = "Twilight of the Dead", Duration = new TimeSpan(0, 2, 33) });
            album3.Songs.Add(new Song { Title = "Curse of the Mummy's Hand", Duration = new TimeSpan(0, 3, 49) });
            album3.Songs.Add(new Song { Title = "Cold in Hell", Duration = new TimeSpan(0, 2, 50) });
            album3.Songs.Add(new Song { Title = "Unexplained", Duration = new TimeSpan(0, 3, 3) });
            album3.Songs.Add(new Song { Title = "Dark Shadows", Duration = new TimeSpan(0, 3, 40) });
            album3.Songs.Add(new Song { Title = "Father", Duration = new TimeSpan(0, 3, 39) });
            album3.Songs.Add(new Song { Title = "Jack the Ripper", Duration = new TimeSpan(0, 3, 49) });
            album3.Songs.Add(new Song { Title = "Monkey's Paw", Duration = new TimeSpan(0, 2, 47) });
            album3.Songs.Add(new Song { Title = "Where Do They Go?", Duration = new TimeSpan(0, 2, 39) });
            album3.Songs.Add(new Song { Title = "Sleepwalkin'", Duration = new TimeSpan(0, 4, 13) });
            album3.Songs.Add(new Song { Title = "Ghost of Frankenstein", Duration = new TimeSpan(0, 2, 55) });
            album3.Songs.Add(new Song { Title = "Death Ray", Duration = new TimeSpan(0, 4, 58) });

            artist3.Albums.Add(album3);

            Album album4 = new Album
            {
                Title = "Collection I",
                Year = 1986
            };

            album4.Songs.Add(new Song { Title = "London Dungeon", Duration = new TimeSpan(0, 2, 44) });
            album4.Songs.Add(new Song { Title = "Hollywood Babylon", Duration = new TimeSpan(0, 2, 20) });
            album4.Songs.Add(new Song { Title = "Horror Business", Duration = new TimeSpan(0, 2, 45) });

            artist3.Albums.Add(album4);

            Artists.Add(artist3);

            Artist artist4 = new Artist
            {
                Name = "The Beatles",
                Genre = "Rock",
                Country = "UK"
            };

            Album album5 = new Album
            {
                Title = "Help!",
                Year = 1965
            };

            album5.Songs.Add(new Song { Title = "Help!", Duration = new TimeSpan(0, 2, 18) });
            album5.Songs.Add(new Song { Title = "The Night Before", Duration = new TimeSpan(0, 2, 33) });
            album5.Songs.Add(new Song { Title = "You've Got to Hide Your Love Away", Duration = new TimeSpan(0, 2, 9) });
            album5.Songs.Add(new Song { Title = "Ticket to Ride", Duration = new TimeSpan(0, 3, 10) });
            album5.Songs.Add(new Song { Title = "Yesterday", Duration = new TimeSpan(0, 2, 5) });

            artist4.Albums.Add(album5);

            Artists.Add(artist4);


        }
        public void SaveToFile(string path)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            File.WriteAllText(path, JsonSerializer.Serialize(this, options));
        }

        public static MusicLibrary LoadFromFile(string path)
        {
            try
            {
                if (!File.Exists(path))
                {
                    var library = new MusicLibrary();
                    library.InitializeTestData();
                    return library;
                }

                string json = File.ReadAllText(path);
                var libraryFromFile = JsonSerializer.Deserialize<MusicLibrary>(json);

                return libraryFromFile ?? new MusicLibrary();
            }
            catch
            {
                var fallbackLibrary = new MusicLibrary();
                fallbackLibrary.InitializeTestData();
                return fallbackLibrary;
            }
        }
    }
}
