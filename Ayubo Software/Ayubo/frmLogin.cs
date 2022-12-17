using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace Ayubo
{
    public partial class frmLogin : Form
    {
        SqlConnection con = new SqlConnection("Server= localhost; Database= AyuboDriveDatabase;Integrated Security = SSPI;");
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           
        }

        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUName.Text = "";
            txtPass.Text = "";
            txtUName.Focus();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                try
                {
                    SqlCommand cmd;
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataSet ds = new DataSet();

                    string x;
                    if (txtUName .Text  == "")
                    {
                        MessageBox.Show("Pleace Enter Username..!");
                        txtUName.Focus();
                    }
                    else if (txtPass .Text =="")
                    {
                        MessageBox.Show("Pleace Enter Password..!");
                        txtPass.Focus();

                    }
                    else
                    {
                        x = "select * from AccessRight where User_Name = '" + (txtUName.Text).Trim() + "' and Password = '" + (txtPass .Text).Trim () + "'";
                        cmd = new SqlCommand(x, con);
                        da.SelectCommand = cmd;
                        da.Fill(ds, "Log");

                        if (ds.Tables ["Log"].Rows .Count > 0)
                        {
                            
                            frmMain fm = new frmMain();
                            fm.Show();
                            
                            txtUName.Text = "";
                            txtPass.Text = "";

                            this.Close();


                        }
                        else
                        {
                            MessageBox.Show("User Name Or Password Incorrect...!");
                        }


                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error...!");
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {


            CustomerBooking x = new CustomerBooking();
            x.Show();
            this.Hide();

        }
    }
}
