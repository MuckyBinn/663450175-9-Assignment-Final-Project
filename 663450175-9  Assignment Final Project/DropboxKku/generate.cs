using DropboxKku;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KKuSeeId
{
    public partial class generate : Form
    {
        int seconds = 0;
        int seconds2 = 0;
        public generate()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void signout_Click(object sender, EventArgs e)
        {
            login f2 = new login();
            f2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int len = 8;
            const string Validchar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder result = new StringBuilder();
            Random random = new Random();
            while (0 < len--)
            {
                result.Append(Validchar[random.Next(Validchar.Length)]);

            }
            nss.Text = result.ToString();

            seconds = 300;
            countdownTimer1.Start();

        }

        private void nspd_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int len = 8;
            const string Validchar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder result = new StringBuilder();
            Random random = new Random();
            while (0 < len--)
            {
                result.Append(Validchar[random.Next(Validchar.Length)]);

            }
            nspd.Text = result.ToString();

            seconds2 = 300;
            countdownTimer2.Start();
        }

        private void countdownTimer1_Tick(object sender, EventArgs e)
        {
            lblScreen1.Text = seconds--.ToString();
            if (seconds < 0)
                countdownTimer1.Stop();
        }

        private void nss_TextChanged(object sender, EventArgs e)
        {

        }

        private void countdownTimer2_Tick(object sender, EventArgs e)
        {
            s2.Text = seconds2--.ToString();
            if (seconds2 < 0)
                countdownTimer2.Stop();
        }

        private void home_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void calculator_Click(object sender, EventArgs e)
        {
            profiles f2 = new profiles();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calculator f2 = new calculator();
            f2.Show();

        }

        private void confirm_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
