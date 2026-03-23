using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGuessApplication
{
    public partial class FrmGuessWord : Form
    {
        private string[] words = { "computer", "keyboard", "mouse", "monitor", "speaker" };

        private string answer;
        private StringBuilder hiddenWord;

        private int wrongGuess = 0;
        private int hintsLeft = 3;
        private int revealIndex = 1;

        private Random rnd = new Random();

        public FrmGuessWord()
        {
            InitializeComponent();
            NewGame();
        }

        private void NewGame()
        {
            answer = words[rnd.Next(words.Length)];

            hiddenWord = new StringBuilder();

            hiddenWord.Append(answer[0]);

            for (int i = 1; i < answer.Length - 1; i++)
            {
                hiddenWord.Append("?");
            }

            hiddenWord.Append(answer[answer.Length - 1]);

            labelWord.Text = hiddenWord.ToString();

            listBoxWrong.Items.Clear();
            textBoxGuess.Clear();

            wrongGuess = 0;
            hintsLeft = 3;
            revealIndex = 1;

            labelWrong.Text = "Wrong: 0";
            labelHint.Text = "Hints: 3";

            buttonGuess.Enabled = true;
            buttonHint.Enabled = true;
        }

        private void FrmGuessWord_Load(object sender, EventArgs e)
        {

        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            string input = textBoxGuess.Text.ToLower().Trim();

            if (input == "")
            {
                MessageBox.Show("Enter a word.");
                return;
            }

            if (input == answer)
            {
                labelWord.Text = answer;

                MessageBox.Show("Correct! Play again?");

                buttonGuess.Enabled = false;
                buttonHint.Enabled = false;
            }
            else
            {
                wrongGuess++;

                listBoxWrong.Items.Add(input);

                labelWrong.Text = "Wrong: " + wrongGuess;

                MessageBox.Show("Wrong guess!");
            }

            textBoxGuess.Clear();
            textBoxGuess.Focus();
        }

        private void buttonHint_Click(object sender, EventArgs e)
        {
            if (hintsLeft > 0)
            {
                if (revealIndex < answer.Length - 1)
                {
                    hiddenWord[revealIndex] = answer[revealIndex];
                    revealIndex++;
                }

                labelWord.Text = hiddenWord.ToString();

                hintsLeft--;
                labelHint.Text = "Hints: " + hintsLeft;

                if (hintsLeft == 0)
                {
                    buttonHint.Enabled = false;
                }
            }
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }
    }
}