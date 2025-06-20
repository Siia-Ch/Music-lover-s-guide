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
    public partial class AddSongForm : Form
    {
        private MusicLibrary library;
        public AddSongForm(MusicLibrary musicLibrary)
        {
            InitializeComponent();
            library = musicLibrary;


            comboBoxArtist.DataSource = null;
            comboBoxArtist.DataSource = library.Artists.OrderBy(a => a.Name).ToList();
            comboBoxArtist.DisplayMember = "Name";

            this.comboBoxArtist.SelectedIndexChanged += new System.EventHandler(this.comboBoxArtist_SelectedIndexChanged);

        }

        private void comboBoxArtist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxArtist.SelectedItem is Artist selectedArtist)
            {
                comboBoxAlbum.DataSource = null;
                comboBoxAlbum.DataSource = selectedArtist.Albums.OrderBy(a => a.Title).ToList();
                comboBoxAlbum.DisplayMember = "Title";

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxAlbum.SelectedItem is Album selectedAlbum)
            {
                var title = textBoxTitle.Text.Trim();
                if (!TimeSpan.TryParse(textBoxDuration.Text.Trim(), out TimeSpan duration))
                {
                    MessageBox.Show("Неправильний формат тривалості. Використовуйте HH:MM:SS");
                    return;
                }

                selectedAlbum.Songs.Add(new Song
                {
                    Title = title,
                    Duration = duration
                });

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Виконавець немає ільбомів. Додайте потрібний альбом і спробуйте ще раз");
                return;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
