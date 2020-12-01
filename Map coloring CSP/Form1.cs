using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Map_coloring_CSP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                {
                    if (int.Parse(textBox1.Text) > int.Parse(textBox2.Text) && textBox2.Text != textBox3.Text && textBox1.Text != textBox3.Text)
                    {
                        pictureBox1.BackColor = Color.Red;
                        pictureBox2.BackColor = Color.Green;
                        pictureBox3.BackColor = Color.Red;
                        pictureBox4.BackColor = Color.Blue;
                        pictureBox5.BackColor = Color.Green;
                        pictureBox6.BackColor = Color.Red;

                        label1.Text = "Accepted !";
                        label1.ForeColor = Color.Green;
                        label1.Visible = true;
                    }
                    else
                    {
                        label1.Text = "Not Accepted !";
                        label1.ForeColor = Color.Red;
                        label1.Visible = true;

                        pictureBox1.BackColor = Color.White;
                        pictureBox2.BackColor = Color.White;
                        pictureBox3.BackColor = Color.White;
                        pictureBox4.BackColor = Color.White;
                        pictureBox5.BackColor = Color.White;
                        pictureBox6.BackColor = Color.White;
                    }


                }
                else
                {
                    MessageBox.Show("You can't leave any fields empty !", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label1.Text = "";
            label1.ForeColor = Color.Black;
            label1.Text = "";
            label1.Visible = false;
            pictureBox1.BackColor = Color.White;
            pictureBox2.BackColor = Color.White;
            pictureBox3.BackColor = Color.White;
            pictureBox4.BackColor = Color.White;
            pictureBox5.BackColor = Color.White;
            pictureBox6.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Integer values for V1 must be greater than V2 & V3 mustn't be equal to V1 and V2.", "Algorithm conditions for CSP", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
