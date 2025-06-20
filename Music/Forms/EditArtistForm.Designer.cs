namespace Music.Forms
{
    partial class EditArtistForm
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
            labelCountry = new Label();
            labelGenre = new Label();
            buttonSave = new Button();
            buttonCancel = new Button();
            textBoxCountry = new TextBox();
            textBoxGenre = new TextBox();
            textBoxName = new TextBox();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(91, 46);
            labelName.Name = "labelName";
            labelName.Size = new Size(93, 20);
            labelName.TabIndex = 0;
            labelName.Text = "Виконавець";
            // 
            // labelCountry
            // 
            labelCountry.AutoSize = true;
            labelCountry.Location = new Point(91, 145);
            labelCountry.Name = "labelCountry";
            labelCountry.Size = new Size(56, 20);
            labelCountry.TabIndex = 1;
            labelCountry.Text = "Країна";
            // 
            // labelGenre
            // 
            labelGenre.AutoSize = true;
            labelGenre.Location = new Point(93, 93);
            labelGenre.Name = "labelGenre";
            labelGenre.Size = new Size(48, 20);
            labelGenre.TabIndex = 2;
            labelGenre.Text = "Жанр";
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSave.Location = new Point(308, 217);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(138, 29);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Зберегти зміни";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(68, 217);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Назад";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // textBoxCountry
            // 
            textBoxCountry.Location = new Point(266, 142);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.Size = new Size(152, 27);
            textBoxCountry.TabIndex = 7;
            // 
            // textBoxGenre
            // 
            textBoxGenre.Location = new Point(266, 90);
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new Size(152, 27);
            textBoxGenre.TabIndex = 8;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(266, 43);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(152, 27);
            textBoxName.TabIndex = 9;
            // 
            // EditArtistForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 283);
            Controls.Add(textBoxName);
            Controls.Add(textBoxGenre);
            Controls.Add(textBoxCountry);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(labelGenre);
            Controls.Add(labelCountry);
            Controls.Add(labelName);
            MaximizeBox = false;
            MaximumSize = new Size(534, 330);
            MinimumSize = new Size(534, 330);
            Name = "EditArtistForm";
            Text = "Редагувати виконавця";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelCountry;
        private Label labelGenre;
        private Button buttonSave;
        private Button buttonCancel;
        private TextBox textBoxCountry;
        private TextBox textBoxGenre;
        private TextBox textBoxName;
    }
}