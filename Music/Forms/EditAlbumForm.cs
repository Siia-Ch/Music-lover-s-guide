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
    public partial class EditAlbumForm : Form
    {
        private Album album;
        private Artist currentArtist;
        private List<Artist> allArtists;
        public EditAlbumForm(Album albumToEdit, Artist artist, List<Artist> artists)
        {
            InitializeComponent();

            album = albumToEdit;
            currentArtist = artist;
            allArtists = artists;

            textBoxTitle.Text = album.Title;
            numericUpDownYear.Value = album.Year;

            comboBoxArtist.DataSource = null;
            comboBoxArtist.DataSource = allArtists.OrderBy(a => a.Name).ToList();
            comboBoxArtist.DisplayMember = "Name";
            comboBoxArtist.SelectedItem = currentArtist;

            buttonSave.Click += buttonSave_Click;
            buttonCancel.Click += (s, e) => Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Зберегти зміни без можливості відновлення?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;

            album.Title = textBoxTitle.Text.Trim();
            album.Year = (int)numericUpDownYear.Value;

            var selectedArtist = comboBoxArtist.SelectedItem as Artist;
            if (selectedArtist != null && selectedArtist != currentArtist)
            {
                // Видалити альбом у старого виконавця
                currentArtist.Albums.Remove(album);

                // Додати альбом новому виконавцю
                selectedArtist.Albums.Add(album);

                currentArtist = selectedArtist;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
