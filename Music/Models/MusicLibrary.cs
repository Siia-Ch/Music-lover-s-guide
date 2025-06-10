using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Models
{
    public class MusicLibrary
    {
        public List<Artist> Artists { get; private set; }

        public MusicLibrary()
        {
            Artists = new List<Artist>();
            InitializeTestData();
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
    }
}
