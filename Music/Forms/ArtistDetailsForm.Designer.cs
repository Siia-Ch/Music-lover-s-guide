namespace Music.Forms
{
    partial class ArtistDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelName = new Label();
            listBoxSongs = new ListBox();
            buttonBack = new Button();
            labelSongs = new Label();
            labelGenre = new Label();
            labelCountry = new Label();
            comboBoxAlbums = new ComboBox();
            buttonAlbumInfo = new Button();
            buttonDelete = new Button();
            buttonEdit = new Button();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelName.Location = new Point(34, 24);
            labelName.Name = "labelName";
            labelName.Size = new Size(145, 35);
            labelName.TabIndex = 0;
            labelName.Text = "labelName ";
            // 
            // listBoxSongs
            // 
            listBoxSongs.FormattingEnabled = true;
            listBoxSongs.Location = new Point(34, 185);
            listBoxSongs.Name = "listBoxSongs";
            listBoxSongs.Size = new Size(246, 204);
            listBoxSongs.TabIndex = 2;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(277, 395);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(94, 29);
            buttonBack.TabIndex = 3;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // labelSongs
            // 
            labelSongs.AutoSize = true;
            labelSongs.Location = new Point(34, 162);
            labelSongs.Name = "labelSongs";
            labelSongs.Size = new Size(82, 20);
            labelSongs.TabIndex = 5;
            labelSongs.Text = "labelSongs";
            // 
            // labelGenre
            // 
            labelGenre.AutoSize = true;
            labelGenre.Location = new Point(34, 59);
            labelGenre.Name = "labelGenre";
            labelGenre.Size = new Size(50, 20);
            labelGenre.TabIndex = 6;
            labelGenre.Text = "label1";
            // 
            // labelCountry
            // 
            labelCountry.AutoSize = true;
            labelCountry.Location = new Point(34, 79);
            labelCountry.Name = "labelCountry";
            labelCountry.Size = new Size(50, 20);
            labelCountry.TabIndex = 7;
            labelCountry.Text = "label2";
            // 
            // comboBoxAlbums
            // 
            comboBoxAlbums.FormattingEnabled = true;
            comboBoxAlbums.Location = new Point(34, 115);
            comboBoxAlbums.Name = "comboBoxAlbums";
            comboBoxAlbums.Size = new Size(246, 28);
            comboBoxAlbums.TabIndex = 8;
            // 
            // buttonAlbumInfo
            // 
            buttonAlbumInfo.Location = new Point(298, 115);
            buttonAlbumInfo.Name = "buttonAlbumInfo";
            buttonAlbumInfo.Size = new Size(28, 28);
            buttonAlbumInfo.TabIndex = 9;
            buttonAlbumInfo.Text = "ℹ️";
            buttonAlbumInfo.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Segoe UI", 10F);
            buttonDelete.Location = new Point(354, 24);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(30, 30);
            buttonDelete.TabIndex = 11;
            buttonDelete.Text = "🗑️";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Font = new Font("Segoe UI", 11F);
            buttonEdit.Location = new Point(318, 24);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(30, 30);
            buttonEdit.TabIndex = 12;
            buttonEdit.Text = "✎";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // ArtistDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 455);
            Controls.Add(buttonEdit);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAlbumInfo);
            Controls.Add(comboBoxAlbums);
            Controls.Add(labelCountry);
            Controls.Add(labelGenre);
            Controls.Add(labelSongs);
            Controls.Add(buttonBack);
            Controls.Add(listBoxSongs);
            Controls.Add(labelName);
            MaximizeBox = false;
            MaximumSize = new Size(430, 502);
            MinimumSize = new Size(430, 502);
            Name = "ArtistDetailsForm";
            Text = "Дані про виконавця";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private ListBox listBoxSongs;
        private Button buttonBack;
        private Label labelSongs;
        private Label labelGenre;
        private Label labelCountry;
        private ComboBox comboBoxAlbums;
        private Button buttonAlbumInfo;
        private Button buttonDelete;
        private Button buttonEdit;
    }
}