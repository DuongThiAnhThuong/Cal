﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTCONG_Click(object sender, EventArgs e)
        {

            if (TXTA.Text != String.Empty && TXTB.Text != String.Empty)

            {
                double soA = double.Parse(TXTA.Text);
                double sob = double.Parse(TXTB.Text);
                double c = soA + sob;
                txtKQ.Text = c.ToString();
            }

        }

        private void btTru_Click(object sender, EventArgs e)
        {
            double soA = double.Parse(TXTA.Text);
            double sob = double.Parse(TXTB.Text);
            double c = soA - sob;
            txtKQ.Text = c.ToString();

        }
    }
}
