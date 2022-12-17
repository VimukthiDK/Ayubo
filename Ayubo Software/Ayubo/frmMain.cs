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
    public partial class frmMain : Form
    {
        private int childFormNumber = 0;

        public frmMain()
        {
            InitializeComponent();
        }


        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerDetails a = new CustomerDetails();
            a.MdiParent = this;
            a.Show();         
            

        }

        private void driverToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DriverDetails d = new DriverDetails();
            d.MdiParent = this;
            d.Show();
            
        }

        private void accessRightsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmAccessRights c = new frmAccessRights();
            c.MdiParent = this;
            c.Show();
            
            
        }

        private void vehicalTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVehicleType v = new frmVehicleType();
            v.MdiParent = this;
            v.Show();
        }

        private void vehicalToolStripMenuItem_Click(object sender, EventArgs e)
        {        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           
        }
        private void frmMain_Closed(object sender, EventArgs e)
        {
             }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmVehical x = new frmVehical();
            x.MdiParent = this;
            x.Show();

        }

        private void rentToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmHireBooking x = new frmHireBooking();
            x.MdiParent = this;
            x.Show();

        }

        private void hireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRentBooking x = new frmRentBooking();
            x.MdiParent = this;
            x.Show();



        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {

            //   frmWelcome fw = new frmWelcome();
            //   fw.Close();

            //  frmLogin fl = new frmLogin();
            //fl.Close();

            frmWelcome fw = new frmWelcome();
            fw.Show();

        }

        private void packagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPackage x = new frmPackage();
            x.MdiParent = this;
            x.Show();

        }
    }
}
