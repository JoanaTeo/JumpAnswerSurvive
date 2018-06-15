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
    public partial class Form1 : Form
    {
        JumpAnswerSurvive inJumpAnswerSurvive;
        Rules inRules = new Rules();
        public Form1()
        {
            InitializeComponent();
        }

        private void StartGame(object sender, EventArgs e)
        {
             inJumpAnswerSurvive = new JumpAnswerSurvive();
            inJumpAnswerSurvive.ShowDialog();
        }

        private void ShowRules(object sender, EventArgs e)
        {
            inRules.Show();
        }
    }
}
