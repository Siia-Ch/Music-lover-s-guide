namespace Music.Forms
{
    partial class EditSongForm
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
            buttonSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonCancel = new Button();
            textBoxTitle = new TextBox();
            textBoxDuration = new TextBox();
            comboBoxArtist = new ComboBox();
            comboBoxAlbum = new ComboBox();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSave.Location = new Point(310, 264);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(126, 29);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Зберегти зміни";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 175);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Альбом";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 130);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 2;
            label2.Text = "Виконавець";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 85);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 3;
            label3.Text = "Тривалість (мм:сс)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 36);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 4;
            label4.Text = "Назва пісні";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(96, 264);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Назад";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(273, 36);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(151, 27);
            textBoxTitle.TabIndex = 7;
            // 
            // textBoxDuration
            // 
            textBoxDuration.Location = new Point(273, 82);
            textBoxDuration.Name = "textBoxDuration";
            textBoxDuration.Size = new Size(151, 27);
            textBoxDuration.TabIndex = 8;
            // 
            // comboBoxArtist
            // 
            comboBoxArtist.FormattingEnabled = true;
            comboBoxArtist.Location = new Point(273, 127);
            comboBoxArtist.Name = "comboBoxArtist";
            comboBoxArtist.Size = new Size(151, 28);
            comboBoxArtist.TabIndex = 9;
            // 
            // comboBoxAlbum
            // 
            comboBoxAlbum.FormattingEnabled = true;
            comboBoxAlbum.Location = new Point(273, 172);
            comboBoxAlbum.Name = "comboBoxAlbum";
            comboBoxAlbum.Size = new Size(151, 28);
            comboBoxAlbum.TabIndex = 10;
            // 
            // EditSongForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 337);
            Controls.Add(comboBoxAlbum);
            Controls.Add(comboBoxArtist);
            Controls.Add(textBoxDuration);
            Controls.Add(textBoxTitle);
            Controls.Add(buttonCancel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            MaximizeBox = false;
            MaximumSize = new Size(554, 384);
            MinimumSize = new Size(554, 384);
            Name = "EditSongForm";
            Text = "Редагувати пісню";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonCancel;
        private TextBox textBoxTitle;
        private TextBox textBoxDuration;
        private ComboBox comboBoxArtist;
        private ComboBox comboBoxAlbum;
    }
}