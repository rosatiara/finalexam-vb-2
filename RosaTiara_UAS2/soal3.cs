using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RosaTiara_UAS2
{
    public partial class soal3 : Form
    {
        public soal3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (true)
            {
                MessageBox.Show("Correct!", "YAY", MessageBoxButtons.OK);
            }
            Form soal4 = new soal4();
            soal4.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (true)
            {
                MessageBox.Show("Incorrect", "OOPS", MessageBoxButtons.OK);
            }
            Form soal4 = new soal4();
            soal4.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Be careful. This is tricky.", "HINT");
        }
    }
}
