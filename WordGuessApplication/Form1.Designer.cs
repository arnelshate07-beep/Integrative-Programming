namespace WordGuessApplication
{
    partial class FrmGuessWord
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
            this.textBoxGuess = new System.Windows.Forms.TextBox();
            this.labelWord = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGuess = new System.Windows.Forms.Button();
            this.buttonHint = new System.Windows.Forms.Button();
            this.listBoxWrong = new System.Windows.Forms.ListBox();
            this.labelWrong = new System.Windows.Forms.Label();
            this.labelHint = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxGuess
            // 
            this.textBoxGuess.Location = new System.Drawing.Point(152, 111);
            this.textBoxGuess.Multiline = true;
            this.textBoxGuess.Name = "textBoxGuess";
            this.textBoxGuess.Size = new System.Drawing.Size(207, 20);
            this.textBoxGuess.TabIndex = 0;
            // 
            // labelWord
            // 
            this.labelWord.AutoSize = true;
            this.labelWord.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWord.Location = new System.Drawing.Point(118, 43);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(165, 42);
            this.labelWord.TabIndex = 2;
            this.labelWord.Text = "???????";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Guess:";
            // 
            // buttonGuess
            // 
            this.buttonGuess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuess.Location = new System.Drawing.Point(45, 150);
            this.buttonGuess.Name = "buttonGuess";
            this.buttonGuess.Size = new System.Drawing.Size(152, 37);
            this.buttonGuess.TabIndex = 4;
            this.buttonGuess.Text = "Guess?";
            this.buttonGuess.UseVisualStyleBackColor = false;
            this.buttonGuess.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // buttonHint
            // 
            this.buttonHint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHint.Location = new System.Drawing.Point(203, 150);
            this.buttonHint.Name = "buttonHint";
            this.buttonHint.Size = new System.Drawing.Size(152, 37);
            this.buttonHint.TabIndex = 5;
            this.buttonHint.Text = "Hint?";
            this.buttonHint.UseVisualStyleBackColor = false;
            this.buttonHint.Click += new System.EventHandler(this.buttonHint_Click);
            // 
            // listBoxWrong
            // 
            this.listBoxWrong.FormattingEnabled = true;
            this.listBoxWrong.Location = new System.Drawing.Point(41, 202);
            this.listBoxWrong.Name = "listBoxWrong";
            this.listBoxWrong.Size = new System.Drawing.Size(318, 95);
            this.listBoxWrong.TabIndex = 6;
            // 
            // labelWrong
            // 
            this.labelWrong.AutoSize = true;
            this.labelWrong.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWrong.Location = new System.Drawing.Point(43, 311);
            this.labelWrong.Name = "labelWrong";
            this.labelWrong.Size = new System.Drawing.Size(73, 20);
            this.labelWrong.TabIndex = 7;
            this.labelWrong.Text = "Wrong: 0";
            // 
            // labelHint
            // 
            this.labelHint.AutoSize = true;
            this.labelHint.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHint.Location = new System.Drawing.Point(301, 311);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(55, 20);
            this.labelHint.TabIndex = 8;
            this.labelHint.Text = "Hint: 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Give up? or Start new? :";
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewGame.Location = new System.Drawing.Point(193, 421);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(152, 20);
            this.buttonNewGame.TabIndex = 10;
            this.buttonNewGame.Text = "New Game?";
            this.buttonNewGame.UseVisualStyleBackColor = false;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // FrmGuessWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(403, 450);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelHint);
            this.Controls.Add(this.labelWrong);
            this.Controls.Add(this.listBoxWrong);
            this.Controls.Add(this.buttonHint);
            this.Controls.Add(this.buttonGuess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelWord);
            this.Controls.Add(this.textBoxGuess);
            this.Name = "FrmGuessWord";
            this.Text = "FrmGuessWord";
            this.Load += new System.EventHandler(this.FrmGuessWord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxGuess;
        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGuess;
        private System.Windows.Forms.Button buttonHint;
        private System.Windows.Forms.ListBox listBoxWrong;
        private System.Windows.Forms.Label labelWrong;
        private System.Windows.Forms.Label labelHint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonNewGame;
    }
}

