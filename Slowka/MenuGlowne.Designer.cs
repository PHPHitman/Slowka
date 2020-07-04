namespace Slowka
{
    partial class MenuGlowne
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
            this.label1 = new System.Windows.Forms.Label();
            this.progressBtn = new System.Windows.Forms.Button();
            this.addWordsBtn = new System.Windows.Forms.Button();
            this.LearnModeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Menu główne";
            // 
            // progressBtn
            // 
            this.progressBtn.Location = new System.Drawing.Point(270, 302);
            this.progressBtn.Name = "progressBtn";
            this.progressBtn.Size = new System.Drawing.Size(261, 50);
            this.progressBtn.TabIndex = 6;
            this.progressBtn.Text = "Postęp";
            this.progressBtn.UseVisualStyleBackColor = true;
            this.progressBtn.Click += new System.EventHandler(this.progressBtn_Click);
            // 
            // addWordsBtn
            // 
            this.addWordsBtn.AccessibleName = "BtnAddWord";
            this.addWordsBtn.Location = new System.Drawing.Point(270, 238);
            this.addWordsBtn.Name = "addWordsBtn";
            this.addWordsBtn.Size = new System.Drawing.Size(261, 50);
            this.addWordsBtn.TabIndex = 5;
            this.addWordsBtn.Text = "Dodaj słówko";
            this.addWordsBtn.UseVisualStyleBackColor = true;
            this.addWordsBtn.Click += new System.EventHandler(this.addWordsBtn_Click);
            // 
            // LearnModeBtn
            // 
            this.LearnModeBtn.Location = new System.Drawing.Point(270, 173);
            this.LearnModeBtn.Name = "LearnModeBtn";
            this.LearnModeBtn.Size = new System.Drawing.Size(261, 50);
            this.LearnModeBtn.TabIndex = 4;
            this.LearnModeBtn.Text = "Tryb nauki";
            this.LearnModeBtn.UseVisualStyleBackColor = true;
            this.LearnModeBtn.Click += new System.EventHandler(this.LearnModeBtn_Click);
            // 
            // MenuGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBtn);
            this.Controls.Add(this.addWordsBtn);
            this.Controls.Add(this.LearnModeBtn);
            this.Name = "MenuGlowne";
            this.Text = "MenuGlowne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button progressBtn;
        private System.Windows.Forms.Button addWordsBtn;
        private System.Windows.Forms.Button LearnModeBtn;
    }
}