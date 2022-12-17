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
    public partial class DriverDetails : Form
    {
        SqlConnection con = new SqlConnection("Server= localhost; Database= AyuboDriveDatabase;Integrated Security = SSPI;");

        string po = null;
        public DriverDetails()
        {
            InitializeComponent();
        }

        private void DriverDeatails_Load(object sender, EventArgs e)
        {
            btnCancel_Click(btnCancel, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {

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

                rbtCName.Enabled = false;
                rbtNic.Enabled = false;
                rbtTel.Enabled = false;

                txtName.Enabled = true;
                txtNic.Enabled = true;
                txtCN .Enabled = true;
                txtAddress .Enabled = true;
                txtSearch.Enabled = false;

                txtName.Text = "";
                txtNic.Text = "";
                txtCN.Text = "";
                txtAddress.Text = "";
                txtSearch.Text = "";

                txtNic.Focus();

            }
            catch (Exception)
            {

            }



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

                rbtCName.Enabled = false;
                rbtNic.Enabled = false;
                rbtTel.Enabled = false;


                txtName.Enabled = true;
                txtNic.Enabled = false ;
                txtCN.Enabled = true;
                txtAddress.Enabled = true;
                txtSearch.Enabled = false;


            }
            catch (Exception)
            {

            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((txtNic .Text).Trim() == "")
            {
                MessageBox.Show("Please Enter NIC..!");
                txtNic .Focus();
            }


            else if ((txtName.Text).Trim() == "")
            {
                MessageBox.Show("Please Enter  Name..!");
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
                            x = "insert into DriverDetails values('" + (txtNic.Text).Trim().ToString() + "', '" + (txtName.Text).Trim().ToString() + "','" + (txtAddress.Text).Trim().ToString() + "','" + (txtCN.Text).Trim().ToString() + "');";
                        }
                        else
                        {
                            x = "update DriverDetails set Name ='" + (txtName.Text).ToString() + "',Contac_Number = '" + txtCN.Text + "',Address = '" + txtAddress.Text + "' where NIC ='" + (txtNic .Text ).Trim ().ToString () + "';";
                        }

                        cmd = new SqlCommand(x, con);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data Saved / Updated ! ");


                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Data Insert Or  Update Error...!");
                    }


                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database not  connected...!");

                }
         

            btnCancel_Click(btnCancel, e);
        }






    }

    private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                try
                {
                    DialogResult re = MessageBox.Show("Do You Want Delete This Record...!", "Ayubo Car Rent System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (re == DialogResult.Yes)
                    {
                        SqlCommand cmd;
                        string x;

                        x = "delete from DriverDetails where NIC ='" + (txtNic.Text).ToString() + "'";
                        cmd = new SqlCommand(x, con);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data Delete Succesful...!");

                    }
                    else
                    {
                        MessageBox.Show("Data Delete Not Succesful...!");

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {

                btnNew.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;

                txtSearch.Enabled = true;
                rbtNic.Enabled = true;
                rbtCName.Enabled = true;
                rbtTel.Enabled = true;

                txtNic.Enabled = false;
                txtName.Enabled = false;
                txtAddress.Enabled = false;
                txtCN.Enabled = false;
                

                txtAddress.Text = "";
                txtCN .Text = "";
                txtName .Text = "";
                txtNic.Text = "";

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
                    if (rbtNic.Checked == true)
                    {
                        x = "select * from DriverDetails  where NIC like '" + (txtSearch.Text).Trim() + "%'";

                    }
                    else if (rbtCName.Checked == true)
                    {
                        x = "select * from DriverDetails where Name like '" + (txtSearch.Text).Trim() + "%'";

                    }
                    else if (rbtTel.Checked == true)
                    {
                        x = "select * from DriverDetails where Contac_Number like '" + (txtSearch.Text).Trim() + "%'";

                    }
                    else
                    {
                        x = "select * from DriverDetails";

                    }

                    cmd = new SqlCommand(x, con);
                    da.SelectCommand = cmd;
                    da.Fill(ds, "AR");
                    dgvCustomer .DataSource = ds.Tables["AR"];
                    dgvCustomer .Refresh();



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

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvCustomer_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dgvCustomer.Refresh();
                txtNic.Text = dgvCustomer.SelectedRows[0].Cells[0].Value.ToString();
                txtName.Text = dgvCustomer.SelectedRows[0].Cells[1].Value.ToString();
                txtAddress.Text = dgvCustomer.SelectedRows[0].Cells[2].Value.ToString();
                txtCN.Text = dgvCustomer.SelectedRows[0].Cells[3].Value.ToString();

            }
            catch
            {

            }
          }
    }
}
