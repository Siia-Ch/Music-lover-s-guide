namespace Music.Forms
{
    partial class SongDetailsForm
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
            labelSongTitle = new Label();
            labelDuration = new Label();
            labelAlbums = new Label();
            labelArtist = new Label();
            buttonDelete = new Button();
            buttonEdit = new Button();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(370, 155);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(95, 33);
            buttonBack.TabIndex = 0;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // labelSongTitle
            // 
            labelSongTitle.AutoSize = true;
            labelSongTitle.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelSongTitle.Location = new Point(83, 33);
            labelSongTitle.Name = "labelSongTitle";
            labelSongTitle.Size = new Size(176, 35);
            labelSongTitle.TabIndex = 1;
            labelSongTitle.Text = "labelSongTitle";
            // 
            // labelDuration
            // 
            labelDuration.AutoSize = true;
            labelDuration.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            labelDuration.Location = new Point(370, 39);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(97, 20);
            labelDuration.TabIndex = 2;
            labelDuration.Text = "labelDuration";
            // 
            // labelAlbums
            // 
            labelAlbums.AutoSize = true;
            labelAlbums.Cursor = Cursors.Hand;
            labelAlbums.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            labelAlbums.ForeColor = Color.Navy;
            labelAlbums.Location = new Point(83, 91);
            labelAlbums.Name = "labelAlbums";
            labelAlbums.Size = new Size(99, 23);
            labelAlbums.TabIndex = 5;
            labelAlbums.Text = "labelAlbums";
            labelAlbums.Click += labelAlbums_Click;
            // 
            // labelArtist
            // 
            labelArtist.AutoSize = true;
            labelArtist.Cursor = Cursors.Hand;
            labelArtist.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            labelArtist.ForeColor = Color.Navy;
            labelArtist.Location = new Point(83, 68);
            labelArtist.Name = "labelArtist";
            labelArtist.Size = new Size(84, 23);
            labelArtist.TabIndex = 6;
            labelArtist.Text = "labelArtist";
            labelArtist.Click += labelArtist_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDelete.Location = new Point(427, 73);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(38, 38);
            buttonDelete.TabIndex = 7;
            buttonDelete.Text = "🗑️";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonEdit.Location = new Point(375, 73);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(38, 38);
            buttonEdit.TabIndex = 8;
            buttonEdit.Text = "✎";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // SongDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 213);
            Controls.Add(buttonEdit);
            Controls.Add(buttonDelete);
            Controls.Add(labelArtist);
            Controls.Add(labelAlbums);
            Controls.Add(labelDuration);
            Controls.Add(labelSongTitle);
            Controls.Add(buttonBack);
            MaximizeBox = false;
            MaximumSize = new Size(527, 260);
            MinimumSize = new Size(527, 260);
            Name = "SongDetailsForm";
            Text = "Про пісню";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBack;
        private Label labelSongTitle;
        private Label labelDuration;
        private Label labelAlbums;
        private Label labelArtist;
        private Button buttonDelete;
        private Button buttonEdit;
    }
}