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

            artist1.Albums.Add(album1);

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

            Artists.Add(artist1);
            Artists.Add(artist2);
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
