using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartPage
{
    public partial class JumpAnswerSurvive : Form
    {   bool naLevo = false;
        bool naDesno = false;
        bool skok = false;
        bool flag1 = true;
        bool flag2 = true;
        bool flag3 = true;
        bool flag4 = true;
        bool flag5 = true;
        bool flag6 = true;
        bool flag7 = true;
        int brzinaSkok = 10;
        int sila = 8;
        int poeni = 0;

        public JumpAnswerSurvive()
        {
            InitializeComponent();
        }

  private void JumpAnswerSurvive_Load(object sender, EventArgs e)
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
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "prasanje")
                {
                    if (aligator.Bounds.IntersectsWith(x.Bounds)  && e.KeyCode == Keys.Space)
                    {
                        if (x.Name == "prasanje1" && flag1==true)
                        {
                                flag1 = false;
                            timer1.Stop();
                                DialogResult dialogResult = MessageBox.Show("Does the operator ‘as’ cast without raising an exception if the cast fails in C#? ", "Answer", MessageBoxButtons.YesNo);


                            if (dialogResult == DialogResult.Yes)
                                timer1.Start();
                            else
                            {
                                pictureBox10.Visible = true;
                                pictureBox11.Visible = true;
                                pictureBox1.Dispose();
                                timer1.Start();
                            }
                            skok = false;
                            naDesno = false;
                            naLevo = false;
                        }
                        if (x.Name == "prasanje2" && flag2 == true)
                        {
                            flag2 = false;
                            timer1.Stop();
                            DialogResult dialogResult = MessageBox.Show("Operator overloading is a kind of dynamic polymorphism.", "Answer", MessageBoxButtons.YesNo);


                            if (dialogResult == DialogResult.No)
                                timer1.Start();
                            else
                            {
                                p1.Visible = true;
                                p2.Visible = true;
                                pictureBox2.Dispose();
                                timer1.Start();
                            }
                            skok = false;
                            naDesno = false;
                            naLevo = false;
                        }
                        if (x.Name == "prasanje3" && flag3 == true)
                        {
                            flag3 = false;
                            timer1.Stop();
                            DialogResult dialogResult = MessageBox.Show("You can define one namespace inside another namespace.", "Answer", MessageBoxButtons.YesNo);


                            if (dialogResult == DialogResult.Yes)
                                timer1.Start();
                            else
                            {
                                pictureBox4.Visible = true;
                                pictureBox3.Visible = true;
                                pictureBox3.Dispose();
                                timer1.Start();
                            }
                            skok = false;
                            naDesno = false;
                            naLevo = false;
                        }
                        if (x.Name == "prasanje4" && flag4 == true)
                        {
                            flag4 = false;
                            timer1.Stop();
                            DialogResult dialogResult = MessageBox.Show("A program catches an exception with an exception handler at the place in a program where you want to handle the problem.", "Answer", MessageBoxButtons.YesNo);


                            if (dialogResult == DialogResult.Yes)
                                timer1.Start();
                            else
                            {
                                p5.Visible = true;
                                p6.Visible = true;
                                pictureBox4.Dispose();
                                timer1.Start();
                            }
                            skok = false;
                            naDesno = false;
                            naLevo = false;
                        }
                        if (x.Name == "prasanje6" && flag5 == true)
                        {
                            flag5 = false;
                            timer1.Stop();
                            DialogResult dialogResult = MessageBox.Show("C# can inherit multiple classes.", "Answer", MessageBoxButtons.YesNo);


                            if (dialogResult == DialogResult.No)
                                timer1.Start();
                            else
                            {
                                p8.Visible = true;
                                p7.Visible = true;
                                pictureBox6.Dispose();
                                timer1.Start();
                            }
                            skok = false;
                            naDesno = false;
                            naLevo = false;
                        }
                        if (x.Name == "prasanje5" && flag6 == true)
                        {
                            flag6 = false;
                            timer1.Stop();
                            DialogResult dialogResult = MessageBox.Show("The “protected” access specifier in C# allows a class to hide its member variables and member functions from other functions and objects. ", "Answer", MessageBoxButtons.YesNo);


                            if (dialogResult == DialogResult.No)
                                timer1.Start();
                            else
                            {
                                p12.Visible = true;
                                p11.Visible = true;
                                pictureBox9.Dispose();
                                timer1.Start();
                            }
                            skok = false;
                            naDesno = false;
                            naLevo = false;
                        }
                        if (x.Name == "prasanje7" && flag7 == true)
                        {
                            flag7 = false;
                            timer1.Stop();
                            DialogResult dialogResult = MessageBox.Show("We can use reserved keywords as identifiers in C#. ", "Answer", MessageBoxButtons.YesNo);


                            if (dialogResult == DialogResult.No)
                                timer1.Start();
                            else
                            {
                                p10.Visible = true;
                                p9.Visible = true;
                                pictureBox7.Dispose();
                                timer1.Start();
                            }
                            skok = false;
                            naDesno = false;
                            naLevo = false;
                        }
                    }
                }
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
                
            }
           
            if (aligator.Bounds.IntersectsWith(pochniNivo2.Bounds))
            {

                timer1.Stop();
                this.Close();
                JumpAnswerSurvive2 inJumpAnswerSurvive = new JumpAnswerSurvive2();
                inJumpAnswerSurvive.ShowDialog();
            }
        }

        private void prasanje5_Click(object sender, EventArgs e)
        {

        }
    }
}
