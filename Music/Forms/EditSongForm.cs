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
    public partial class EditSongForm : Form
    {
        private Song song;
        private Artist currentArtist;
        private Album currentAlbum;
        private List<Artist> allArtists;
        private List<Album> allAlbums;
        public EditSongForm(Song songToEdit, Artist artist, Album album, MusicLibrary musicLibrary)
        {
            InitializeComponent();

            song = songToEdit;
            allArtists = musicLibrary.Artists;
            currentArtist = artist;
            currentAlbum = album; 

            textBoxTitle.Text = song.Title;
            textBoxDuration.Text = song.Duration.ToString(@"mm\:ss");

            comboBoxArtist.DataSource = null;
            comboBoxArtist.DataSource = allArtists.OrderBy(a => a.Name).ToList();
            comboBoxArtist.DisplayMember = "Name";
            comboBoxArtist.SelectedItem = allArtists.FirstOrDefault(a => a == currentArtist);

            if (comboBoxArtist.SelectedItem is Artist selectedArtist)
            {
                allAlbums = selectedArtist.Albums; 
                comboBoxAlbum.DataSource = null;
                comboBoxAlbum.DataSource = selectedArtist.Albums.OrderBy(a => a.Title).ToList();
                comboBoxAlbum.DisplayMember = "Title";
                comboBoxAlbum.SelectedItem = selectedArtist.Albums.FirstOrDefault(al => al.Songs.Contains(song));
            }

            this.comboBoxArtist.SelectedIndexChanged += new System.EventHandler(this.comboBoxArtist_SelectedIndexChanged);

            buttonSave.Click += buttonSave_Click;
            buttonCancel.Click += (s, e) => this.Close();
        }
        private void comboBoxArtist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxArtist.SelectedItem is Artist selectedArtist)
            {
                comboBoxAlbum.DataSource = null;
                comboBoxAlbum.DataSource = selectedArtist.Albums.OrderBy(a => a.Title).ToList();
                comboBoxAlbum.DisplayMember = "Title";
                comboBoxAlbum.SelectedItem = selectedArtist.Albums.FirstOrDefault(al => al.Songs.Contains(song));
                allAlbums = selectedArtist.Albums;
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Зміни будуть збережені без можливості відновлення. Продовжити?",
                                         "Підтвердження змін",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;

            // Назва
            song.Title = textBoxTitle.Text.Trim();

            // Тривалість
            if (TimeSpan.TryParseExact(textBoxDuration.Text.Trim(), @"mm\:ss", null, out var duration))
                song.Duration = duration;
            else
            {
                MessageBox.Show("Неправильний формат тривалості. Використовуйте мм:сс", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedArtist = comboBoxArtist.SelectedItem as Artist;
            if (selectedArtist != null && currentArtist != selectedArtist)
            {
                // Видаляємо пісню з поточного альбому поточного виконавця
                var albumWithSong = currentArtist.Albums.FirstOrDefault(a => a.Songs.Contains(song));
                if (albumWithSong != null)
                    albumWithSong.Songs.Remove(song);

                // Оновлюємо виконавця
                currentArtist = selectedArtist;
            }

            // Альбом
            var selectedAlbum = comboBoxAlbum.SelectedItem as Album;
            if (selectedAlbum == null)
            {
                MessageBox.Show("Будь ласка, оберіть альбом для цієї пісні.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Видалити з усіх альбомів (навіть якщо змінився виконавець)
            foreach (var album in allAlbums)
                album.Songs.Remove(song);

            // Додати до нового альбому
            selectedAlbum.Songs.Add(song);

            MessageBox.Show("Зміни збережено.");
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
