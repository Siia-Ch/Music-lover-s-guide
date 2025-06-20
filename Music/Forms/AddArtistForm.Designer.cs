namespace Music.Forms
{
    partial class AddArtistForm
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
            textBoxName = new TextBox();
            textBoxGenre = new TextBox();
            textBoxCountry = new TextBox();
            buttonAdd = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(215, 48);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(210, 27);
            textBoxName.TabIndex = 0;
            // 
            // textBoxGenre
            // 
            textBoxGenre.Location = new Point(215, 92);
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new Size(210, 27);
            textBoxGenre.TabIndex = 2;
            // 
            // textBoxCountry
            // 
            textBoxCountry.Location = new Point(215, 138);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.Size = new Size(210, 27);
            textBoxCountry.TabIndex = 3;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonAdd.Location = new Point(349, 217);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Додати";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 51);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 6;
            label1.Text = "Ім'я виконавця";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 95);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 8;
            label3.Text = "Жанр";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 141);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 9;
            label4.Text = "Країна";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(74, 217);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 10;
            buttonCancel.Text = "Відмінити";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // AddArtistForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 296);
            Controls.Add(buttonCancel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxCountry);
            Controls.Add(textBoxGenre);
            Controls.Add(textBoxName);
            MaximizeBox = false;
            MaximumSize = new Size(555, 343);
            MinimumSize = new Size(555, 343);
            Name = "AddArtistForm";
            Text = "Додати виконавця";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxGenre;
        private TextBox textBoxCountry;
        private Button buttonAdd;
        private Label label1;
        private Label label3;
        private Label label4;
        private Button buttonCancel;
    }
}