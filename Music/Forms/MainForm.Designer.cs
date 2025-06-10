namespace Music
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label2 = new Label();
            searchButton = new Button();
            textBoxSong = new TextBox();
            label1 = new Label();
            textBoxArtist = new TextBox();
            listBoxResults = new ListBox();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            songToolStripMenuItem = new ToolStripMenuItem();
            artistToolStripMenuItem = new ToolStripMenuItem();
            albumToolStripMenuItem = new ToolStripMenuItem();
            albumsToolStripMenuItem = new ToolStripMenuItem();
            artistsToolStripMenuItem = new ToolStripMenuItem();
            songsToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(searchButton);
            panel1.Controls.Add(textBoxSong);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxArtist);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(111, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(552, 144);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 70);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 4;
            label2.Text = "Song";
            // 
            // searchButton
            // 
            searchButton.Location = new Point(227, 100);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(99, 31);
            searchButton.TabIndex = 3;
            searchButton.Text = "Find";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // textBoxSong
            // 
            textBoxSong.Location = new Point(152, 67);
            textBoxSong.Name = "textBoxSong";
            textBoxSong.Size = new Size(356, 27);
            textBoxSong.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 22);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 1;
            label1.Text = "Artist";
            label1.Click += label1_Click;
            // 
            // textBoxArtist
            // 
            textBoxArtist.Location = new Point(152, 19);
            textBoxArtist.Name = "textBoxArtist";
            textBoxArtist.Size = new Size(358, 27);
            textBoxArtist.TabIndex = 0;
            // 
            // listBoxResults
            // 
            listBoxResults.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxResults.FormattingEnabled = true;
            listBoxResults.Location = new Point(43, 222);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(707, 264);
            listBoxResults.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, albumsToolStripMenuItem, artistsToolStripMenuItem, songsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(791, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Alignment = ToolStripItemAlignment.Right;
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { songToolStripMenuItem, artistToolStripMenuItem, albumToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(33, 24);
            toolStripMenuItem1.Text = "+";
            // 
            // songToolStripMenuItem
            // 
            songToolStripMenuItem.Name = "songToolStripMenuItem";
            songToolStripMenuItem.Size = new Size(136, 26);
            songToolStripMenuItem.Text = "Song";
            songToolStripMenuItem.Click += searchButton_Click;
            // 
            // artistToolStripMenuItem
            // 
            artistToolStripMenuItem.Name = "artistToolStripMenuItem";
            artistToolStripMenuItem.Size = new Size(136, 26);
            artistToolStripMenuItem.Text = "Artist";
            artistToolStripMenuItem.Click += searchButton_Click;
            // 
            // albumToolStripMenuItem
            // 
            albumToolStripMenuItem.Name = "albumToolStripMenuItem";
            albumToolStripMenuItem.Size = new Size(136, 26);
            albumToolStripMenuItem.Text = "Album";
            albumToolStripMenuItem.Click += searchButton_Click;
            // 
            // albumsToolStripMenuItem
            // 
            albumsToolStripMenuItem.Name = "albumsToolStripMenuItem";
            albumsToolStripMenuItem.Size = new Size(73, 24);
            albumsToolStripMenuItem.Text = "Albums";
            albumsToolStripMenuItem.Click += albumsToolStripMenuItem_Click;
            // 
            // artistsToolStripMenuItem
            // 
            artistsToolStripMenuItem.Name = "artistsToolStripMenuItem";
            artistsToolStripMenuItem.Size = new Size(64, 24);
            artistsToolStripMenuItem.Text = "Artists";
            artistsToolStripMenuItem.Click += artistsToolStripMenuItem_Click;
            // 
            // songsToolStripMenuItem
            // 
            songsToolStripMenuItem.Name = "songsToolStripMenuItem";
            songsToolStripMenuItem.Size = new Size(63, 24);
            songsToolStripMenuItem.Text = "Songs";
            songsToolStripMenuItem.Click += songsToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 498);
            Controls.Add(listBoxResults);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ControlLightLight;
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(809, 545);
            Name = "MainForm";
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBoxArtist;
        private Label label2;
        private Button searchButton;
        private TextBox textBoxSong;
        private ListBox listBoxResults;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem songToolStripMenuItem;
        private ToolStripMenuItem artistToolStripMenuItem;
        private ToolStripMenuItem albumToolStripMenuItem;
        private ToolStripMenuItem albumsToolStripMenuItem;
        private ToolStripMenuItem artistsToolStripMenuItem;
        private ToolStripMenuItem songsToolStripMenuItem;
    }
}
