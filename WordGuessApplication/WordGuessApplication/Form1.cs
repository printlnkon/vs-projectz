using System;
using System.Collections;
using System.Text;

namespace WordGuessApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GenerateRandomWord();
        }

        private string[] wordsToGuess = { "computer", "programming", "keyboard", "software", "algorithm" };
        private string currentWord;
        private StringBuilder correctGuesses = new StringBuilder();
        private StringBuilder wrongGuesses = new StringBuilder();

        private void GenerateRandomWord()
        {
            Random random = new Random();
            currentWord = wordsToGuess[random.Next(wordsToGuess.Length)];
            UpdateWordLabel();
        }
        private void UpdateWordLabel()
        {
            StringBuilder wordDisplay = new StringBuilder();
            Random random = new Random();

            // it will determine how many characters to reveal as hints
            int numberOfHints = Math.Min(currentWord.Length / 2, 3);

            // it will track the indices of characters to reveal
            List<int> indicesToShow = new List<int>();
            while (indicesToShow.Count < numberOfHints)
            {
                int index = random.Next(currentWord.Length);
                if (!indicesToShow.Contains(index))
                {
                    indicesToShow.Add(index);
                }
            }

            // it will display the words' hints
            for (int i = 0; i < currentWord.Length; i++)
            {
                if (indicesToShow.Contains(i) || correctGuesses.ToString().Contains(currentWord[i]))
                {
                    wordDisplay.Append(currentWord[i]);
                    wordDisplay.Append(" ");
                }
                else
                {
                    wordDisplay.Append("_ ");
                }
            }

            label1.Text = wordDisplay.ToString();
        }

        // guess button
        private void button1_Click(object sender, EventArgs e)
        {
            string guessedWord = textBox1.Text.ToLower();

            if (guessedWord == currentWord)
            {
                label1.Text = $"{currentWord}"; // inputs computer
                MessageBox.Show("Correct guess!", "Guess Correct", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                GenerateRandomWord();
                return;
            }
            else
            {
                wrongGuesses.AppendLine(guessedWord); // it will add the wrong guess to listbox
                listBox1.Items.Add(guessedWord);
                MessageBox.Show("Wrong guess! Try again.", "Guess Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }
        }
        private void UpdateWrongGuessesListBox()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(wrongGuesses.ToString().Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries));
        }
        // clear button
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

    }
}
