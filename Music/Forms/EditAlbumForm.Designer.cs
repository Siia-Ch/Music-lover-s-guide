using System.Windows.Forms;

namespace Music.Forms
{
    partial class EditAlbumForm
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
            buttonCancel = new Button();
            buttonSave = new Button();
            textBoxTitle = new TextBox();
            comboBoxArtist = new ComboBox();
            numericUpDownYear = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).BeginInit();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(81, 233);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 0;
            buttonCancel.Text = "Назад";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSave.Location = new Point(329, 233);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(135, 29);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Зберегти зміни";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(263, 54);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(151, 27);
            textBoxTitle.TabIndex = 2;
            // 
            // comboBoxArtist
            // 
            comboBoxArtist.FormattingEnabled = true;
            comboBoxArtist.Location = new Point(263, 155);
            comboBoxArtist.Name = "comboBoxArtist";
            comboBoxArtist.Size = new Size(151, 28);
            comboBoxArtist.TabIndex = 3;
            // 
            // numericUpDownYear
            // 
            numericUpDownYear.Location = new Point(263, 102);
            numericUpDownYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numericUpDownYear.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            numericUpDownYear.Name = "numericUpDownYear";
            numericUpDownYear.Size = new Size(151, 27);
            numericUpDownYear.TabIndex = 4;
            numericUpDownYear.Value = new decimal(new int[] { 1900, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 57);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 5;
            label1.Text = "Назва альбому";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 158);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 6;
            label2.Text = "Виконавець";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 104);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 8;
            label4.Text = "Рік випуску";
            // 
            // EditAlbumForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 324);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDownYear);
            Controls.Add(comboBoxArtist);
            Controls.Add(textBoxTitle);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            MaximizeBox = false;
            MaximumSize = new Size(573, 371);
            MinimumSize = new Size(573, 371);
            Name = "EditAlbumForm";
            Text = "Редагування альбому";
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancel;
        private Button buttonSave;
        private TextBox textBoxTitle;
        private ComboBox comboBoxArtist;
        private NumericUpDown numericUpDownYear;
        private Label label1;
        private Label label2;
        private Label label4;
    }
}