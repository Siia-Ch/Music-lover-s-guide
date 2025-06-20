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
    public partial class AddArtistForm : Form
    {
        private MusicLibrary library;

        public AddArtistForm(MusicLibrary musicLibrary)
        {
            InitializeComponent();
            library = musicLibrary;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string genre = textBoxGenre.Text.Trim();
            string country = textBoxCountry.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(genre) ||
                string.IsNullOrWhiteSpace(country))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля.");
                return;
            }

            library.Artists.Add(new Artist
            {
                Name = name,
                Genre = genre,
                Country = country
            });

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }
}
