﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        static Formula dato = new Formula();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdIMC_Click(object sender, EventArgs e)
        {
            lblResultado.Text = dato.IMC(double.Parse(txtd1.Text), double.Parse(txtd2.Text)).ToString();

            if (double.Parse(lblResultado.Text) < 19)
            {
                pbimg1.Visible = true;
            }
            else
            {
                pbimg1.Visible = false;
            }
            if (double.Parse(lblResultado.Text) < 25)
            {
                pbimg2.Visible = true;
            }
            else
            {
                pbimg2.Visible = false;
            }
            if (double.Parse(lblResultado.Text) < 30)
            {
                pbimg3.Visible = true;
            }
            else
            {
                pbimg3.Visible = false;
            }
            if (double.Parse(lblResultado.Text) > 30)
            {
                pbimg4.Visible = true;
            }
            else
            {
                pbimg4.Visible = false;
            }


        }

        private void lblResultado_Click(object sender, EventArgs e)
        {
           
        }

        private void lblpeso_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Ingrese su peso en libras");
        }

        private void lblaltura_Click(object sender, EventArgs e)
        {

        }

        private void lblaltura_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Ingrese su altura en centímetros");
        }

        private void lblpeso_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pbimg1_Click(object sender, EventArgs e)
        {

        }
    }
}
