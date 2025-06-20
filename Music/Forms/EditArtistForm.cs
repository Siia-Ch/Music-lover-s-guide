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
    public partial class EditArtistForm : Form
    {
        private Artist artist;
        public EditArtistForm(Artist artist)
        {
            InitializeComponent();

            this.artist = artist;

            textBoxName.Text = artist.Name;
            textBoxCountry.Text = artist.Country;
            textBoxGenre.Text = artist.Genre;

            buttonCancel.Click += (s, e) => this.Close();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Ви впевнені, що хочете зберегти зміни до виконавця?\nЦе змінить його назавжди.",
                "Підтвердження змін",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            artist.Name = textBoxName.Text.Trim();
            artist.Genre = textBoxGenre.Text.Trim();
            artist.Country = textBoxCountry.Text.Trim();

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
