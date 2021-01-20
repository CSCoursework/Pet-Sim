using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;



namespace Tomagtachi
{
    public partial class Form2 : Form
    {
        private pet actualpet = methods.returnpet();
        private activity sleep = methods.newactivity("sleep", 2, 3, -5, -12, 12);
        private activity eat = methods.newactivity("eat", 8, -4, -8, 8, -4);
        private activity play = methods.newactivity("sleep", 5, 5, 5, -8, -9);
        private activity party = methods.newactivity("Party", -4, 8, 8, -8, -4);


        Timer GameTimer = new Timer();
        Timer TimeDamadger = new Timer();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            TimeDamadger.Interval = 5000;
            TimeDamadger.Tick += new EventHandler(TimeDamadger_Tick);
            TimeDamadger.Start();
            GameTimer.Interval = 5;
            GameTimer.Tick += new EventHandler(checkdead_Tick);
            GameTimer.Start();
            methods.savepet(actualpet);
            switch (actualpet.type)
            {
                case "Dog":
                    pictureBox1.Image = Properties.Resources.Dog;
                    break;
                case "Cat":
                    pictureBox1.Image = Properties.Resources.Cat;
                    break;
                case "Fish":
                    pictureBox1.Image = Properties.Resources.Fish;
                    break;
                case "Snake":
                    pictureBox1.Image = Properties.Resources.Snake;
                    break;
            }
        }
        private void checkdead_Tick(object sender, EventArgs e)
        {
            label6.Text = (actualpet.name);
            label7.Text = ("type: " + actualpet.type);
            label1.Text = ("health: " + actualpet.health);
            label2.Text = ("happiness: " + actualpet.happiness);
            label3.Text = ("boredom: " + actualpet.boredom);
            label4.Text = ("hunger: " + actualpet.hunger);
            label5.Text = ("sleep: " + actualpet.sleep);
            methods.savepet(actualpet);
            if (methods.petdead(methods.returnpet()) == false) { }
            else { GameTimer.Stop(); TimeDamadger.Stop(); Gameover(); }
        }
        private void TimeDamadger_Tick(object sender, EventArgs e)
        {
            methods.savepet(actualpet);
            if (methods.petdead(methods.returnpet()) == false) { methods.pettimedamadge(actualpet); actualpet = methods.returnpet(); }
            else { GameTimer.Stop(); TimeDamadger.Stop(); Gameover(); }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            methods.activitystatsupdate(actualpet, sleep);
            actualpet = methods.returnpet();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            methods.activitystatsupdate(actualpet, eat);
            actualpet = methods.returnpet();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            methods.activitystatsupdate(actualpet, play);
            actualpet = methods.returnpet();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            methods.activitystatsupdate(actualpet, party);
            actualpet = methods.returnpet();
        }

        private void Gameover()
        {
            DialogResult wantrevieve = MessageBox.Show("Your pet has died of negligence. Do you want to revieve it?", "Game Over", MessageBoxButtons.YesNo);
            if (wantrevieve == DialogResult.Yes) { Game minigame = new Game(); minigame.Show();  }
            else { MessageBox.Show("GG", "Game Over", MessageBoxButtons.OK); }
        }
    }
}
