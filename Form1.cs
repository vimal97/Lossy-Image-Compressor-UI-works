using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace imgcom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox1.Image = null;
            OpenFileDialog ofile = new OpenFileDialog();
            ofile.Filter = "Image file (*.bmp,*.jpg)|*.bmp;*.jpg";
            if (DialogResult.OK == ofile.ShowDialog())
            {
                this.pictureBox1.Image = new Bitmap(ofile.FileName);
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox2.Image = null;
                pictureBox3.Visible = true;
                pictureBox3.Image = null;
                label1.Visible = true;
                label2.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap b1 = new Bitmap(this.pictureBox1.Image);
            //Bitmap b2 = b1;
            Bitmap b3=new Bitmap(b1.Width,b1.Height);
            int x = 0;
            int y = 0;
            //int count = 0;
            for (int i = 0; i < b3.Height; i++)             //for b3 black
            {                                               //for b3 black
                for (int j = 0; j < b3.Width; j++)          //for b3 black
                {                                           //for b3 black
                    b3.SetPixel(j, i, Color.White);
                   //for b3 black
                }                                           //for b3 black
            }
            int mod1 = int.Parse(textBox1.Text);//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            int mod2 = int.Parse(textBox2.Text);//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < b1.Height; i++,y++)
            {
                x = 0;
                for (int j = 0; j < b1.Width; j++)
                {
                    if(j%mod1==0)
                    {
                        Color c=b1.GetPixel(j,i);
                        b3.SetPixel(x,y,c);
                        x = x + 1;
                    }

                }

            }

            int nw = b3.Width / mod1;
            int nh = b3.Height / mod2;
            Bitmap o_img = new Bitmap(nw,b3.Height);
           
            for (int i = 0; i < b3.Height; i++)
            {
                for (int j = 0; j < nw; j++)
                {
                    Color c1 = b3.GetPixel(j, i);
                    o_img.SetPixel(j, i, c1);
                }
            }
            Bitmap b4 = new Bitmap(o_img.Width,o_img.Height);
            for (int i = 0; i < o_img.Height; i++)             //for b4 black
            {                                               //for b4 black
                for (int j = 0; j < o_img.Width; j++)          //for b4 black
                {                                           //for b4 black
                    b4.SetPixel(j, i, Color.White);
                                                            //for b4 black
                }                                           //for b4 black
            }
            x = 0;
            for (int i = 0; i < o_img.Width; i++, x++)
            {
                y = 0;
                for (int j = 0; j < o_img.Height; j++)
                {
                    if (j % mod2 == 0)
                    {
                        Color c = o_img.GetPixel(i, j);
                        b4.SetPixel(x, y, c);
                        y = y + 1;
                    }

                }

            }
            Bitmap out_img = new Bitmap(nw, nh);

            for (int i = 0; i < nh; i++)
            {
                for (int j = 0; j < nw; j++)
                {
                    Color c1 = b4.GetPixel(j, i);
                    out_img.SetPixel(j, i, c1);
                }
            }
            this.pictureBox2.Image = out_img;
      }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(this.pictureBox2.Image);
           
            int mod1 = int.Parse(textBox1.Text);/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            int mod2 = int.Parse(textBox2.Text);/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Bitmap d_img = new Bitmap((b.Width) * mod1, b.Height);
            int x = 0;
            int count = 0;
            for (int i = 0; i < b.Height; i++)              //for geting pixel from b
            {
                
                count = 0;
                for (int j = 0; j < b.Width; j++)           //for geting pixel from b
                {
                    
                    Color c = b.GetPixel(j, i);
                    
                        for (x = 0; x < mod1; x++)
                        {
                            d_img.SetPixel(count,i,c);
                            count=count+1;
                        }
                    }
            }
            pictureBox3.Visible = true;
            Bitmap out_img = new Bitmap((b.Width) * mod1,(b.Height) * mod2);
            x = 0;
            count = 0;
            for (int i = 0; i < d_img.Width; i++)              //for geting pixel from b
            {

                count = 0;
                for (int j = 0; j < d_img.Height; j++)           //for geting pixel from b
                {

                    Color c = d_img.GetPixel(i, j);

                    for (x = 0; x < mod2; x++)
                    {
                        out_img.SetPixel(i,count, c);
                        count = count + 1;
                    }
                }
            }
            pictureBox3.Image = out_img;
            
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ISTO_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Bitmap b3 = new Bitmap(this.pictureBox2.Image);
            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "JPG(*.JPG)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                b3.Save(f.FileName);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Bitmap b3 = new Bitmap(this.pictureBox3.Image);
            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "JPG(*.JPG)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                b3.Save(f.FileName);
            }
        }
      }
    }


            
