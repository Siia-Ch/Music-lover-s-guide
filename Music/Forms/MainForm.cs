using Music.Models;
using Music.Forms;
using System.Windows.Forms;

namespace Music
{
    public partial class MainForm : Form
    {
        private MusicLibrary musicLibrary;
        private string dataPath = "music_data.json";


        public MainForm()
        {
            InitializeComponent();
            musicLibrary = MusicLibrary.LoadFromFile(dataPath);
        }

        
        private void SaveLibrary()
        {
            musicLibrary.SaveToFile(dataPath);
        }

        private void songsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();

            var results = musicLibrary.Artists
                .SelectMany(a => a.Albums, (a, al) => new { Artist = a, Album = al })
                .SelectMany(x => x.Album.Songs, (x, s) => new SearchResult
                {
                    DisplayText = $"{s.Title} ({x.Artist.Name})",
                    Data = s,
                    Type = "song"
                })
                .OrderBy(r => r.DisplayText)
                .ToList();

            foreach (var r in results)
                listBoxResults.Items.Add(r);
        }
        private void albumsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();

            var results = musicLibrary.Artists
                .SelectMany(a => a.Albums, (a, al) => new SearchResult
                {
                    DisplayText = $"{al.Title} ({a.Name})",
                    Data = al,
                    Type = "album"
                })
                .OrderBy(r => r.DisplayText);

            foreach (var r in results)
                listBoxResults.Items.Add(r);
        }
        private void artistsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();

            var results = musicLibrary.Artists
                .OrderBy(a => a.Name)
                .Select(a => new SearchResult
                {
                    DisplayText = a.Name,
                    Data = a,
                    Type = "artist"
                });

            foreach (var r in results)
                listBoxResults.Items.Add(r);
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            string artistQuery = textBoxArtist.Text.ToLower();
            string songQuery = textBoxSong.Text.ToLower();

            listBoxResults.Items.Clear();

            foreach (var artist in musicLibrary.Artists)
            {
                bool artistMatches = artist.Name.ToLower().Contains(artistQuery);

                foreach (var album in artist.Albums)
                {
                    foreach (var song in album.Songs)
                    {
                        bool songMatches = song.Title.ToLower().Contains(songQuery);

                        if (!string.IsNullOrWhiteSpace(artistQuery) && !string.IsNullOrWhiteSpace(songQuery))
                        {
                            if (artistMatches && songMatches)
                            {
                                listBoxResults.Items.Add(new SearchResult
                                {
                                    DisplayText = $"{artist.Name} - {song.Title} ({album.Title})",
                                    Data = song,
                                    Type = "song"
                                });
                            }
                        }
                        else if (!string.IsNullOrWhiteSpace(artistQuery) && artistMatches)
                        {
                            listBoxResults.Items.Add(new SearchResult
                            {
                                DisplayText = $"{artist.Name} - {song.Title} ({album.Title})",
                                Data = song,
                                Type = "song"
                            });
                        }
                        else if (!string.IsNullOrWhiteSpace(songQuery) && songMatches)
                        {
                            listBoxResults.Items.Add(new SearchResult
                            {
                                DisplayText = $"{artist.Name} - {song.Title} ({album.Title})",
                                Data = song,
                                Type = "song"
                            });
                        }
                    }
                }
            }

            var sortedItems = listBoxResults.Items.Cast<SearchResult>()
                .OrderBy(r => r.DisplayText)
                .ToList();

            listBoxResults.Items.Clear();
            foreach (var item in sortedItems)
                listBoxResults.Items.Add(item);

            if (listBoxResults.Items.Count == 0)
            {
                listBoxResults.Items.Add("Нічого не знайдено.");
            }
        }
        private void listBoxResults_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxResults.SelectedItem is SearchResult selected)
            {
                if (selected.Type == "song" && selected.Data is Song song)
                {
                    var artist = musicLibrary.Artists.FirstOrDefault(a => a.Albums.Any(al => al.Songs.Contains(song)));
                    var album = artist?.Albums.FirstOrDefault(al => al.Songs.Contains(song));
                    var songForm = new SongDetailsForm(song, artist, album, musicLibrary);
                    songForm.ShowDialog();
                }
                else if (selected.Type == "album" && selected.Data is Album album)
                {
                    var artist = musicLibrary.Artists.FirstOrDefault(a => a.Albums.Contains(album));
                    var albumForm = new AlbumDetailsForm(album, artist, musicLibrary);
                    albumForm.ShowDialog();
                }
                else if (selected.Type == "artist" && selected.Data is Artist artist)
                {
                    var artistForm = new ArtistDetailsForm(artist, musicLibrary);
                    artistForm.ShowDialog();
                }
            }
        }

        private void addSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addSongForm = new AddSongForm(musicLibrary);
            if (addSongForm.ShowDialog() == DialogResult.OK)
            {
                SaveLibrary(); // Додамо цей метод трохи нижче
                MessageBox.Show("Пісню додано.");
            }
        }
        private void addArtistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addArtistForm = new AddArtistForm(musicLibrary);
            if (addArtistForm.ShowDialog() == DialogResult.OK)
            {
                SaveLibrary();
                MessageBox.Show("Виконавця додано.");
            }
        }

        private void addAlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addAlbumForm = new AddAlbumForm(musicLibrary);
            if (addAlbumForm.ShowDialog() == DialogResult.OK)
            {
                SaveLibrary();
                MessageBox.Show("Альбом додано.");
            }
        }
    }
}
