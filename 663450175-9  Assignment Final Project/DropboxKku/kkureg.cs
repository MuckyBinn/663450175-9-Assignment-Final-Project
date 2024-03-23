using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using DropboxKku;

namespace KKuSeeId
{
    public partial class kkureg : Form
    {
        public kkureg()
        {
            InitializeComponent();
        }

        private void webpage_Click(object sender, EventArgs e)
        {
            kkureg f2 = new kkureg();
            f2.Show();
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

        private void signout_Click(object sender, EventArgs e)
        {
            login f2 = new login();
            f2.Show();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void view_Click(object sender, EventArgs e)
        {

        }

        private void linkclick_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void view_Click_1(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo("https://reg-mirror.kku.ac.th/")
            {
                UseShellExecute = true
            };

            Process.Start(psi);
        }
    }
}
