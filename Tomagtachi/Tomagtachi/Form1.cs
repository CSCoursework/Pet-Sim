using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tomagtachi
{
    public partial class Form1 : Form
    {

        //public pet actualpet = methods.newpet("", "", 0, 0, 0, 0, 0);
        
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void button1_Click(object sender, EventArgs e)

        {
            try
            {
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "Dog":
                        pet Dog = methods.newpet(textBox1.Text, "Dog", 0, 0, 0, 0, 0);
                        activity dogborn = methods.newactivity("dog", 50, 50, 50, 50, 50);
                        methods.activitystatsupdate(Dog, dogborn);
                        methods.savepet(Dog);
                        break;
                    case "Cat":
                        pet Cat = methods.newpet(textBox1.Text, "Cat", 0, 0, 0, 0, 0);
                        activity catborn = methods.newactivity("cat", 35, 35, 60, 60, 60);
                        methods.activitystatsupdate(Cat, catborn);
                        methods.savepet(Cat);
                        break;
                    case "Fish":
                        pet Fish = methods.newpet(textBox1.Text,"Fish", 0, 0, 0, 0, 0);
                        activity fishborn = methods.newactivity("fish", 35, 35, 60, 60, 60);
                        methods.activitystatsupdate(Fish, fishborn);
                        methods.savepet(Fish);
                        break;
                    case "Snake":
                        pet snake = methods.newpet(textBox1.Text,"Snake", 0, 0, 0, 0, 0);
                        activity snakeborn = methods.newactivity("snake", 55, 55, 30, 55, 55);
                        methods.activitystatsupdate(snake, snakeborn);
                        methods.savepet(snake);
                        break;
                    default:
                        //MessageBox.Show("test");
                        break;
                }
                Form2 form2 = new Form2();
                form2.Show();
                //this.Hide();
            }
            catch { MessageBox.Show("Well Done idiot you forgot to select the type of pet from the drop down list"); }
            
           

        }


       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (methods.petdead(methods.returnpet()) == false) { Form2 form2 = new Form2(); form2.Show(); } else { MessageBox.Show("No vaild saves"); }
        }
    }
}
