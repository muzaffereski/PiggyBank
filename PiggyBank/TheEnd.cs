﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiggyBank
{
    public partial class TheEnd : Form
    {
        public string totalmmm { get; set; }
        public TheEnd()
        {
            InitializeComponent();
        }

        private void TheEnd_Load(object sender, EventArgs e)
        {
            lbltotalMoneylast.Text = totalmmm;
        }
    }
}
