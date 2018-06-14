using System;
using System.Windows.Forms;

namespace JAS
{
    public partial class Form1 : Form
    {
        bool naLevo = false;
        bool naDesno = false;
        bool skok = false;
        bool flag = true;
        int brzinaSkok = 10;
        int sila = 8;
        int poeni = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                naLevo = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                naDesno = true;
            }
            if (e.KeyCode == Keys.Space && !skok)
            {
                skok = true;
            }

        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                naLevo = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                naDesno = false;
            }
            if (skok)
            {
                skok = false;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            aligator.Top += brzinaSkok;
            if (skok && sila < 0)
            {
                skok = false;

            }
            if (naLevo)
            {
                aligator.Left -= 5;

            }
            if (naDesno)
            {
                aligator.Left += 5;

            }
            if (skok)
            {
                brzinaSkok = -12;
                sila -= 1;

            }
            else
            {
                brzinaSkok = 12;
            }
            foreach (Control x in this.Controls)
            {

                if (x is PictureBox && x.Tag == "platform")

                    if (aligator.Bounds.IntersectsWith(x.Bounds) && !skok)

                    {
                        sila = 8;
                        aligator.Top = x.Top - aligator.Height;
                    }
                if (x is PictureBox && x.Tag == "prasanje")
                {
                    if (aligator.Bounds.IntersectsWith(x.Bounds) && !skok)
                    {
                        if(x.Name=="prasanje1")
                        {
                            if (flag == true)
                            { DialogResult dialogResult = MessageBox.Show("Kako si?", "Dobro", MessageBoxButtons.YesNo);
                                flag = false;

                                if (dialogResult == DialogResult.Yes && flag == false)
                                    continue;
                                if (dialogResult == DialogResult.No && flag == false)
                                    continue;
                              }  
                        }
                    }
                }
            }
           
            if (aligator.Bounds.IntersectsWith(pochniNivo2.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Bravo  be Angel!");
            }
        }

        
    }
}
