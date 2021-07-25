using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RosaTiara_UAS2
{
    public partial class soal2 : Form
    {
        public soal2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (true)
            {
                MessageBox.Show("Correct!", "YAY", MessageBoxButtons.OK);
            }
            Form soal3 = new soal3();
            soal3.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (true)
            {
                MessageBox.Show("Incorrect", "OOPS", MessageBoxButtons.OK);
            }
            Form soal3 = new soal3();
            soal3.Show();
            this.Close();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("They both are computer scientist, business magnate, and entrepeneur. One of them was born in Michigan and another is from Soviet Union.", "HINT");
        }
    }
}
