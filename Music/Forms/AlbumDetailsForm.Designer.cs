namespace Music.Forms
{
    partial class AlbumDetailsForm
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
            buttonBack = new Button();
            labelAlbumTitle = new Label();
            labelArtistName = new Label();
            listBoxSongs = new ListBox();
            labelSongs = new Label();
            labelYear = new Label();
            buttonEdit = new Button();
            buttonDelete = new Button();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(396, 407);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(103, 31);
            buttonBack.TabIndex = 0;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // labelAlbumTitle
            // 
            labelAlbumTitle.AutoSize = true;
            labelAlbumTitle.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelAlbumTitle.Location = new Point(65, 36);
            labelAlbumTitle.Name = "labelAlbumTitle";
            labelAlbumTitle.Size = new Size(194, 35);
            labelAlbumTitle.TabIndex = 1;
            labelAlbumTitle.Text = "labelAlbumTitle";
            // 
            // labelArtistName
            // 
            labelArtistName.AutoSize = true;
            labelArtistName.Cursor = Cursors.Hand;
            labelArtistName.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            labelArtistName.ForeColor = Color.Navy;
            labelArtistName.Location = new Point(65, 71);
            labelArtistName.Name = "labelArtistName";
            labelArtistName.Size = new Size(129, 23);
            labelArtistName.TabIndex = 2;
            labelArtistName.Text = "labelArtistName";
            labelArtistName.Click += labelArtistName_Click;
            // 
            // listBoxSongs
            // 
            listBoxSongs.FormattingEnabled = true;
            listBoxSongs.Location = new Point(65, 159);
            listBoxSongs.Name = "listBoxSongs";
            listBoxSongs.Size = new Size(326, 244);
            listBoxSongs.TabIndex = 3;
            listBoxSongs.DoubleClick += listBoxSongs_DoubleClick;
            // 
            // labelSongs
            // 
            labelSongs.AutoSize = true;
            labelSongs.Location = new Point(65, 136);
            labelSongs.Name = "labelSongs";
            labelSongs.Size = new Size(82, 20);
            labelSongs.TabIndex = 4;
            labelSongs.Text = "labelSongs";
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Location = new Point(65, 105);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(70, 20);
            labelYear.TabIndex = 5;
            labelYear.Text = "labelYear";
            // 
            // buttonEdit
            // 
            buttonEdit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonEdit.Location = new Point(417, 36);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(38, 38);
            buttonEdit.TabIndex = 6;
            buttonEdit.Text = "✎";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Segoe UI", 12F);
            buttonDelete.Location = new Point(461, 36);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(38, 38);
            buttonDelete.TabIndex = 7;
            buttonDelete.Text = "🗑️";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // AlbumDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 456);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(labelYear);
            Controls.Add(labelSongs);
            Controls.Add(listBoxSongs);
            Controls.Add(labelArtistName);
            Controls.Add(labelAlbumTitle);
            Controls.Add(buttonBack);
            MaximizeBox = false;
            MaximumSize = new Size(547, 503);
            MinimumSize = new Size(547, 503);
            Name = "AlbumDetailsForm";
            Text = "Дані про альбом";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBack;
        private Label labelAlbumTitle;
        private Label labelArtistName;
        private ListBox listBoxSongs;
        private Label labelSongs;
        private Label labelYear;
        private Button buttonEdit;
        private Button buttonDelete;
    }
}