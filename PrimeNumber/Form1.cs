﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeNumber
{
    public partial class PrimeNumberForm : Form
    {
        public PrimeNumberForm()
        {
            InitializeComponent();
        }

        private void CHECKButton_Click(object sender, EventArgs e)
        {
            int result = 0;
            bool isNumber = Int32.TryParse(PrimeNumberTextBox.Text, out result);
            if (isNumber)
            {
                TrueOrFalseLabel.Text = "true";
            }
            else
                TrueOrFalseLabel.Text = "false";
            if (isNumber)
            {
                bool isPrime = true;
                for (int i = 2; i <= result / 2; i++)
                {
                    if (result % i == 0)
                        isPrime = false;
                }
                if (isPrime)
                {
                    this.BackColor = Color.Green;
                }
                else
                {
                    this.BackColor = Color.Red;
                }


            }
            else { MessageBox.Show("nu s a introdus un numar intreg."); }

        }
    }
} 

