using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Кости
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //  pictureBox1.Image = Image.FromFile("C:\Users\Eugene\Pictures\12.jpg");
            pictureBoxFeld.Image = new Bitmap(@"C:\Users\LENOVO\source\repos\Кости\qwerty.png");
            pictureBoxDrop.Image = new Bitmap(@"C:\Users\LENOVO\source\repos\Кости\qwerty.png");
            pictureBoxStep.Image = new Bitmap(@"C:\Users\LENOVO\source\repos\Кости\back.png");
            
        }
        int HumanAll = 0;
        int HumanNow = 0;
        int BotAll = 0;
        int BotNow = 0;
            

        private void pictureBoxDrop_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int value = rnd.Next(1,6);
            //MessageBox.Show(value.ToString());
            switch(value)
            {
                case 1:
                    pictureBoxFeld.Image = new Bitmap(@"C:\Users\LENOVO\source\repos\Кости\1.png");
                    HumanNow = 0;
                    pictureBoxDrop.Visible = false;
                    MessageBox.Show("Вы прогорели! передайте ход компьтеру.");
                    break;
                case 2:
                    pictureBoxFeld.Image = new Bitmap(@"C:\Users\LENOVO\source\repos\Кости\2.png");
                    HumanNow = HumanNow + 2;
                    break;
                case 3:
                    pictureBoxFeld.Image = new Bitmap(@"C:\Users\LENOVO\source\repos\Кости\3.png");
                    HumanNow = HumanNow + 3;
                    break;
                case 4:
                    pictureBoxFeld.Image = new Bitmap(@"C:\Users\LENOVO\source\repos\Кости\4.png");
                    HumanNow = HumanNow + 4;
                    break;
                case 5:
                    pictureBoxFeld.Image = new Bitmap(@"C:\Users\LENOVO\source\repos\Кости\5.png");
                    HumanNow = HumanNow + 5;
                    break;
                case 6:
                    pictureBoxFeld.Image = new Bitmap(@"C:\Users\LENOVO\source\repos\Кости\6.png");
                    HumanNow = HumanNow + 6;
                    break;

            }
            labelHumanAll.Text = HumanAll.ToString();
            labelHumanNow.Text = HumanNow.ToString();
            labelBotAll.Text = BotAll.ToString();
            labelBotNow.Text = BotNow.ToString();
        }

        private void pictureBoxStep_Click(object sender, EventArgs e)
        {
            HumanAll = HumanAll + HumanNow;
            HumanNow = 0;
            if (HumanAll >= 100)
            {
                pictureBoxDrop.Visible = false;
                pictureBoxStep.Visible = false;
                MessageBox.Show("ТЫ победил!");
            }
            Random rnd = new Random();
            int value = rnd.Next(1, 6);
            //MessageBox.Show(value.ToString());         
            int n = value;
            for(int i = 0;i<n;i++)
            {
                switch (value)
                {
                    case 1:
                        pictureBoxFeld.Image = new Bitmap(@"C:\Users\LENOVO\source\repos\Кости\1.png");
                        BotNow = 0;
                        pictureBoxDrop.Visible = true;
                        break;
                    case 2:
                        pictureBoxFeld.Image = new Bitmap(@"C:\Users\LENOVO\source\repos\Кости\2.png");
                        BotNow = BotNow + 2;
                        break;
                    case 3:
                        pictureBoxFeld.Image = new Bitmap(@"C:\Users\LENOVO\source\repos\Кости\3.png");
                        BotNow = BotNow + 3;
                        break;
                    case 4:
                        pictureBoxFeld.Image = new Bitmap(@"C:\Users\LENOVO\source\repos\Кости\4.png");
                        BotNow = BotNow + 4;
                        break;
                    case 5:
                        pictureBoxFeld.Image = new Bitmap(@"C:\Users\LENOVO\source\repos\Кости\5.png");
                        BotNow = BotNow + 5;
                        break;
                    case 6:
                        pictureBoxFeld.Image = new Bitmap(@"C:\Users\LENOVO\source\repos\Кости\6.png");
                        BotNow = BotNow + 6;
                        break;

                }
                BotAll = BotAll + BotNow;
                BotNow = 0;
                pictureBoxDrop.Visible = true;
            }
            labelHumanAll.Text = HumanAll.ToString();
            labelHumanNow.Text = HumanNow.ToString();
            labelBotAll.Text = BotAll.ToString();
            labelBotNow.Text = BotNow.ToString();
            if(BotAll >= 100)
            {
                pictureBoxDrop.Visible = false;
                pictureBoxStep.Visible = false;
                MessageBox.Show("Компьютер победил!");
            }
            BotNow = 0;
        }
        private void НоваяиграToolStripMenuItem_Click(object sender, EventArgs e)
        {
             HumanAll = 0;
             HumanNow = 0;
             BotAll = 0;
             BotNow = 0;

            labelHumanAll.Text = HumanAll.ToString();
            labelHumanNow.Text = HumanNow.ToString();
            labelBotAll.Text = BotAll.ToString();
            labelBotNow.Text = BotNow.ToString();
            pictureBoxDrop.Visible = true;
            pictureBoxStep.Visible = true;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();

        }

    }
}
