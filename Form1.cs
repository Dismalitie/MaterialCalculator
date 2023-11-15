using NCalc;
using System;
using System.Text;
using System.Windows.Forms;

namespace MaterialCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// MaterialCalculator - https://github.com/Dismalitie/MaterialCalculator
        /// A free, open-source Material Design Calculator made with Siticone UI
        /// 
        /// Hello! If your reading this, you're probably looking through the src. That's ok, I won't judge.
        /// I've tried to document this as well as I can with comments every now and again so you can understand my messy and bad practices.
        /// If you find any bugs or suggestions, please report them at https://github.com/Dismalitie/MaterialCalculator/issues/new.
        /// 
        /// There will be quite a bit of repetition because I wanted to refrain from functions so beginners dont have to search for Functions.cs
        /// and so it's easier to check the src for malware.
        /// 
        /// Anyway, thanks for even coming to my repository! 🎉
        /// </summary>


        bool isstart = true; // so that the default value of label1 won't just get appended with the button you press 
        bool isop = true; // makes sure you cant have ++ or -- etc...

        protected override CreateParams CreateParams // creates dropshadow
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cls_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }



        // backspace events
        private void backspace_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length == 1) // checks whether to ovewrite the string
            {
                isstart = true;
                label1.Text = "0";
                return;
            }
            StringBuilder stringBuilder = new StringBuilder(label1.Text); // create a new StringBuilder instance with label1.Text as the input
            stringBuilder.Remove(stringBuilder.Length - 1, 1); // remove last letter
            label1.Text = stringBuilder.ToString(); // sets the label's text to the output
        }
        private void backspace_DoubleClick(object sender, EventArgs e)
        {
            isstart = true;
            label1.Text = "0";
        }

        // operation events
        private void add_Click(object sender, EventArgs e)
        {
            if (!isop)
            {
                label1.Text = label1.Text + "+";
                isop = true;
            }
        }
        private void div_Click(object sender, EventArgs e)
        {
            if (!isop)
            {
                label1.Text = label1.Text + "÷";
                isop = true;
            }
        }
        private void mult_Click(object sender, EventArgs e)
        {
            if (!isop)
            {
                label1.Text = label1.Text + "×";
                isop = true;
            }
        }
        private void sub_Click(object sender, EventArgs e)
        {
            if (!isop)
            {
                label1.Text = label1.Text + "-";
                isop = true;
            }
        }

        // digit events
        private void one_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length == 14) // checks if the label can hold any more characters without clipping off the panel
            {
                return;
            }
            if (isstart) // checks whether to overwrite
            {
                label1.Text = "1";
                isstart = false;
                isop = false;
            }
            else
            {
                label1.Text = label1.Text + "1";
                isop = false;
            }
        }
        private void two_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length == 14) // checks if the label can hold any more characters without clipping off the panel
            {
                return;
            }
            if (isstart) // checks whether to overwrite
            {
                label1.Text = "2";
                isstart = false;
                isop = false;
            }
            else
            {
                label1.Text = label1.Text + "2";
                isop = false;
            }
        }
        private void three_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length == 14) // checks if the label can hold any more characters without clipping off the panel
            {
                return;
            }
            if (isstart) // checks whether to overwrite
            {
                label1.Text = "3";
                isstart = false;
                isop = false;
            }
            else
            {
                label1.Text = label1.Text + "3";
                isop = false;
            }
        }
        private void four_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length == 14) // checks if the label can hold any more characters without clipping off the panel
            {
                return;
            }
            if (isstart) // checks whether to overwrite
            {
                label1.Text = "4";
                isstart = false;
                isop = false;
            }
            else
            {
                label1.Text = label1.Text + "4";
                isop = false;
            }
        }
        private void five_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length == 14) // checks if the label can hold any more characters without clipping off the panel
            {
                return;
            }
            if (isstart) // checks whether to overwrite
            {
                label1.Text = "5";
                isstart = false;
                isop = false;
            }
            else
            {
                label1.Text = label1.Text + "5";
                isop = false;
            }
        }
        private void six_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length == 14) // checks if the label can hold any more characters without clipping off the panel
            {
                return;
            }
            if (isstart) // checks whether to overwrite
            {
                label1.Text = "6";
                isstart = false;
                isop = false;
            }
            else
            {
                label1.Text = label1.Text + "6";
                isop = false;
            }
        }
        private void seven_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length == 14) // checks if the label can hold any more characters without clipping off the panel
            {
                return;
            }
            if (isstart) // checks whether to overwrite
            {
                label1.Text = "7";
                isstart = false;
                isop = false;
            }
            else
            {
                label1.Text = label1.Text + "7";
                isop = false;
            }
        }
        private void eight_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length == 14) // checks if the label can hold any more characters without clipping off the panel
            {
                return;
            }
            if (isstart) // checks whether to overwrite
            {
                label1.Text = "8";
                isstart = false;
                isop = false;
            }
            else
            {
                label1.Text = label1.Text + "8";
                isop = false;
            }
        }
        private void nine_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length == 14) // checks if the label can hold any more characters without clipping off the panel
            {
                return;
            }
            if (isstart) // checks whether to overwrite
            {
                label1.Text = "9";
                isstart = false;
                isop = false;
            }
            else
            {
                label1.Text = label1.Text + "9";
                isop = false;
            }
        }
        private void zero_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length == 14) // checks if the label can hold any more characters without clipping off the panel
            {
                return;
            }
            if (isstart) // checks whether to overwrite
            {
                label1.Text = "0";
                isstart = false;
                isop = false;
            }
            else
            {
                label1.Text = label1.Text + "0";
                isop = false;
            }
        }

        private void evaluate_Click(object sender, EventArgs e)
        {
            string equation = label1.Text.Replace("÷", "/").Replace("×", "*"); // processes the string so it is parsable by ncalc

            Expression expr = new Expression(equation); // creates a new ncalc.Expression instance with the above string
            label1.Text = expr.Evaluate().ToString(); // sets label1's text to the output

            isstart = true; // sets the next input to overwrite the text
            isop = true; // irons out a few bugs
        }
    }
}