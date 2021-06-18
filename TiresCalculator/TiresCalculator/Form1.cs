using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiresCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OutputOld1.Text = "";
            OutputOld2.Text = "";
            OutputOld3.Text = "";
            OutputOld4.Text = "";

            OutputNew1.Text = "";
            OutputNew2.Text = "";
            OutputNew3.Text = "";
            OutputNew4.Text = "";

            OutputClearance.Text = "";
            OutputSpeed.Text = "";

            List<Size> Size = new List<Size>();
            //List<Size> NewSize = new List<Size>();
            //Creating sizes

            Size.Add(new Size { height = 0,   width = null, diameter = 0      });
            Size.Add(new Size { height = 7,   width = null, diameter = 0.5    });
            Size.Add(new Size { height = 10,  width = null, diameter = 1      });
            Size.Add(new Size { height = 12,  width = null, diameter = 10     });
            Size.Add(new Size { height = 25,  width = null, diameter = 12     });
            Size.Add(new Size { height = 26,  width = null, diameter = 13     });
            Size.Add(new Size { height = 27,  width = null, diameter = 14     });
            Size.Add(new Size { height = 28,  width = null, diameter = 15     });
            Size.Add(new Size { height = 30,  width = null, diameter = 16     });
            Size.Add(new Size { height = 31,  width = null, diameter = 17     });
            Size.Add(new Size { height = 32,  width = null, diameter = 17.5   });
            Size.Add(new Size { height = 33,  width = null, diameter = 18     });
            Size.Add(new Size { height = 35,  width = null, diameter = 19     });
            Size.Add(new Size { height = 37,  width = null, diameter = 19.5   });
            Size.Add(new Size { height = 60,  width = null, diameter = 20     });
            Size.Add(new Size { height = 70,  width = null, diameter = 21     });
            Size.Add(new Size { height = 80,  width = null, diameter = 22     });
            Size.Add(new Size { height = 90,  width = null, diameter = 22.5   });
            Size.Add(new Size { height = 100, width = 0,    diameter = 23     });
            Size.Add(new Size { height = 110, width = 1,    diameter = 24     });
            Size.Add(new Size { height = 120, width = 5,    diameter = 26     });
            Size.Add(new Size { height = 130, width = 8,    diameter = 28     });
            Size.Add(new Size { height = 135, width = 9,    diameter = 30     });
            Size.Add(new Size { height = 140, width = 9.5,  diameter = 40     });
            Size.Add(new Size { height = 145, width = 10,   diameter = 50     });
            Size.Add(new Size { height = 150, width = 10.5, diameter = 55     });
            Size.Add(new Size { height = 155, width = 11,   diameter = 60     });
            Size.Add(new Size { height = 160, width = 11.5, diameter = 65     });
            Size.Add(new Size { height = 165, width = 12,   diameter = 70     });
            Size.Add(new Size { height = 170, width = 12.5, diameter = 75     });
            Size.Add(new Size { height = 175, width = 25,   diameter = 80     });
            Size.Add(new Size { height = 180, width = 30,   diameter = 155    });
            Size.Add(new Size { height = 185, width = 35,   diameter = 165    });
            Size.Add(new Size { height = 190, width = 40,   diameter = 175    });
            Size.Add(new Size { height = 195, width = 45,   diameter = 195    });
            Size.Add(new Size { height = 200, width = 50,   diameter = 205    });
            Size.Add(new Size { height = 205, width = 55,   diameter = 215    });
            Size.Add(new Size { height = 215, width = 60,   diameter = 225    });
            Size.Add(new Size { height = 225, width = 65,   diameter = 235    });
            Size.Add(new Size { height = 235, width = 70,   diameter = 245    });
            Size.Add(new Size { height = 240, width = 75,   diameter = 255    });
            Size.Add(new Size { height = 245, width = 80,   diameter = 265    });
            Size.Add(new Size { height = 250, width = 85,   diameter = 285    });
            Size.Add(new Size { height = 255, width = 90,   diameter = 470    });
            Size.Add(new Size { height = 265, width = 95,   diameter = 490    });
            Size.Add(new Size { height = 275, width = 100,  diameter = 44333  });
            Size.Add(new Size { height = 285, width = 205,  diameter = 44335  });
            Size.Add(new Size { height = 295, width = 215,  diameter = 44338  });
            Size.Add(new Size { height = 305, width = 225,  diameter = null   });
            Size.Add(new Size { height = 315, width = 235,  diameter = null   });
            Size.Add(new Size { height = 325, width = 245,  diameter = null   });
            Size.Add(new Size { height = 335, width = 265,  diameter = null   });
            Size.Add(new Size { height = 345, width = 275,  diameter = null   });
            Size.Add(new Size { height = 355, width = 285,  diameter = null   });
            Size.Add(new Size { height = 385, width = 295,  diameter = null   });
            Size.Add(new Size { height = 420, width = 315,  diameter = null   });
            Size.Add(new Size { height = 425, width = 385,  diameter = null   });
            Size.Add(new Size { height = 435, width = 435,  diameter = null   });
            Size.Add(new Size { height = 440, width = 445,  diameter = null   });
            Size.Add(new Size { height = 445, width = 455,  diameter = null   });
            Size.Add(new Size { height = 455, width = 700,  diameter = null   });
            Size.Add(new Size { height = 480, width = 710,  diameter = null   });




            



            //Adding options into lists

            for (int i = 0; i < Size.Count; i++)
            {
                if(Size[i].height!= null)
                    OldFirstValue.Items.Add(Size[i].height);
                if (Size[i].width != null)
                    OldSecondValue.Items.Add(Size[i].width);
                if (Size[i].diameter != null)
                    OldThirdValue.Items.Add(Size[i].diameter);
            }

            for (int i = 0; i < Size.Count; i++)
            {
                if (Size[i].height != null)
                    NewFirstValue.Items.Add(Size[i].height);
                if (Size[i].width != null)
                    NewSecondValue.Items.Add(Size[i].width);
                if (Size[i].diameter != null)
                    NewThirdValue.Items.Add(Size[i].diameter);
            }
            button1.Click += delegate
            {
                double A, B, C1=0,C2=0, D, Clearance=0;
                if (OldFirstValue.Text!= ""&& OldSecondValue.Text != ""&&OldThirdValue.Text != ""||
                    NewFirstValue.Text != "" && NewSecondValue.Text != "" && NewThirdValue.Text != "")
                {
                    if(OldFirstValue.Text != "")
                    {

                        D = Math.Round((float.Parse(OldFirstValue.Text) / 10), 1);
                        OutputOld4.Text = D + "cm";
                        C1 = Math.Round((D * (float.Parse(OldSecondValue.Text) / 10) / 10), 1);
                        OutputOld3.Text = C1 + "cm";
                        B = Math.Round((float.Parse(OldThirdValue.Text) * 2.54), 1);
                        OutputOld2.Text = B + "cm";
                        A = Math.Round((B + (2 * C1)), 1);
                        OutputOld1.Text = A + "cm";
                    }
                    if (NewFirstValue.Text != "")
                    {

                        D = Math.Round((float.Parse(NewFirstValue.Text) / 10), 1);
                        OutputNew4.Text = D + "cm";
                        C2 = Math.Round((D * (float.Parse(NewSecondValue.Text) / 10) / 10), 1);
                        OutputNew3.Text = C2 + "cm";
                        B = Math.Round( ( float.Parse(NewThirdValue.Text) * 2.54), 1 );
                        OutputNew2.Text = B + "cm";
                        A = Math.Round((B + (2 * C2)), 1);
                        OutputNew1.Text = A + "cm";
                       
                    }
                    if (OldFirstValue.Text != "" && NewFirstValue.Text != "")
                    {

                        Clearance = Math.Round((C2 - C1), 1);

                        if (Clearance > 0)
                        OutputClearance.Text = "+"+ Clearance+"cm";
                        
                        if(Clearance < 0)
                        OutputClearance.Text =Clearance + "cm";

                    }
                }
                else
                {
                    MessageBox.Show("Не всі поля були заповнені");
                }

               

            };

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NewSecondValue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OldSecondValue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NewThirdValue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
