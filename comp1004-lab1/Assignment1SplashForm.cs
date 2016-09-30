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
    public partial class Assignment1SplashForm : Form
    {
        public Assignment1SplashForm()
        {
            InitializeComponent();
        }

        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            SplashFormTimer.Enabled = false;
            MailOrder lehelGuitarsForm = new MailOrder();
           

            lehelGuitarsForm.Show();
            this.Hide();
            
        }
    }
}
