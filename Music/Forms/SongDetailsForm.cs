using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Music.Models;

namespace Music.Forms
{
    public partial class SongDetailsForm : Form
    {
        private Song song;
        private Artist artist;
        private Album album;
        private List<Artist> allArtists;
        private List<Album> allAlbums;
        private MusicLibrary musicLibrary;

        public SongDetailsForm(Song song, Artist artist, Album album, MusicLibrary musicLibrary)
        {
            InitializeComponent();

            this.song = song;
            this.artist = artist;
            this.album = album;
            this.allArtists = musicLibrary.Artists;
            this.musicLibrary = musicLibrary;

            labelSongTitle.Text = song.Title;
            labelArtist.Text = $"Виконавець: {artist.Name}";
            labelDuration.Text = $"{song.Duration:mm\\:ss}";
            labelAlbums.Text = $"Альбом: {album.Title}";


            buttonDelete.Click += buttonDelete_Click;
            buttonEdit.Click += buttonEdit_Click;
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                $"Ви впевнені, що хочете видалити пісню \"{song.Title}\"?",
                "Підтвердження видалення",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                foreach (var album in artist.Albums)
                {
                    if (album.Songs.Contains(song))
                    {
                        album.Songs.Remove(song);
                        break;
                    }
                }

                MessageBox.Show("Пісню видалено.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var form = new EditSongForm(song, artist, album, musicLibrary);
            if (form.ShowDialog() == DialogResult.OK)
            {
                musicLibrary.SaveToFile("music_data.json");

                // Оновити пов'язані сутності (можливо змінився артист або альбом)
                artist = musicLibrary.Artists.FirstOrDefault(a => a.Albums.Any(al => al.Songs.Contains(song)));
                album = artist?.Albums.FirstOrDefault(al => al.Songs.Contains(song));

                // Оновити відображення
                labelSongTitle.Text = song.Title;
                labelDuration.Text = $"{song.Duration:mm\\:ss}";
                labelArtist.Text = $"Виконавець: {artist?.Name ?? "Невідомо"}";
                labelAlbums.Text = $"Альбом: {album?.Title ?? "Невідомо"}";
            }

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelArtist_Click(object sender, EventArgs e)
        {
            var artistForm = new ArtistDetailsForm(artist, musicLibrary);
            artistForm.ShowDialog();
        }

        private void labelAlbums_Click(object sender, EventArgs e)
        {
            var albumForm = new AlbumDetailsForm(album, artist, musicLibrary);
            albumForm.ShowDialog();
        }

        private void SongDetailsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
