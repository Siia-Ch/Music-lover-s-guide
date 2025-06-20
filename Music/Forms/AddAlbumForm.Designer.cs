namespace Music.Forms
{
    partial class AddAlbumForm
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
            buttonAdd = new Button();
            buttonCancel = new Button();
            comboBoxArtist = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            textBoxTitle = new TextBox();
            numericUpDownYear = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).BeginInit();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonAdd.Location = new Point(330, 254);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Додати";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(64, 254);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Відмінити";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // comboBoxArtist
            // 
            comboBoxArtist.FormattingEnabled = true;
            comboBoxArtist.Location = new Point(255, 47);
            comboBoxArtist.Name = "comboBoxArtist";
            comboBoxArtist.Size = new Size(151, 28);
            comboBoxArtist.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 103);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 3;
            label1.Text = "Назва альбому";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 161);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 4;
            label2.Text = "Рік";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 50);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 6;
            label4.Text = "Виконавець";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(255, 100);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(151, 27);
            textBoxTitle.TabIndex = 7;
            // 
            // numericUpDownYear
            // 
            numericUpDownYear.Location = new Point(255, 159);
            numericUpDownYear.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            numericUpDownYear.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            numericUpDownYear.Name = "numericUpDownYear";
            numericUpDownYear.Size = new Size(151, 27);
            numericUpDownYear.TabIndex = 8;
            numericUpDownYear.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // AddAlbumForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 338);
            Controls.Add(numericUpDownYear);
            Controls.Add(textBoxTitle);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxArtist);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAdd);
            MaximizeBox = false;
            MaximumSize = new Size(526, 385);
            MinimumSize = new Size(526, 385);
            Name = "AddAlbumForm";
            Text = "Додати альбом";
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdd;
        private Button buttonCancel;
        private ComboBox comboBoxArtist;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox textBoxTitle;
        private NumericUpDown numericUpDownYear;
    }
}