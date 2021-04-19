using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Indivisual_Project
{

    public partial class Form1 : Form
    {
        LinkedList<int> BStats;
        LinkedList<int> Bulbasaurpp;
        LinkedList<int> PStats;
        LinkedList<int> Pikachupp;
        public LinkedList<string> moves = new LinkedList<string>();

        Bulbasaur bulbasaur = new Bulbasaur();
        Pikachu pikachu = new Pikachu();

        public Form1()
        {
            InitializeComponent();
            BulbasaurPicture.Image = Image.FromFile("Bulbasaur.png");
            BulbasaurPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            PikachuPicture.Image = Image.FromFile("Pikachupng.png");
            PikachuPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            
        }

        private void BulbasaurPicture_Click(object sender, EventArgs e)
        {
            
        }

        private void PikachuPicture_Click(object sender, EventArgs e)
        {
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = ("HP: " + pikachu.PStats.First.Value + "\n\r                                 Defense: " + pikachu.PStats.First.Next.Value + "\n\r                            Attack: " + pikachu.PStats.First.Next.Next.Value);
            textBox2.Text = ("HP: " + bulbasaur.BStats.First.Value + "\n\r                                 Defense: " + bulbasaur.BStats.First.Next.Value + "\n\r                            Attack: " + bulbasaur.BStats.First.Next.Next.Value);

        }
        public class Bulbasaur
        {
            public LinkedList<int> BStats = new LinkedList<int>();
            public LinkedList<int> Bulbasaurpp = new LinkedList<int>();
            public int lowvine = 10;
            public int highvine = 13;
            public Random rand = new Random();
            public Bulbasaur()
            {
                int vinedmg = rand.Next(lowvine, highvine);
                //HP
                BStats.AddLast(80);
                //Defense
                BStats.AddLast(60);
                //Attack
                BStats.AddLast(70);
                //leer
                Bulbasaurpp.AddLast(15);
                //synthesis
                Bulbasaurpp.AddLast(5);
                //growl
                Bulbasaurpp.AddLast(15);
                //vine whip
                Bulbasaurpp.AddLast(10);
            }

            public string DecreaseBulbasaurpp()
            {
                if (Bulbasaurpp.First.Value != 0)
                {
                    Bulbasaurpp.First.Value = (Bulbasaurpp.First.Value - 1);
                    return Bulbasaurpp.First.Value.ToString();
                }
                else
                {
                    return ("You cannot use leer. There is no more PP for leer.");
                }
             
            }
            public string DecreaseBulbasaurpp2()
            {
                if (Bulbasaurpp.First.Next.Value > 0)
                {
                    Bulbasaurpp.First.Next.Value = Bulbasaurpp.First.Next.Value - 1;
                    return Bulbasaurpp.First.Next.Value.ToString();
                }
                else
                {
                    return ("You cannot use synthesis. There is no more PP for synthesis.");
                }
            }
            public string DecreaseBulbasaurpp3()
            {
                if (Bulbasaurpp.First.Value > 0)
                {
                    Bulbasaurpp.First.Next.Next.Value = Bulbasaurpp.First.Next.Next.Value - 1;
                    return Bulbasaurpp.First.Next.Next.Value.ToString();
                }
                else
                {
                    return ("You cannot use growl. There is no more PP for growl.");
                }
            }
            public string DecreaseBulbasaurpp4()
            {
                if (Bulbasaurpp.First.Next.Next.Next.Value > 0)
                {
                    Bulbasaurpp.First.Next.Next.Next.Value = Bulbasaurpp.First.Next.Next.Next.Value - 1;
                    return Bulbasaurpp.First.Next.Next.Next.Value.ToString();
                }
                else
                {
                    return ("You cannot use vine whip. There is no more PP for vine whip.");
                }
            }
        }
        public class Pikachu
        {
            public LinkedList<int> PStats = new LinkedList<int>();
            public LinkedList<int> Pikachupp = new LinkedList<int>();
            public int thunderx = 10;
            public int thundery = 13;
            public Random rand = new Random();
            public Pikachu()
            {
                int thunderdmg = rand.Next(thunderx, thundery);
                //HP
                PStats.AddLast(80);
                //Defense
                PStats.AddLast(60);
                //Attack
                PStats.AddLast(70);
                //defense curl
                Pikachupp.AddLast(15);
                //recover
                Pikachupp.AddLast(5);
                //tail whip
                Pikachupp.AddLast(15);
                //thunder  shock
                Pikachupp.AddLast(10);
            }
            public string DecreasePikachupp()
            {
                if (Pikachupp.First.Value > 0)
                {
                    Pikachupp.First.Value = Pikachupp.First.Value - 1;
                    return Pikachupp.First.Value.ToString();
                   
                }
                else
                {
                    return ("There is no pp left for defense curl");
                }

            }
            public string DecreasePikachupp2()
            {
                if (Pikachupp.First.Next.Value > 0)
                {
                    Pikachupp.First.Next.Value = Pikachupp.First.Next.Value - 1;
                    return Pikachupp.First.Next.Value.ToString();
                }
                else
                {
                    return ("There is no pp left for recover");
                }
            }
            public string DecreasePikachupp3()
            {
                if (Pikachupp.First.Next.Next.Value > 0)
                {
                    Pikachupp.First.Next.Next.Value = Pikachupp.First.Next.Next.Value - 1;
                    return Pikachupp.First.Next.Next.Value.ToString();
                }
                else
                {
                    return ("There is no pp left for tail whip"); ;
                }
            }
            public string DecreasePikachupp4()
            {
                if (Pikachupp.First.Next.Next.Next.Value > 0)
                {
                    Pikachupp.First.Next.Next.Next.Value = Pikachupp.First.Next.Next.Next.Value - 1;
                    return Pikachupp.First.Next.Next.Next.Value.ToString();
                }
                else
                {
                    return ("There is no pp left for thundershock");
                }
            }

        }

        public void button5_Click(object sender, EventArgs e)
        {
            //leer
            moves.AddLast("bulbasaur: leer");
            if(bulbasaur.Bulbasaurpp.First.Value > 0)
            {
                MessageBox.Show("The pp of leer is: " + bulbasaur.DecreaseBulbasaurpp().ToString() + " The opponents defense fell.");
                pikachu.PStats.First.Next.Value -= 5;
                textBox1.Text = ("HP: " + pikachu.PStats.First.Value + "\n\r                                 Defense: " + (pikachu.PStats.First.Next.Value) + "\n\r                            Attack: " + pikachu.PStats.First.Next.Next.Value);
                Random rand = new Random();
                bulbasaur.lowvine += 1;
                bulbasaur.highvine += 1;
                int vinedmg = rand.Next(bulbasaur.lowvine, bulbasaur.highvine);
            }
            else
            {
                MessageBox.Show("There is no PP left in leer");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //synthesis
            moves.AddLast("bulbasaur: synthesis");
            if (bulbasaur.BStats.First.Value <= 60 && bulbasaur.Bulbasaurpp.First.Next.Value > 0)
            {
                MessageBox.Show("The pp of synthesis is " + bulbasaur.DecreaseBulbasaurpp2().ToString() + ". The HP of Bulbasaur increased by 20.");
                bulbasaur.BStats.AddFirst(BStats.First.Value + 20);
                bulbasaur.BStats.Remove(BStats.First.Next);
                textBox2.Text = ("HP: " + (bulbasaur.BStats.First.Value) + "\n\r                                 Defense: " + bulbasaur.BStats.First.Next.Value + "\n\r                            Attack: " + bulbasaur.BStats.First.Next.Next.Value);


            }
            else if(bulbasaur.BStats.First.Value > 60)
            {
                MessageBox.Show("You're HP is too high");
            }
            else if(bulbasaur.Bulbasaurpp.First.Next.Value == 0)
            {
                MessageBox.Show("There is no PP left in synthesis");
            }
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //growl
            moves.AddLast("bulbasaur: growl");
            if (bulbasaur.Bulbasaurpp.First.Value > 0)
            {
                MessageBox.Show("The pp of growl is: " + bulbasaur.DecreaseBulbasaurpp3().ToString() + " The opponents attack fell.");
                pikachu.PStats.First.Next.Next.Value -= 5;
                textBox1.Text = ("HP: " + pikachu.PStats.First.Value + "\n\r                                 Defense: " + pikachu.PStats.First.Next.Value + "\n\r                            Attack: " + pikachu.PStats.First.Next.Next.Value);
                Random rand = new Random();
                int thunderdmg = rand.Next(pikachu.thunderx - 2, pikachu.thundery - 2);
            }
            else
            {
                MessageBox.Show("You ran out of PP for growl");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //vine whip
            moves.AddLast("bulbasaur: vine whip");
            Random rand = new Random();
            if(bulbasaur.Bulbasaurpp.First.Value > 0)
            {
                int vinedmg = (rand.Next(bulbasaur.lowvine, bulbasaur.highvine));
                pikachu.PStats.AddFirst(pikachu.PStats.First.Value - vinedmg);
                pikachu.PStats.Remove(pikachu.PStats.First.Next);
                MessageBox.Show("The pp of vine whip is: " + bulbasaur.DecreaseBulbasaurpp4().ToString() + " The opponents lost some health.");
                textBox1.Text = ("HP: " + pikachu.PStats.First.Value + "\n\r                                 Defense: " + (pikachu.PStats.First.Next.Value) + "\n\r                            Attack: " + pikachu.PStats.First.Next.Next.Value);

            }
            else
            {
                MessageBox.Show("You ran out of PP for vine whip");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //run
            /*
            MessageBox.Show("You fled the battle");
            foreach(string in moves)
            {
                MessageBox.Show(moves.next);

            }*/
            
            System.Windows.Forms.Application.ExitThread();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //opponent turn


        }
    }

}
