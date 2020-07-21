namespace Slowka.WordClass
{
    partial class EditWord
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.categoryError = new System.Windows.Forms.Label();
            this.translateError = new System.Windows.Forms.Label();
            this.wordError = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.germanBtn = new System.Windows.Forms.RadioButton();
            this.englishBtn = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.unlearnedBtn = new System.Windows.Forms.RadioButton();
            this.learnedBtn = new System.Windows.Forms.RadioButton();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.translateBox = new System.Windows.Forms.TextBox();
            this.wordBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.saveChanges = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchGridView = new System.Windows.Forms.DataGridView();
            this.searchWord = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.searchGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryError
            // 
            this.categoryError.AutoSize = true;
            this.categoryError.ForeColor = System.Drawing.Color.Red;
            this.categoryError.Location = new System.Drawing.Point(820, 312);
            this.categoryError.Name = "categoryError";
            this.categoryError.Size = new System.Drawing.Size(0, 13);
            this.categoryError.TabIndex = 80;
            // 
            // translateError
            // 
            this.translateError.AutoSize = true;
            this.translateError.ForeColor = System.Drawing.Color.Red;
            this.translateError.Location = new System.Drawing.Point(820, 259);
            this.translateError.Name = "translateError";
            this.translateError.Size = new System.Drawing.Size(0, 13);
            this.translateError.TabIndex = 79;
            // 
            // wordError
            // 
            this.wordError.AutoSize = true;
            this.wordError.ForeColor = System.Drawing.Color.Red;
            this.wordError.Location = new System.Drawing.Point(820, 214);
            this.wordError.Name = "wordError";
            this.wordError.Size = new System.Drawing.Size(0, 13);
            this.wordError.TabIndex = 78;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Coral;
            this.button2.Location = new System.Drawing.Point(948, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 33);
            this.button2.TabIndex = 77;
            this.button2.Text = "Usuń";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // germanBtn
            // 
            this.germanBtn.AutoSize = true;
            this.germanBtn.Location = new System.Drawing.Point(632, 71);
            this.germanBtn.Name = "germanBtn";
            this.germanBtn.Size = new System.Drawing.Size(71, 17);
            this.germanBtn.TabIndex = 76;
            this.germanBtn.Text = "Niemiecki";
            this.germanBtn.UseVisualStyleBackColor = true;
            this.germanBtn.CheckedChanged += new System.EventHandler(this.germanBtn_CheckedChanged);
            // 
            // englishBtn
            // 
            this.englishBtn.AutoSize = true;
            this.englishBtn.Checked = true;
            this.englishBtn.Location = new System.Drawing.Point(493, 72);
            this.englishBtn.Name = "englishBtn";
            this.englishBtn.Size = new System.Drawing.Size(67, 17);
            this.englishBtn.TabIndex = 75;
            this.englishBtn.TabStop = true;
            this.englishBtn.Text = "Angielski";
            this.englishBtn.UseVisualStyleBackColor = true;
            this.englishBtn.CheckedChanged += new System.EventHandler(this.englishBtn_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(539, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 24);
            this.label7.TabIndex = 74;
            this.label7.Text = "Wybierz język";
            // 
            // unlearnedBtn
            // 
            this.unlearnedBtn.AutoSize = true;
            this.unlearnedBtn.Location = new System.Drawing.Point(973, 339);
            this.unlearnedBtn.Name = "unlearnedBtn";
            this.unlearnedBtn.Size = new System.Drawing.Size(88, 17);
            this.unlearnedBtn.TabIndex = 73;
            this.unlearnedBtn.Text = "Nienauczone";
            this.unlearnedBtn.UseVisualStyleBackColor = true;
            this.unlearnedBtn.CheckedChanged += new System.EventHandler(this.unlearnedBtn_CheckedChanged);
            // 
            // learnedBtn
            // 
            this.learnedBtn.AutoSize = true;
            this.learnedBtn.Location = new System.Drawing.Point(812, 335);
            this.learnedBtn.Name = "learnedBtn";
            this.learnedBtn.Size = new System.Drawing.Size(74, 17);
            this.learnedBtn.TabIndex = 72;
            this.learnedBtn.Text = "Nauczone";
            this.learnedBtn.UseVisualStyleBackColor = true;
            this.learnedBtn.CheckedChanged += new System.EventHandler(this.learnedBtn_CheckedChanged);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Location = new System.Drawing.Point(812, 280);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(249, 21);
            this.categoryComboBox.TabIndex = 71;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // translateBox
            // 
            this.translateBox.Location = new System.Drawing.Point(812, 236);
            this.translateBox.Name = "translateBox";
            this.translateBox.Size = new System.Drawing.Size(249, 20);
            this.translateBox.TabIndex = 70;
            this.translateBox.TextChanged += new System.EventHandler(this.translateBox_TextChanged);
            // 
            // wordBox
            // 
            this.wordBox.Location = new System.Drawing.Point(812, 191);
            this.wordBox.Name = "wordBox";
            this.wordBox.Size = new System.Drawing.Size(249, 20);
            this.wordBox.TabIndex = 69;
            this.wordBox.TextChanged += new System.EventHandler(this.wordBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(700, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 68;
            this.label6.Text = "Zmień status";
            // 
            // saveChanges
            // 
            this.saveChanges.BackColor = System.Drawing.Color.LightSeaGreen;
            this.saveChanges.Location = new System.Drawing.Point(812, 382);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(116, 33);
            this.saveChanges.TabIndex = 67;
            this.saveChanges.Text = "Zapisz";
            this.saveChanges.UseVisualStyleBackColor = false;
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(698, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Kategoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(698, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Tłumaczenie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(698, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Słowko";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(697, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 63;
            this.label1.Text = "Edytuj";
            // 
            // searchGridView
            // 
            this.searchGridView.AllowUserToAddRows = false;
            this.searchGridView.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.searchGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.searchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchGridView.EnableHeadersVisualStyles = false;
            this.searchGridView.Location = new System.Drawing.Point(88, 194);
            this.searchGridView.Name = "searchGridView";
            this.searchGridView.ReadOnly = true;
            this.searchGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(61)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.searchGridView.RowHeadersVisible = false;
            this.searchGridView.RowHeadersWidth = 40;
            this.searchGridView.Size = new System.Drawing.Size(472, 200);
            this.searchGridView.TabIndex = 62;
            this.searchGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchGridView_CellClick);
            this.searchGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.searchGridView_RowHeaderMouseClick);
            // 
            // searchWord
            // 
            this.searchWord.Location = new System.Drawing.Point(88, 152);
            this.searchWord.Name = "searchWord";
            this.searchWord.Size = new System.Drawing.Size(472, 20);
            this.searchWord.TabIndex = 61;
            this.searchWord.TextChanged += new System.EventHandler(this.searchWord_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(84, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 24);
            this.label5.TabIndex = 60;
            this.label5.Text = "Wyszukaj słówko";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnBack.Location = new System.Drawing.Point(572, 445);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 39);
            this.btnBack.TabIndex = 59;
            this.btnBack.Text = "Wstecz";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // EditWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 506);
            this.Controls.Add(this.categoryError);
            this.Controls.Add(this.translateError);
            this.Controls.Add(this.wordError);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.germanBtn);
            this.Controls.Add(this.englishBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.unlearnedBtn);
            this.Controls.Add(this.learnedBtn);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.translateBox);
            this.Controls.Add(this.wordBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.saveChanges);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchGridView);
            this.Controls.Add(this.searchWord);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBack);
            this.Name = "EditWord";
            this.Text = "EditWord";
            this.Load += new System.EventHandler(this.EditWord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label categoryError;
        private System.Windows.Forms.Label translateError;
        private System.Windows.Forms.Label wordError;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton germanBtn;
        private System.Windows.Forms.RadioButton englishBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton unlearnedBtn;
        private System.Windows.Forms.RadioButton learnedBtn;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.TextBox translateBox;
        private System.Windows.Forms.TextBox wordBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView searchGridView;
        private System.Windows.Forms.TextBox searchWord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBack;
    }
}