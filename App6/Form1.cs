using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MystatLoginPage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {


            var point = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };

            comboBox1.Items.AddRange(point);
            comboBox2.Items.AddRange(point);
            comboBox3.Items.AddRange(point);
            comboBox4.Items.AddRange(point);
            comboBox5.Items.AddRange(point);
            comboBox6.Items.AddRange(point);
            comboBox7.Items.AddRange(point);
            comboBox8.Items.AddRange(point);
            comboBox9.Items.AddRange(point);
            comboBox10.Items.AddRange(point);

            var kristal = new string[] { "1", "2", "3", "4", "5"};
            comboBox11.Items.AddRange(kristal);
            comboBox12.Items.AddRange(kristal);
            comboBox13.Items.AddRange(kristal);
            comboBox14.Items.AddRange(kristal);
            comboBox15.Items.AddRange(kristal);

            textBox1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            label26.Visible = false;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            button3.Visible = true;
            button4.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = textBox1.Text;
            textBox1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton4.Checked = true;
            radioButton9.Checked = true;
            radioButton12.Checked = true;
            radioButton15.Checked = true;
            radioButton18.Checked = true;
        }




        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox5.Visible = true;
                groupBox6.Visible = true;
                label26.Text = radioButton2.Text;
                label26.Visible = true;

            }
            else if (radioButton1.Checked)
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox5.Visible = true;
                groupBox6.Visible = true;
                label26.Text = radioButton1.Text;
                label26.Visible = true;

            }
        }


    }
}
