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
    public partial class AddAlbumForm : Form
    {
        private MusicLibrary library;

        public AddAlbumForm(MusicLibrary musicLibrary)
        {
            InitializeComponent();
            library = musicLibrary;

            comboBoxArtist.DataSource = null;
            comboBoxArtist.DataSource = library.Artists.OrderBy(a => a.Name).ToList();
            comboBoxArtist.DisplayMember = "Name";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text.Trim();

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Введіть назву альбому.");
                return;
            }

            int year = (int)numericUpDownYear.Value;
            if (year < 1900 || year > DateTime.Now.Year)
            {
                MessageBox.Show("Введіть коректний рік.");
                return;
            }

            if (comboBoxArtist.SelectedItem is Artist selectedArtist)
            {
                var newAlbum = new Album
                {
                    Title = title,
                    Year = year
                };

                selectedArtist.Albums.Add(newAlbum);

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Оберіть виконавця.");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
