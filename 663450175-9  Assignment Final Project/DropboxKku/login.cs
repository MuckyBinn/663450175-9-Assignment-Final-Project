using KKuSeeId;

namespace DropboxKku
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "maiteed.fcalculus@kkumail.com" && txtpassword.Text == "iloveoop")
            {
                new Form2().Show();
                this.Hide();


            }
            else if (txtUsername.Text == "���ͺoop�ش�@kkumail.com" && txtpassword.Text == "���´oop")
            {

                new Form3().Show();
            }

            else if (txtUsername.Text == "1" && txtpassword.Text == "1")
            {

                new Form2().Show();
            }



            else
            {
                MessageBox.Show("���ʷ��س��͡���١��ͧ �ô��Ǩ�ͺ");
                txtUsername.Clear();
                txtpassword.Clear();
                txtUsername.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtpassword.Clear();
            txtUsername.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else if (!checkBox1.Checked)
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
