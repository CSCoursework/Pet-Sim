using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Tomagtachi
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }
        public static int pickquestion()
        {
          
           int pickedquestion = methods.updaterandom(methods.linecount());
           return pickedquestion;
        }
        public static int pickedquestion = pickquestion();
        static methods get = new methods();
        public static List<string> Word = methods.getwords();
        public static List<string> Hint = methods.gethints();
        //dynamic
        public int iterate = 0;
        public int correctguessnum = 0;
        public int points = 0;
        public int lives = 10;
        public string answer = Word[pickedquestion].ToLower();
        public string hint = Hint[pickedquestion];

        private void Game_Load(object sender, EventArgs e)
        {
            
            WriteHint.Text = ("Hint:" + hint);
            WritePoints.Text = ("Points: " + points.ToString());
            WriteLives.Text = ("Lives: " + lives.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string UserGuess = textBox1.Text.ToLower();
            if (UserGuess != answer)
            {
                lives = lives - 1;
                iterate++;
                WriteLives.Text = (lives.ToString());
                if (lives == 0)
                {
                    string message0 = ("Well Done! You have Scored " + points);
                    string title0 = ("Game Over");
                    MessageBox.Show(message0, title0);
                }
                else
                {

                    string message = ("Incorrect please try again. You have " + lives.ToString() + " guesses remaining");
                    string title = ("bad luck");
                    MessageBox.Show(message, title);


                }
            }
            else
            // if the user is correct
            {
                iterate++;
                correctguessnum++;
                points = points + (10 - iterate);
                WritePoints.Text = (points.ToString());
                string Message = (" well done! you got it right. It took you " + iterate + " attempts. You have scored " + correctguessnum + " question(s) correctls and have " + points + " points");
                String Title = ("Well Done!");
                MessageBox.Show(Message, Title);
                iterate = 0;
                pickedquestion = pickquestion();
                answer = Word[pickedquestion].ToLower();
                hint = Hint[pickedquestion];
                WriteHint.Text = (hint);
                WritePoints.Text = (points.ToString());
                WriteLives.Text = (lives.ToString());
                if (points == 3) 
                {
                    methods.revieve();
                    //this.Close();
                }

            }

        }

        private void WriteLives_Click(object sender, EventArgs e)
        {

        }

        private void WritePoints_Click(object sender, EventArgs e)
        {

        }

        private void WriteHint_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
