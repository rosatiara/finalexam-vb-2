using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RosaTiara_UAS2
{
    public partial class soal4 : Form
    {
        public soal4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (true)
            {
                MessageBox.Show("Incorrect", "OOPS", MessageBoxButtons.OK);
            }
            Form soal5 = new soal5();
            soal5.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (true)
            {
                MessageBox.Show("Correct!", "YAY", MessageBoxButtons.OK);
            }
            Form soal5 = new soal5();
            soal5.Show();
            this.Close();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Analytics is the systematic computational analysis of data or statistics. It is used for the discovery, interpretation, and communication of meaningful patterns in data.", "HINT");
        }
    }
}
