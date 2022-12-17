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

    public partial class CustomerDetails : Form
    {
        SqlConnection con = new SqlConnection("Server= localhost; Database= AyuboDriveDatabase;Integrated Security = SSPI;");

        string po = null;


        public CustomerDetails()
        {
            InitializeComponent();
        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {
            btnCancel_Click(btnCancel, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                po = "Update";
                btnUpdate.Enabled = false;
                btnNew.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;

                rbtUName.Enabled = false;
                rbtNIC.Enabled = false;


                txtName.Enabled = true;
                txtNic.Enabled = false;
                txtCN.Enabled = true;
                txtAddress.Enabled = true;
                txtSearch.Enabled = false;
                txtName.Focus();


            }
            catch (Exception)
            {

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                po = "New";
                btnNew.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;

                rbtUName.Enabled = false;
                rbtNIC.Enabled = false;

                txtName.Enabled = true;
                txtNic.Enabled = true;
                txtCN.Enabled = true;
                txtAddress.Enabled = true;
                 txtSearch.Enabled = false;

                txtName.Text = "";
                txtNic.Text = "";
                txtAddress.Text = "";
                txtCN.Text = "";
                txtSearch.Text = "";

                txtNic.Focus();

            }
            catch (Exception)
            {

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                try
                {
                    DialogResult re =  MessageBox.Show("Do You Want Delete This Record...!", "Ayubo Car Rent System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        
                    if (re == DialogResult.Yes )
                    {

                        SqlCommand cmd;
                        string x;

                        x = "delete from CustomerDetails where NIC ='" + (txtNic.Text).ToString() + "'";
                        cmd = new SqlCommand(x, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Delete Succesful...!");

                    }
                    else
                    {

                        MessageBox.Show("Data Delete Not succesful...!");

                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("Data Delete Not Succesful...!");

                }

                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Database not  connected...!");

            }

            btnCancel_Click(btnCancel, e);

            txtName.Focus();


        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if ((txtNic.Text).Trim() == "")
            {
                MessageBox.Show("Please Enter  Your NIC..!");
                txtName.Focus();
            }
            else if ((txtName.Text).Trim() == "")
            {
                MessageBox.Show("Please Enter Your Name..!");
                txtName.Focus();
            }

            else if ((txtCN.Text).Trim() == "")
            {
                MessageBox.Show("Please Enter Contact Number..!");
                txtCN.Focus();
            }
            else if ((txtAddress.Text).Trim() == "")
            {
                MessageBox.Show("Please Enter Address..!");
                txtAddress.Focus();
            }

            else
            {
                try
                {

                    con.Open();
                    try
                    {
                        SqlCommand cmd;
                        string x;
                        if (po == "New")
                        {
                            x = "insert into CustomerDetails values('" + (txtNic.Text).ToString() + "','" + (txtName.Text).ToString() + "','" + (txtCN.Text).ToString() + "','" + (txtAddress.Text).Trim() + "');";
                        }
                        else
                        {
                            x = "update CustomerDetails set Name ='" + (txtName.Text).Trim () + "',ContactNumber='" + (txtCN.Text).Trim () + "',Address = '" + (txtAddress.Text).Trim () + "' where NIC ='" + (txtNic.Text).Trim () + "'";
                        }

                        MessageBox.Show("Data Saved / Updated ! ");
                        cmd = new SqlCommand(x, con);
                        cmd.ExecuteNonQuery();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Data Insert Or  Update Error...!"+ ex.ToString ());
                    }

                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Database not  connected...!");

                }

                btnCancel_Click(btnCancel, e);

            }


        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                po = null;
                btnNew.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;

                rbtUName.Enabled = true;
                rbtNIC.Enabled = true;

                txtName.Enabled = false;
                txtNic.Enabled = false;
                txtCN.Enabled = false;
                txtAddress.Enabled = false;
                txtSearch.Enabled = true;

                txtName.Text = "";
                txtNic.Text = "";
                txtCN.Text = "";
                txtAddress.Text = "";
                txtSearch.Text = "";

                txtSearch_TextChanged(txtSearch, e);

                txtSearch.Focus();

            }
            catch (Exception)
            {

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
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
                    if (rbtNIC.Checked == true)
                    {
                        x = "select * from CustomerDetails where NIC like '" + (txtSearch.Text).Trim() + "%'";

                    }
                    else if (rbtUName.Checked == true)
                    {
                        x = "select * from CustomerDetails where Name like '" + (txtSearch.Text).Trim() + "%'";

                    }
                    
                    else
                    {
                        x = "select * from Customer_Details";

                    }

                    cmd = new SqlCommand(x, con);
                    da.SelectCommand = cmd;
                    da.Fill(ds, "ARC");
                    dgvCustomer.DataSource = ds.Tables["ARC"];
                    dgvCustomer.Refresh();



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


        private void rbtNic_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void txtNic_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void rbtnName_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvCustomer_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dgvCustomer.Refresh();
                txtNic.Text = dgvCustomer.SelectedRows[0].Cells[0].Value.ToString();
                txtName.Text = dgvCustomer.SelectedRows[0].Cells[1].Value.ToString();
                txtCN.Text = dgvCustomer.SelectedRows[0].Cells[2].Value.ToString();
                txtAddress.Text = dgvCustomer.SelectedRows[0].Cells[3].Value.ToString();
               

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }

        private void dgvCustomer_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void CustomerDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                frmRentBooking a = new frmRentBooking();
            }
            catch
            {

            }
        }
    }
}

