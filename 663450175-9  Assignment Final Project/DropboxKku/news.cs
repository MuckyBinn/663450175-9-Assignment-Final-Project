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
    public partial class news : Form
    {
        public news()
        {
            InitializeComponent();
        }

        private void homed_Click(object sender, EventArgs e)
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

        private void signout_Click(object sender, EventArgs e)
        {
            login f2 = new login();
            f2.Show();
        }
    }
}
