﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyHelper
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal venitlunar = decimal.Parse(textBox1.Text);
            decimal cheltuielilunare = decimal.Parse(textBox2.Text);
            decimal ramaslunar = venitlunar - cheltuielilunare;

            int bugetdorit =int.Parse(textBox3.Text);
            decimal luni = bugetdorit / ramaslunar;
            decimal luniarpox = Math.Round(luni, MidpointRounding.AwayFromZero);
            output.Text = $"Bugetul dorit de {bugetdorit} il puteti obtineti in {luniarpox} luni ";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
