using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comp1004_lab1
{
    public partial class LehelGuitarsForm : Form
    {
        public LehelGuitarsForm()
        {
            InitializeComponent();
        }

        private void LehelGuitarsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
