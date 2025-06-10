using Music.Models;

namespace Music
{
    public partial class MainForm : Form
    {
        private MusicLibrary musicLibrary;
        public MainForm()
        {
            InitializeComponent();
            musicLibrary = new MusicLibrary();
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

                        if ((string.IsNullOrWhiteSpace(artistQuery) || artistMatches) &&
                            (string.IsNullOrWhiteSpace(songQuery) || songMatches))
                        {
                            string result = $"{artist.Name} - {song.Title} ({album.Title})";
                            listBoxResults.Items.Add(result);
                        }
                    }
                }
            }

            if (listBoxResults.Items.Count == 0)
            {
                listBoxResults.Items.Add("Нічого не знайдено.");
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void songsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();
            foreach (var artist in musicLibrary.Artists)
            {
                foreach (var album in artist.Albums)
                {
                    foreach (var song in album.Songs)
                    {
                        listBoxResults.Items.Add($"{artist.Name} - {song.Title} ({album.Title})");
                    }
                }
            }
        }

        private void artistsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();
            foreach (var artist in musicLibrary.Artists)
            {
                listBoxResults.Items.Add(artist.Name);
            }
        }

        private void albumsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();
            foreach (var artist in musicLibrary.Artists)
            {
                foreach (var album in artist.Albums)
                {
                    listBoxResults.Items.Add($"{album.Title} ({artist.Name})");
                }
            }
        }


        private void addSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Форма додавання пісні буде тут.");
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
