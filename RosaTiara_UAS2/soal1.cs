using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RosaTiara_UAS2
{
    public partial class soal1 : Form
    {
        public static soal1 instance;
        public Label lblright;
        public soal1()
        {
            InitializeComponent();
           
        }

        private void soal1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (true)
            {
                MessageBox.Show("Incorrect", "OOPS", MessageBoxButtons.OK);
            }
            Form soal2 = new soal2();
            soal2.Show();
            this.Close();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (true)
            {
                MessageBox.Show("Correct!", "YAY", MessageBoxButtons.OK);
            }
            Form soal2 = new soal2();
            soal2.Show();
            this.Close();

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are 23 years old now if you were born in this year.", "HINT");
        }
    }
}
