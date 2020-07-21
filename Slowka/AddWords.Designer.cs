namespace Slowka.WordClass
{
    partial class AddWords
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
            this.languageError = new System.Windows.Forms.Label();
            this.categoryError = new System.Windows.Forms.Label();
            this.translateError = new System.Windows.Forms.Label();
            this.wordError = new System.Windows.Forms.Label();
            this.translateTextBox = new System.Windows.Forms.TextBox();
            this.wordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioBtnGerman = new System.Windows.Forms.RadioButton();
            this.radioBtnEnglish = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.addWordBtn = new System.Windows.Forms.Button();
            this.editWordsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // languageError
            // 
            this.languageError.AutoSize = true;
            this.languageError.ForeColor = System.Drawing.Color.Red;
            this.languageError.Location = new System.Drawing.Point(552, 134);
            this.languageError.MinimumSize = new System.Drawing.Size(100, 0);
            this.languageError.Name = "languageError";
            this.languageError.Size = new System.Drawing.Size(100, 13);
            this.languageError.TabIndex = 50;
            // 
            // categoryError
            // 
            this.categoryError.AutoSize = true;
            this.categoryError.ForeColor = System.Drawing.Color.Red;
            this.categoryError.Location = new System.Drawing.Point(549, 289);
            this.categoryError.Name = "categoryError";
            this.categoryError.Size = new System.Drawing.Size(0, 13);
            this.categoryError.TabIndex = 49;
            // 
            // translateError
            // 
            this.translateError.AutoSize = true;
            this.translateError.ForeColor = System.Drawing.Color.Red;
            this.translateError.Location = new System.Drawing.Point(549, 242);
            this.translateError.Name = "translateError";
            this.translateError.Size = new System.Drawing.Size(0, 13);
            this.translateError.TabIndex = 48;
            // 
            // wordError
            // 
            this.wordError.AutoSize = true;
            this.wordError.ForeColor = System.Drawing.Color.Red;
            this.wordError.Location = new System.Drawing.Point(546, 188);
            this.wordError.Name = "wordError";
            this.wordError.Size = new System.Drawing.Size(0, 13);
            this.wordError.TabIndex = 47;
            // 
            // translateTextBox
            // 
            this.translateTextBox.Location = new System.Drawing.Point(549, 215);
            this.translateTextBox.Name = "translateTextBox";
            this.translateTextBox.Size = new System.Drawing.Size(230, 20);
            this.translateTextBox.TabIndex = 46;
            this.translateTextBox.TextChanged += new System.EventHandler(this.translateTextBox_TextChanged);
            // 
            // wordTextBox
            // 
            this.wordTextBox.Location = new System.Drawing.Point(549, 165);
            this.wordTextBox.Name = "wordTextBox";
            this.wordTextBox.Size = new System.Drawing.Size(230, 20);
            this.wordTextBox.TabIndex = 45;
            this.wordTextBox.TextChanged += new System.EventHandler(this.wordTextBox_TextChanged);
            this.wordTextBox.Leave += new System.EventHandler(this.wordTextBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(347, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 44;
            this.label1.Text = "Tłumaczenie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(347, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 43;
            this.label4.Text = "Słówko";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Dom",
            "Szkoła",
            "Praca",
            "Przedmioty",
            "Sport",
            "Wszystkie"});
            this.comboBoxCategory.Location = new System.Drawing.Point(549, 261);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(230, 21);
            this.comboBoxCategory.TabIndex = 42;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(347, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 41;
            this.label3.Text = "Kategoria";
            // 
            // radioBtnGerman
            // 
            this.radioBtnGerman.AutoSize = true;
            this.radioBtnGerman.Location = new System.Drawing.Point(705, 105);
            this.radioBtnGerman.Name = "radioBtnGerman";
            this.radioBtnGerman.Size = new System.Drawing.Size(71, 17);
            this.radioBtnGerman.TabIndex = 40;
            this.radioBtnGerman.Text = "Niemiecki";
            this.radioBtnGerman.UseVisualStyleBackColor = true;
            // 
            // radioBtnEnglish
            // 
            this.radioBtnEnglish.AutoSize = true;
            this.radioBtnEnglish.Checked = true;
            this.radioBtnEnglish.Location = new System.Drawing.Point(555, 105);
            this.radioBtnEnglish.Name = "radioBtnEnglish";
            this.radioBtnEnglish.Size = new System.Drawing.Size(67, 17);
            this.radioBtnEnglish.TabIndex = 39;
            this.radioBtnEnglish.TabStop = true;
            this.radioBtnEnglish.Text = "Angielski";
            this.radioBtnEnglish.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(549, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 31);
            this.label2.TabIndex = 38;
            this.label2.Text = "Wybierz język";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Honeydew;
            this.buttonBack.Location = new System.Drawing.Point(612, 427);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(119, 41);
            this.buttonBack.TabIndex = 37;
            this.buttonBack.Text = "Wstecz";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // addWordBtn
            // 
            this.addWordBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.addWordBtn.Location = new System.Drawing.Point(535, 342);
            this.addWordBtn.Name = "addWordBtn";
            this.addWordBtn.Size = new System.Drawing.Size(100, 50);
            this.addWordBtn.TabIndex = 36;
            this.addWordBtn.Text = "Dodaj słówko";
            this.addWordBtn.UseVisualStyleBackColor = false;
            this.addWordBtn.Click += new System.EventHandler(this.addWordBtn_Click);
            // 
            // editWordsBtn
            // 
            this.editWordsBtn.BackColor = System.Drawing.Color.DarkSalmon;
            this.editWordsBtn.Location = new System.Drawing.Point(695, 344);
            this.editWordsBtn.Name = "editWordsBtn";
            this.editWordsBtn.Size = new System.Drawing.Size(103, 48);
            this.editWordsBtn.TabIndex = 35;
            this.editWordsBtn.Text = "Edytuj słówka";
            this.editWordsBtn.UseVisualStyleBackColor = false;
            this.editWordsBtn.Click += new System.EventHandler(this.editWordsBtn_Click);
            // 
            // AddWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 506);
            this.Controls.Add(this.languageError);
            this.Controls.Add(this.categoryError);
            this.Controls.Add(this.translateError);
            this.Controls.Add(this.wordError);
            this.Controls.Add(this.translateTextBox);
            this.Controls.Add(this.wordTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioBtnGerman);
            this.Controls.Add(this.radioBtnEnglish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.addWordBtn);
            this.Controls.Add(this.editWordsBtn);
            this.Name = "AddWords";
            this.Text = "AddWords";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label languageError;
        private System.Windows.Forms.Label categoryError;
        private System.Windows.Forms.Label translateError;
        private System.Windows.Forms.Label wordError;
        private System.Windows.Forms.TextBox translateTextBox;
        private System.Windows.Forms.TextBox wordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioBtnGerman;
        private System.Windows.Forms.RadioButton radioBtnEnglish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button addWordBtn;
        private System.Windows.Forms.Button editWordsBtn;
    }
}