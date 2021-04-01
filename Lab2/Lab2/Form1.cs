using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Button> bList = new List<Button>();

            for (int i = 1; i <= 16; i++)
            {
                Button b = new Button();
                bList.Add(b);
                b.Text = i.ToString();
                b.Location = new Point(40 * (i + 2), 40);
                b.Size = new Size(35, 35);
                b.Visible = true;
                if (i > 4 && i < 9)
                {
                    b.Location = new Point(40 * (i + 2) - 160, 80);
                }
                if (i > 8 && i < 13)
                {
                    b.Location = new Point(40 * (i + 2) - 320, 120);
                }
                if (i > 12 && i <= 16)
                {
                    b.Location = new Point(40 * (i + 2) - 480, 160);
                }

                tabPage2.Controls.Add(b);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.comboBox1.Items.Add(textBox1.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.comboBox1.Items.Remove(textBox1.Text);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {




        }
    }
}

