﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2
{
    public partial class FCompte : Form
    {
        public FCompte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Compte cp = new Compte(Txtnumcompte.Text, Txttitulaire.Text, Convert.ToDouble(Txtsolde.Text));
            this.Close();
        }
    }
}
