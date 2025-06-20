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
    public partial class AlbumDetailsForm : Form
    {
        private Artist artist;
        private Album album;
        private MusicLibrary musicLibrary;
        public AlbumDetailsForm(Album album, Artist artist, MusicLibrary musicLibrary)
        {
            InitializeComponent();

            this.artist = artist;
            this.album = album;
            this.musicLibrary = musicLibrary;

            labelAlbumTitle.Text = album.Title;
            labelArtistName.Text = $"Виконавець: {artist.Name}";
            labelSongs.Text = "Пісні:";
            labelYear.Text = $"Рік випуску: {album.Year}";

            listBoxSongs.Items.Clear();
            var sortedSongs = album.Songs.OrderBy(s => s.Title).ToList();

            foreach (var song in sortedSongs)
            {
                listBoxSongs.Items.Add(song.Title);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelArtistName_Click(object sender, EventArgs e)
        {
            var artistForm = new ArtistDetailsForm(artist, musicLibrary);
            artistForm.ShowDialog();
        }
        private void listBoxSongs_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxSongs.SelectedItem is string songTitle)
            {
                var selectedSong = album.Songs.FirstOrDefault(s => s.Title == songTitle);
                if (selectedSong != null)
                {
                    var songForm = new SongDetailsForm(selectedSong, artist, album, musicLibrary);
                    songForm.ShowDialog();
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var editForm = new EditAlbumForm(album, artist, musicLibrary.Artists);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                labelAlbumTitle.Text = album.Title;
                labelArtistName.Text = $"Виконавець: {artist.Name}";
                musicLibrary.SaveToFile("music_data.json");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                $"Ви впевнені, що хочете видалити альбом \"{album.Title}\"?",
                "Підтвердження видалення",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (artist.Albums.Contains(album))
                {
                    artist.Albums.Remove(album);
                }

                MessageBox.Show("Альбом видалено.");
                musicLibrary.SaveToFile("music_data.json"); // якщо вже є така функція
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
