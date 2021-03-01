using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCV1
{
    public partial class formCalApp : Form
    {

        /*
         * APP: basic version of the calculator
         * AUTHOR: JOHAN VILLAMIZAR
         * VERSÓN: 1.0
         * WEBSITE: http://www.johanvillamizar.com/
         * GITHUB: https://github.com/johanVillamizarCode
         * */
        double nOne, nTwo;
        string operation;
        public formCalApp()
        {
            InitializeComponent();
        }

        Class.AddClass add = new Class.AddClass();
        Class.SubClass subs = new Class.SubClass();
        Class.MultiClass mult = new Class.MultiClass();
        Class.DivClass div = new Class.DivClass();
        //declaration of the number buttons
        private void btn_Zero_Click(object sender, EventArgs e)
        {
            tbx_DigitalScreen.Text = tbx_DigitalScreen.Text + "0";
        }

        private void btn_One_Click(object sender, EventArgs e)
        {
            tbx_DigitalScreen.Text = tbx_DigitalScreen.Text + "1";
        }

        private void btn_Two_Click(object sender, EventArgs e)
        {
            tbx_DigitalScreen.Text = tbx_DigitalScreen.Text + "2";
        }

        private void btn_Three_Click(object sender, EventArgs e)
        {
            tbx_DigitalScreen.Text = tbx_DigitalScreen.Text + "3";
        }

        private void btn_Four_Click(object sender, EventArgs e)
        {
            tbx_DigitalScreen.Text = tbx_DigitalScreen.Text + "4";
        }

        private void btn_five_Click(object sender, EventArgs e)
        {
            tbx_DigitalScreen.Text = tbx_DigitalScreen.Text + "5";
        }

        private void btn_six_Click(object sender, EventArgs e)
        {
            tbx_DigitalScreen.Text = tbx_DigitalScreen.Text + "6";
        }

        private void btn_seven_Click(object sender, EventArgs e)
        {
            tbx_DigitalScreen.Text = tbx_DigitalScreen.Text + "7";
        }

        private void btn_eigth_Click(object sender, EventArgs e)
        {
            tbx_DigitalScreen.Text = tbx_DigitalScreen.Text + "8";
        }

        private void btn_Nine_Click(object sender, EventArgs e)
        {
            tbx_DigitalScreen.Text = tbx_DigitalScreen.Text + "9";
        }
        //Function of the operator buttons
        private void btn_Addition_Click(object sender, EventArgs e)
        {
            operation = "+";
            nOne = Double.Parse(tbx_DigitalScreen.Text);
            tbx_DigitalScreen.Clear();
        }

        private void btn_Substraction_Click(object sender, EventArgs e)
        {
            operation = "-";
            nOne = Double.Parse(tbx_DigitalScreen.Text);
            tbx_DigitalScreen.Clear();
        }

        private void btn_Multiplication_Click(object sender, EventArgs e)
        {
            operation = "*";
            nOne = Double.Parse(tbx_DigitalScreen.Text);
            tbx_DigitalScreen.Clear();
        }

        private void btn_Division_Click(object sender, EventArgs e)
        {
            operation = "/";
            nOne = Double.Parse(tbx_DigitalScreen.Text);
            tbx_DigitalScreen.Clear();
        }

        private void btn_Result_Click(object sender, EventArgs e)
        {
            nTwo = double.Parse(tbx_DigitalScreen.Text);
            double AddOP;
            double subsOP;
            double multOP;
            double divOP;
            switch (operation)
            {
                case "+":
                    AddOP = add.AdditionOP((nOne), (nTwo));
                    tbx_DigitalScreen.Text = AddOP.ToString();
                    break;
                case "-":
                    subsOP = subs.SubstractionOP((nOne), (nTwo));
                    tbx_DigitalScreen.Text = subsOP.ToString();
                    break;
                case "*":
                    multOP = mult.MultiplicationOP((nOne), (nTwo));
                    tbx_DigitalScreen.Text = multOP.ToString();
                    break;
                case "/":
                    divOP = div.DivitionOP((nOne), (nTwo));
                    tbx_DigitalScreen.Text = divOP.ToString();
                    break;
            }
        }
        //Direct link to the developer's page
        private void linkDeveloper_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkDeveloper.LinkVisited = false;
            System.Diagnostics.Process.Start("http://www.johanvillamizar.com");
        }
        //Reset the calculator
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tbx_DigitalScreen.Text = "";
            operation = "";
            nOne = 0;
            nTwo = 0;
      
        }
    }
}
