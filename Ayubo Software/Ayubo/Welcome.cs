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
    public partial class Welcome : Form
    {
        private int timeLeft;
        public Welcome()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void CustomerLogin_Load(object sender, EventArgs e)
        {

            timeLeft = 47;
            timer1.Start();

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

                new CustomerBooking().Show();

                this.Hide();


            }
        }
    }
}
