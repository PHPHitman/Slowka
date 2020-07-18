namespace Slowka
{
    partial class MainMenu
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(447, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Menu główne";
            // 
            // progressBtn
            // 
            this.progressBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.progressBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.progressBtn.Location = new System.Drawing.Point(424, 344);
            this.progressBtn.Name = "progressBtn";
            this.progressBtn.Size = new System.Drawing.Size(261, 50);
            this.progressBtn.TabIndex = 10;
            this.progressBtn.Text = "Postęp";
            this.progressBtn.UseVisualStyleBackColor = false;
            this.progressBtn.Click += new System.EventHandler(this.progressBtn_Click);
            // 
            // addWordsBtn
            // 
            this.addWordsBtn.AccessibleName = "BtnAddWord";
            this.addWordsBtn.BackColor = System.Drawing.Color.Coral;
            this.addWordsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addWordsBtn.Location = new System.Drawing.Point(424, 280);
            this.addWordsBtn.Name = "addWordsBtn";
            this.addWordsBtn.Size = new System.Drawing.Size(261, 50);
            this.addWordsBtn.TabIndex = 9;
            this.addWordsBtn.Text = "Dodaj słówko";
            this.addWordsBtn.UseVisualStyleBackColor = false;
            this.addWordsBtn.Click += new System.EventHandler(this.addWordsBtn_Click);
            // 
            // LearnModeBtn
            // 
            this.LearnModeBtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.LearnModeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LearnModeBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LearnModeBtn.Location = new System.Drawing.Point(424, 215);
            this.LearnModeBtn.Name = "LearnModeBtn";
            this.LearnModeBtn.Size = new System.Drawing.Size(261, 50);
            this.LearnModeBtn.TabIndex = 8;
            this.LearnModeBtn.Text = "Tryb nauki";
            this.LearnModeBtn.UseVisualStyleBackColor = false;
            this.LearnModeBtn.Click += new System.EventHandler(this.LearnModeBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBtn);
            this.Controls.Add(this.addWordsBtn);
            this.Controls.Add(this.LearnModeBtn);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
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