namespace Music.Forms
{
    partial class AddSongForm
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
            textBoxTitle = new TextBox();
            comboBoxArtist = new ComboBox();
            comboBoxAlbum = new ComboBox();
            buttonAdd = new Button();
            buttonCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxDuration = new TextBox();
            SuspendLayout();
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(190, 43);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(200, 27);
            textBoxTitle.TabIndex = 0;
            // 
            // comboBoxArtist
            // 
            comboBoxArtist.FormattingEnabled = true;
            comboBoxArtist.Location = new Point(190, 149);
            comboBoxArtist.Name = "comboBoxArtist";
            comboBoxArtist.Size = new Size(200, 28);
            comboBoxArtist.TabIndex = 2;
            comboBoxArtist.SelectedIndexChanged += comboBoxArtist_SelectedIndexChanged;
            // 
            // comboBoxAlbum
            // 
            comboBoxAlbum.FormattingEnabled = true;
            comboBoxAlbum.Location = new Point(190, 204);
            comboBoxAlbum.Name = "comboBoxAlbum";
            comboBoxAlbum.Size = new Size(200, 28);
            comboBoxAlbum.TabIndex = 3;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonAdd.Location = new Point(299, 301);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(110, 38);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Додати";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(55, 301);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(110, 38);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Відмінити";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 46);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 6;
            label1.Text = "Назва пісні";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 97);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 7;
            label2.Text = "Тривалість";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 152);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 8;
            label3.Text = "Автор";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 207);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 9;
            label4.Text = "Альбом";
            // 
            // textBoxDuration
            // 
            textBoxDuration.Location = new Point(190, 94);
            textBoxDuration.Name = "textBoxDuration";
            textBoxDuration.Size = new Size(200, 27);
            textBoxDuration.TabIndex = 10;
            // 
            // AddSongForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 391);
            Controls.Add(textBoxDuration);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAdd);
            Controls.Add(comboBoxAlbum);
            Controls.Add(comboBoxArtist);
            Controls.Add(textBoxTitle);
            MaximizeBox = false;
            MaximumSize = new Size(491, 438);
            MinimumSize = new Size(491, 438);
            Name = "AddSongForm";
            Text = "Додати пісню";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTitle;
        private ComboBox comboBoxArtist;
        private ComboBox comboBoxAlbum;
        private Button buttonAdd;
        private Button buttonCancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxDuration;
    }
}