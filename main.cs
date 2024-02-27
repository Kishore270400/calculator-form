using System.Configuration;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Mycalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();


        }


        float data1, data2;
        string operations;





        private void button6_Click(object sender, EventArgs e)
        {
            if (hienthi1.Text == "0")
            {
                hienthi1.Clear();
            }

            hienthi1.Text = hienthi1.Text + "9";






        }

        private void button18_Click(object sender, EventArgs e)
        {
            {
                data2 = float.Parse(hienthi1.Text);
                data2 = data2 * -1;
                hienthi1.Text = data2.ToString();
            }


        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (hienthi1.Text == "0")
            {
                hienthi1.Clear();
            }

            hienthi1.Text = hienthi1.Text + "0";
        }

        private void button20_Click(object sender, EventArgs e)
        {


            hienthi1.Text = hienthi1 + ".";

        }


        private void button17_Click(object sender, EventArgs e)
        {


            if (operations == "cong")
            {
                data2 = data1 + float.Parse(hienthi1.Text);
                hienthi2.Text = data1.ToString() + "+" + float.Parse(hienthi1.Text) + " = ";
                hienthi1.Text = data2.ToString();


            }
            if (operations == "sub")
            {
                data2 = data1 - float.Parse(hienthi1.Text);
                hienthi2.Text = data1.ToString() + "-" + float.Parse(hienthi1.Text) + " = ";
                hienthi1.Text = data2.ToString();

            }
            if (operations == "mul")
            {
                data2 = data1 * float.Parse(hienthi1.Text);
                hienthi2.Text = data1.ToString() + "*" + float.Parse(hienthi1.Text) + " = ";
                hienthi1.Text = data2.ToString();

            }
            if (operations == "div")
            {
                if (double.Parse(hienthi1.Text) == 0)
                {
                    hienthi2.Text = data1.ToString() + "/";
                    hienthi1.Text = "cannot div zero";
                }
                else
                {
                    data2 = data1 / float.Parse(hienthi1.Text);
                    hienthi2.Text = data1.ToString() + "/" + float.Parse(hienthi1.Text) + " = ";
                    hienthi1.Text = data2.ToString();

                }
            }
        }


        private void button13_Click(object sender, EventArgs e)
        {
            operations = "cong";
            hienthi2.Text = data1.ToString() + "+";
            data1 = float.Parse(hienthi1.Text);
            hienthi1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (hienthi1.Text == "0")
            {
                hienthi1.Clear();
            }
            hienthi1.Text = hienthi1.Text + "2";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (hienthi1.Text == "0")
            {
                hienthi1.Clear();
            }

            hienthi1.Text = hienthi1.Text + "1";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            operations = "sub";
            hienthi2.Text = data1.ToString() + " - ";
            data1 = float.Parse(hienthi1.Text);
            hienthi1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (hienthi1.Text == "0")
            {
                hienthi1.Clear();
            }

            hienthi1.Text = hienthi1.Text + "3";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (hienthi1.Text == "0")
            {
                hienthi1.Clear();
            }
            hienthi1.Text = hienthi1.Text + "5";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (hienthi1.Text == "0")
            {
                hienthi1.Clear();
            }
            hienthi1.Text = hienthi1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            operations = "mul";
            hienthi2.Text = data1.ToString() + " * ";
            data1 = float.Parse(hienthi1.Text);
            hienthi1.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (hienthi1.Text == "0")
            {
                hienthi1.Clear();
            }
            hienthi1.Text = hienthi1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (hienthi1.Text == "0")
            {
                hienthi1.Clear();
            }
            hienthi1.Text = hienthi1.Text + "8";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (hienthi1.Text == "0")
            {
                hienthi1.Clear();
            }
            hienthi1.Text = hienthi1.Text + "7";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int index = hienthi1.Text.Length;
            index--;
            hienthi1.Text = hienthi1.Text.Remove(index);
            if (hienthi1.Text == "")
            {
                hienthi1.Text = "0";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            hienthi1.Text = "0";
            hienthi2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hienthi1.Text = "0";
            hienthi2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operations = "div";
            hienthi2.Text = data1.ToString() + " / ";
            data1 = float.Parse(hienthi1.Text);
            hienthi1.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hienthi2_TextChanged(object sender, EventArgs e)
        {
        }

        private void hienthi1_TextChanged(object sender, EventArgs e)
        {




            hienthi1.TextChanged += (sender, e) =>
            {

                if (hienthi1.Text.Length > 15)
                {
                    hienthi1.Text = hienthi1.Text.Substring(0, 15);
                }
            };


            if (System.Text.RegularExpressions.Regex.IsMatch(hienthi1.Text, "[^0.-9]"))
            {


                hienthi1.Text = hienthi1.Text.Remove(hienthi1.Text.Length - 1);
            }




        }

    }
}
