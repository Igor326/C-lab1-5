using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Timer t = new Timer();
            t.Interval = 800;
            t.Tick += new EventHandler(t_Tick);
            t.Start();
            t.Stop();


            void t_Tick(object sender, EventArgs e)
            {
                for(int i = 0; i < 8; i++) {
                    this.Text = "";

                    this.Text = " Натисніть кнопку “Ок”!!!";
                    
                }

               
            }
            if (button1.Height == 0)
            {
                
                this.Text = "Кнопка “Ок” не може бути натиснута";
            }
            
          

        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            button1.Left = r.Next(0, this.Size.Width - button1.Width);
            button1.Top = r.Next(0, this.Size.Height - button1.Height);
            this.button1.Height -= 3;
           
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "Кнопка “Ок” була натиснута");
        }
    }
}
