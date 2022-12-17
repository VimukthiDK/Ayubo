using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayubo
{
    public partial class frmWelcome : Form
    {
        private int timeLeft;



        public frmWelcome()
        {
            InitializeComponent();
        }

        private void lbWelcome_Click(object sender, EventArgs e)
        {

        }

        private void frmWelcome_Shown(object sender, EventArgs e)

        {


        }

        private void pbWelcom_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {

                timeLeft = timeLeft - 1;

            }

            else

            {

                timer1.Stop();

                new frmLogin().Show();

                this.Hide();


            }
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {
            timeLeft = 47; 
             timer1.Start();

        }

        private void pgbWelcome_Click(object sender, EventArgs e)
        {

        }

        private void lbAD_Click(object sender, EventArgs e)
        {

        }
    }
}

