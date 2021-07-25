using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RosaTiara_UAS2
{
    public partial class soal5 : Form
    {
        public soal5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (true)
            {
                MessageBox.Show("Correct!", "YAY", MessageBoxButtons.OK);
            }
            Form thankyou = new thankyou();
            thankyou.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (true)
            {
                MessageBox.Show("Incorrect", "OOPS", MessageBoxButtons.OK);
            }
            Form thankyou = new thankyou();
            thankyou.Show();
            this.Close();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This university was founded in 1885 and is located in California", "HINT");
        }
    }
}
