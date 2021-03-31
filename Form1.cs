using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Degree : Form
    {
        string opr;
        double num1, num2;
        int n;
        public Degree()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {
            t1.Text += "1";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            t1.Text += "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            t1.Text += "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            t1.Text += "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            t1.Text += "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            t1.Text += "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            t1.Text += "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            t1.Text += "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            t1.Text += "9";
        }

        private void b0_Click(object sender, EventArgs e)
        {
            t1.Text += "0";
        }

        private void bCE_Click(object sender, EventArgs e)
        {
            t1.Text = string.Empty;
        }

        private void bAC_Click(object sender, EventArgs e)
        {
            t1.Enabled = true;
            t1.Text = "0";
            b1.Enabled = true;
            b2.Enabled = true;
            b3.Enabled = true;
            b4.Enabled = true;
            b5.Enabled = true;
            b6.Enabled = true;
            b7.Enabled = true;
            b8.Enabled = true;
            b9.Enabled = true;
            b0.Enabled = true;
            bequals.Enabled = true;
        }

        private void bdot_Click(object sender, EventArgs e)
        {
            if (t1.Text.Contains("."))
            {
                t1.Text = t1.Text;
            }
            else
            {
                t1.Text = t1.Text +  ".";
            }
        }

        private void bdiv_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(t1.Text);
            opr = "/";
            t1.Clear();
            n = 1;
        }

        private void bmul_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(t1.Text);
            opr = "*";
            t1.Clear();
            n = 2;
        }

        private void badd_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(t1.Text);
            opr = "+";
            t1.Clear();
            n = 3;
        }

        private void bsub_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(t1.Text);
            opr = "-";
            t1.Clear();
            n = 4;
        }

        private void bPM_Click(object sender, EventArgs e)
        {
            if (t1.Text.Contains("-"))
            {
                t1.Text = t1.Text.Remove(0, 1);
            }
            else
            {
                t1.Text = "-" + t1.Text;
            }


        }

        private void bmod_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(t1.Text);
            opr = "%";
            t1.Clear();
            n = 5;
        }

        private void bpr_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(t1.Text);
            t1.Clear();
            n = 6;
        }

        private void bcr_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(t1.Text);
            t1.Clear();
            n = 7;
        }

        private void bpow_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(t1.Text);
            opr = "^";
            t1.Clear();
            n = 8;
        }

        private void bequals_Click(object sender, EventArgs e)
        {
            if (n == 1)
            {
                num2 = Convert.ToDouble(t1.Text);
                if (t1.Text == "0")
                  {
                    t1.Text = "infinity";
                }
                else
                {
                    t1.Text = Convert.ToString(Convert.ToDouble(num1) / Convert.ToDouble(num2));
                }
            }
            else if (n == 2)
            {
                num2 = Convert.ToDouble(t1.Text);
                t1.Text = Convert.ToString(num1*num2);
            }
            else if (n == 3)
            {
                num2 = Convert.ToDouble(t1.Text);
                t1.Text = Convert.ToString(num1 + num2);
            }
            else if (n == 4)
            {
                num2 = Convert.ToDouble(t1.Text);
                t1.Text = Convert.ToString(num1 - num2);
            }
            else if(n == 5)
            { 
                num2 = Convert.ToDouble(t1.Text);
                t1.Text = Convert.ToString(num1 % num2);
            }
            else if (n == 6)
            {
                int varx, vary;
                num2 = Convert.ToDouble(t1.Text);
                varx = factorial(Convert.ToInt32(num1));
                vary = factorial(Convert.ToInt32(num1) - Convert.ToInt32(num2));
                t1.Text = Convert.ToString(varx / vary);
            }
            else if (n == 7)
            {
                num2 = Convert.ToDouble(t1.Text);
                int varb, varc, vard;
                varb = factorial(Convert.ToInt32(num1));
                varc = factorial(Convert.ToInt32(num1) - Convert.ToInt32(num2));
                vard = factorial(Convert.ToInt32(num2));
                t1.Text = Convert.ToString(varb / (varc*vard));
            }
            else if (n == 8)
            {
                num2 = Convert.ToDouble(t1.Text);
                t1.Text = Convert.ToString(System.Math.Pow(Convert.ToDouble(num1), Convert.ToDouble(num2)));
            }

        }
        private int factorial(int x)
        {
            int i = 1;
            for (int s = 1; i <= x; i++)
            {
                i = i * s;
            }
            return i;
        }

        private void boff_Click(object sender, EventArgs e)
        {
            t1.Enabled = false;
            t1.Text = "";
            b1.Enabled = false;
            b2.Enabled = false;
            b3.Enabled = false;
            b4.Enabled = false;
            b5.Enabled = false;
            b6.Enabled = false;
            b7.Enabled = false;
            b8.Enabled = false;
            b9.Enabled = false;
            b0.Enabled = false;
            bequals.Enabled = false;

        }

        private void bDEL_Click(object sender, EventArgs e)
        {
            string str = t1.Text;
            int a = str.Length;
            t1.Text = (str.Substring(0, a - 1));
        }

        private void bSquare_Click(object sender, EventArgs e)
        {
            t1.Text = Convert.ToString(Convert.ToDouble(t1.Text) * Convert.ToDouble(t1.Text));
        }

        private void button27_Click(object sender, EventArgs e)
        {    
            t1.Text= Convert.ToString(Convert.ToDouble(t1.Text) * Convert.ToDouble(t1.Text)*Convert.ToDouble(t1.Text));
        }

        private void bFact_Click(object sender, EventArgs e)
        {
            double fact=1;
            double j=Convert.ToDouble(t1.Text);
            for (int i = 1; i <= j; i++)
            {
                fact = fact * i;
            }
            t1.Text = Convert.ToString(fact);

        }

        private void bexp_Click(object sender, EventArgs e)
        {
            double var = Convert.ToDouble(t1.Text);
            double res = Math.Exp(var);
            t1.Text = Convert.ToString(res);
        }

        private void bsqroot_Click(object sender, EventArgs e)
        {
            double var = Convert.ToDouble(t1.Text);
            double res = Math.Sqrt(var);
            t1.Text = Convert.ToString(res);
        }

        private void bPi_Click(object sender, EventArgs e)
        {
            double res = Math.PI;
            t1.Text = Convert.ToString(res);
        }

        private void bSin_Click(object sender, EventArgs e)
        { 
            if(radioButton2.Checked == true)
            {
                double a=Convert.ToDouble(t1.Text);
              t1.Text = Convert.ToString(System.Math.Sin(a));
            }
            else
            { 
                t1.Text =Convert.ToString(System.Math.Sin((Convert.ToDouble(System.Math.PI)/180)*(Convert.ToDouble(t1.Text))));
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bCROOT_Click(object sender, EventArgs e)
        {   
            double var = Convert.ToDouble(t1.Text);
            double res = Math.Pow(var, (1.0 / 3.0));
            t1.Text = Convert.ToString(res);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bCOS_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                double a = Convert.ToDouble(t1.Text);
                t1.Text = Convert.ToString(System.Math.Cos(a));
            }
            else
            {
                t1.Text = Convert.ToString(System.Math.Cos((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(t1.Text))));
            }
        }

        private void bLOG_Click(object sender, EventArgs e)
        {
            t1.Text = Convert.ToString(System.Math.Log(Convert.ToDouble(t1.Text)));
        }

        private void bTAN_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                double a = Convert.ToDouble(t1.Text);
                t1.Text = Convert.ToString(System.Math.Tan(a));
            }
            else
            {
                t1.Text = Convert.ToString(System.Math.Tan((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(t1.Text))));
            }
        }

        private void bLOG10_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(t1.Text);
            t1.Text = Convert.ToString(System.Math.Log10(a));
        }

        private void bsinINV_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                t1.Text = Convert.ToString(System.Math.Asin(Convert.ToDouble(t1.Text)));
            }
            else
            {
                t1.Text = Convert.ToString(System.Math.Asin((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(t1.Text))));
            }  
        }

        private void bcosINV_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                t1.Text = Convert.ToString(System.Math.Acos(Convert.ToDouble(t1.Text)));
            }
            else
            {
                t1.Text = Convert.ToString(System.Math.Acos((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(t1.Text))));
            }  
        }
    }
}
