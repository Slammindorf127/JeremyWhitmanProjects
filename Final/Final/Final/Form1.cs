using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int number = 0;
        int line = 0;
        AlgClass go = new AlgClass();
        int[,] fullArray = new int[,] { };
        //Add Button
        private void button1_Click(object sender, EventArgs e)
        {
            fullArray[line, number] = Convert.ToInt32(textBox1.Text);
            number += 1;
            label7.Text = label7.Text + textBox1.Text + ", ";
        }
        //Next Line Button
        private void button2_Click(object sender, EventArgs e)
        {
            line += 1;
            number = 0;
            go.vertex += 1;
            label7.Text = label7.Text + "]" + '\n' + "[";
        }
        //Compute Button
        private void button3_Click(object sender, EventArgs e)
        {
            go.algorithm(fullArray, 0);
        }
        //Reset Button
        private void button4_Click(object sender, EventArgs e)
        {
            number = 0;
            line = 0;
            go.vertex = 0;
            int[,] fullArray = new int[,] { };
            label7.Text = "Your current array:" + '\n' + "[";
        }
        //Create Empty Array Button
        private void button5_Click(object sender, EventArgs e)
        {
            int dimension = Convert.ToInt32(textBox2.Text);
            int[,] fullArray = new int[dimension, dimension];
        }
        //Direct Test Button
        private void button6_Click(object sender, EventArgs e)
        {
            go.vertex = 7;
            int[,] fullArray = new int[,] { {0, 3, 7, 0, 0, 0, 0 }, {3, 0, 0, 5, 0, 0, 1 }, {7, 0, 0, 0, 4, 0, 2 }, {0, 5, 0, 0, 2, 6, 1 }, {0, 0, 4, 2, 0, 10, 0,}, {0, 0, 0, 6, 10, 0, 0 }, {0, 1, 2, 1, 0, 0, 0 } };
            go.algorithm(fullArray, 0);
        }
    }
}


