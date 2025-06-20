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
    public partial class ArtistDetailsForm : Form
    {
        private Artist artist;
        private MusicLibrary musicLibrary;
        private List<Album> sortedAlbums;

        public ArtistDetailsForm(Artist artist, MusicLibrary musicLibrary)
        {
            InitializeComponent();

            this.artist = artist;
            this.musicLibrary = musicLibrary;

            labelName.Text = artist.Name;
            labelSongs.Text = "Пісні:";
            labelGenre.Text = $"Жанр: {artist.Genre}";
            labelCountry.Text = $"Країна: {artist.Country}";

            sortedAlbums = artist.Albums.OrderBy(a => a.Title).ToList();

            comboBoxAlbums.Items.Clear();
            comboBoxAlbums.Items.AddRange(sortedAlbums.Select(a => $"{a.Title} ({a.Year})").ToArray());
            if (comboBoxAlbums.Items.Count > 0)
            {
                comboBoxAlbums.SelectedIndex = 0;
                UpdateSongsList();
            }

            

            comboBoxAlbums.SelectedIndexChanged += ComboBoxAlbums_SelectedIndexChanged;
            listBoxSongs.DoubleClick += ListBoxSongs_DoubleClick;
            buttonAlbumInfo.Click += ButtonAlbumInfo_Click;
        }

        private void ComboBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSongsList();
        }
        private void UpdateSongsList()
        {
            listBoxSongs.Items.Clear();

            int index = comboBoxAlbums.SelectedIndex;
            if (sortedAlbums == null || index < 0 || index >= sortedAlbums.Count)
                return;

            var selectedAlbum = sortedAlbums[index];
            var sortedSongs = selectedAlbum.Songs.OrderBy(s => s.Title).ToList();

            foreach (var song in sortedSongs)
            {
                listBoxSongs.Items.Add(song.Title);
            }
        }

        private void ListBoxSongs_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxSongs.SelectedItem is string songTitle)
            {
                int albumIndex = comboBoxAlbums.SelectedIndex;
                if (albumIndex < 0 || albumIndex >= sortedAlbums.Count)
                    return;

                var selectedAlbum = sortedAlbums[albumIndex];
                var selectedSong = selectedAlbum.Songs.FirstOrDefault(s => s.Title == songTitle);
                if (selectedSong != null)
                {
                    var songForm = new SongDetailsForm(selectedSong, artist, selectedAlbum, musicLibrary);
                    songForm.ShowDialog();
                }
            }
        }

        private void ButtonAlbumInfo_Click(object sender, EventArgs e)
        {
            int albumIndex = comboBoxAlbums.SelectedIndex;
            if (albumIndex < 0 || albumIndex >= sortedAlbums.Count)
                return;

            var selectedAlbum = sortedAlbums[albumIndex];
            var albumForm = new AlbumDetailsForm(selectedAlbum, artist, musicLibrary);
            albumForm.ShowDialog();
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var form = new EditArtistForm(artist);
            if (form.ShowDialog() == DialogResult.OK)
            {
                labelName.Text = artist.Name;
                labelGenre.Text = $"Жанр: {artist.Genre}";
                labelCountry.Text = $"Країна: {artist.Country}";
                musicLibrary.SaveToFile("music_data.json");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                $"Ви впевнені, що хочете видалити виконавця \"{artist.Name}\" разом з усіма альбомами та піснями? Ця дія незворотня.",
                "Підтвердження видалення",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                if (musicLibrary.Artists.Contains(artist))
                {
                    musicLibrary.Artists.Remove(artist);
                    musicLibrary.SaveToFile("music_data.json");

                    MessageBox.Show($"Виконавця \"{artist.Name}\" видалено.");
                    this.DialogResult = DialogResult.OK; // Щоб головна форма могла оновити список, якщо треба
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Виконавець не знайдений у бібліотеці.");
                }
            }

        }
    }
}
