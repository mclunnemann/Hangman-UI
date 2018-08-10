using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangmanWithUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string word;
        string[] chars;
        string[] word2;
        ArrayList wrongGuess = new ArrayList();
        int timesFailed = 0;

        private void Clear()
        {
            wrongGuess.Clear();
            displayWord.Text = "";
            displayWrongGuess.Text = "";
            lblHangman.Text = "";
            timesFailed = 0;
            word = "";            

        }
        private void loadForm()
        {            
            lblHangman.Text = "";
            string URL1 = "http://www-01.sil.org/linguistics/wordlists/english/wordlist/wordsEn.txt";
            ArrayList input1 = new ArrayList();

            WebResponse response1;
            WebRequest request1 = HttpWebRequest.Create(URL1);
            response1 = request1.GetResponse();

            StreamReader sr1 = new StreamReader(response1.GetResponseStream());

            while (!sr1.EndOfStream)
            {
                input1.Add(sr1.ReadLine());
            }

            sr1.Close();
            Random rnd = new Random();

            int rand = rnd.Next(0, input1.Count);

            word = (string)input1[rand];
            chars = new string[word.Length];
            word2 = new string[word.Length];

            for (int i = 0; i < word.Length; i++)
            {
                chars[i] = word.Substring(i, 1);
                word2[i] = "_ ";
                displayWord.Text += word2[i];
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            loadForm();
        }

        private void ClickEnter()
        {
            string guess = tbxGuess.Text;
            for (int i = 0; i < chars.Length; i++)
            {
                if (word.Contains(guess))
                {
                    if (chars[i] == guess)
                    {                       
                        word2[i] = guess + " ";                       
                    }
                }
                else
                {
                    if (i == 0)
                    {
                        wrongGuess.Add(guess);
                    }                                                                                   
                }
            }

            displayWord.Text = "";
            for (int i = 0; i < word2.Length; i++)
            {
                displayWord.Text += word2[i];
            }

            displayWrongGuess.Text = "";
            for (int i = 0; i < wrongGuess.Count; i++)
            {
                displayWrongGuess.Text += wrongGuess[i] + " ";
            }

            if (!word.Contains(guess))
            {
                timesFailed++;
                if (timesFailed == 1)
                {
                    lblHangman.Text = " @";
                }
                if (timesFailed == 2)
                {
                    lblHangman.Text += "\n \\";
                }
                if (timesFailed == 3)
                {
                    lblHangman.Text += "|";
                }
                if (timesFailed == 4)
                {
                    lblHangman.Text += "/";
                }
                if (timesFailed == 5)
                {
                    lblHangman.Text += "\n  |";
                }
                if (timesFailed == 6)
                {
                    lblHangman.Text += "\n /";
                }
                if (timesFailed == 7)
                {
                    lblHangman.Text += " \\";

                    if (MessageBox.Show("You did not guess the correct letters. The word was " + word + ". \nDo you wish to try again?", "Hangman: Bummer", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Clear();
                        loadForm();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
            int count = 0;
            for (int i =0; i < word2.Length; i++)
            {
                if (word2[i].Contains("_"))
                {
                    count++;
                }
            }
            if(count == 0)
            {
                if (MessageBox.Show("You guessed all correct letters. The word was " + word + ". \nDo you wish to try again?", "Hangman: Congrats!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Clear();
                    loadForm();                    
                }
                else
                {
                    Application.Exit();
                }
            }
            
            tbxGuess.Clear();
            tbxGuess.Focus();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            ClickEnter();
        }

        private void tbxGuess_TextChanged(object sender, EventArgs e)
        {
            btnEnter.Focus();
        }
    }
}


