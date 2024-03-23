using DropboxKku;
using Lab_2._2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KKuSeeId
{
    public partial class calculator : Form
    {
        double resultVale = 0;
        string operationPerformed = "";
        bool isOperationperformed = false;



        public calculator()
        {
            InitializeComponent();
        }

        private void home_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            news f2 = new news();
            f2.Show();
        }

        private void express_Click(object sender, EventArgs e)
        {
            Espress f2 = new Espress();
            f2.Show();
        }

        private void webpage_Click(object sender, EventArgs e)
        {
            kkureg f2 = new kkureg();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            smartnkc f2 = new smartnkc();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            profiles f2 = new profiles();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calculator f2 = new calculator();
            f2.Show();
        }

        private void signout_Click(object sender, EventArgs e)
        {
            login f2 = new login();
            f2.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if (tbDisplayResult.Text == "0" || (isOperationperformed))
                tbDisplayResult.Clear();

            isOperationperformed = false;

            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!tbDisplayResult.Text.Contains("."))
                    tbDisplayResult.Text += button.Text;
            }
            else
            {
                tbDisplayResult.Text += button.Text;
            }
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            operationPerformed = button.Text;
            resultVale = Double.Parse(tbDisplayResult.Text);
            lbCurrentOp.Text = resultVale + " " + operationPerformed;
            isOperationperformed = true;
        }

        private void cc_Click(object sender, EventArgs e)
        {
            tbDisplayResult.Text = "0";
        }

        private void cce_Click(object sender, EventArgs e)
        {
            tbDisplayResult.Text = "0";
            resultVale = 0;
        }

        private void taokub_Click(object sender, EventArgs e)
        {
            if (operationPerformed == "+")
            {
                tbDisplayResult.Text = (resultVale + double.Parse(tbDisplayResult.Text)).ToString();
            }
            else if (operationPerformed == "-")
            {
                tbDisplayResult.Text = (resultVale - double.Parse(tbDisplayResult.Text)).ToString();
            }
            else if (operationPerformed == "X")
            {
                tbDisplayResult.Text = (resultVale * double.Parse(tbDisplayResult.Text)).ToString();
            }
            else
            {
                tbDisplayResult.Text = (resultVale / double.Parse(tbDisplayResult.Text)).ToString();
            }
        }

        private void cdell_Click(object sender, EventArgs e)
        {
            if (tbDisplayResult.Text.Length > 0)
                tbDisplayResult.Text = tbDisplayResult.Text.Remove(tbDisplayResult.TextLength - 1, 1);
            if (tbDisplayResult.Text == "")
                tbDisplayResult.Text = "0";
        }

        private void todniyom_Click(object sender, EventArgs e)
        {
            if (tbDisplayResult.Text == "0" || (isOperationperformed))
                tbDisplayResult.Clear();

            isOperationperformed = false;

            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!tbDisplayResult.Text.Contains("."))
                    tbDisplayResult.Text += button.Text;
            }
            else
            {
                tbDisplayResult.Text += button.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            note.Text = " ";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            grade f2 = new grade();
            f2.Show();
        }
    }
}
