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
    public partial class frmAccessRights : Form
    {

        SqlConnection con =  new SqlConnection("Server= localhost; Database= AyuboDriveDatabase;Integrated Security = SSPI;");
        String po = null;
         
        public frmAccessRights()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmAccessRights_Load(object sender, EventArgs e)
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

                txtName.Enabled = false;
                txtPass.Enabled = true;
                txtCon.Enabled = true;
                cmbType.Enabled = true;
                txtNic.Enabled = false;
                txtSearch.Enabled = false;


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

                rbtnName.Enabled = false;
                rbtnNIC.Enabled = false;

                txtName.Enabled = true;
                txtPass.Enabled = true;
                txtCon.Enabled = true;
                cmbType.Enabled = true;
                txtNic.Enabled = true;
                txtSearch.Enabled = false;

                txtName.Text = "";
                txtPass.Text = "";
                txtCon.Text = "";
                txtNic.Text = "";
                cmbType.Text = "";
                txtSearch.Text = "";

                txtName.Focus();

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
                    DialogResult re = MessageBox.Show("Do You Want Delete This Record...!", "Ayubo Car Rent System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (re == DialogResult.Yes)
                    {


                        SqlCommand cmd;
                        string x;

                        x = "delete from AccessRight where User_Name ='" + (txtName.Text).ToString() + "'";
                        cmd = new SqlCommand(x, con);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data Delete Succesful...!");


                    }
                    else
                    {
                        MessageBox.Show("Data Delete Not Succesful...!");

                    }
                }
                catch (Exception )
                {
                    MessageBox.Show("Data Delete Not Succesful...!");

                }

                con.Close();
            }
            catch (Exception )
            {
                MessageBox.Show("Database not  connected...!");

            }

            btnCancel_Click(btnCancel, e);

            txtName.Focus();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if ((txtName.Text).Trim() == "")
            {
                MessageBox.Show("Please Enter User Name..!");
                txtName.Focus();
            }
            else if ((txtPass.Text).Trim() == "")
            {
                MessageBox.Show("Please Enter Password..!");
                txtPass.Focus();
            }
            else if ((txtCon.Text).Trim() == "")
            {
                MessageBox.Show("Please Enter Comfirm Password..!");
                txtPass.Focus();
            }
            else if ((txtNic.Text).Trim() == "")
            {
                MessageBox.Show("Please Enter NIC..!");
                txtPass.Focus();
            }
            else if ((cmbType.Text).Trim() == "")
            {
                MessageBox.Show("Please Select Type..!");
                txtPass.Focus();
            }
            else
            {
                if (txtPass.Text == txtCon.Text)
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
                                x = "insert into AccessRight values('" + (txtName.Text).ToString() + "','" + txtPass.Text + "','" + txtNic.Text + "','" + (cmbType.Text).Trim() + "');";
                                MessageBox.Show("Data Saved ! ");
                            }
                            else
                            {
                                x = "update AccessRight set Password = '" + txtPass.Text + "',NIC = '" + txtNic.Text + "',Designation ='" + (cmbType.Text).Trim() + "' where User_Name ='" + txtName.Text + "';";
                                MessageBox.Show("Data Updated ! ");
                            }

                            cmd = new SqlCommand(x, con);
                            cmd.ExecuteNonQuery();


                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Data Insert Or  Update Error...!");
                        }

                        con.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Database not  connected...!");

                    }

                    btnCancel_Click(btnCancel, e);

                }
                else
                {
                    MessageBox.Show("Password is wrong ....!");
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                po = null;
                btnNew.Enabled = true ;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnSave.Enabled = false ;
                btnCancel.Enabled = false ;

                rbtnName.Enabled = true;
                rbtnNIC.Enabled = true;

                txtName.Enabled = false;
                txtPass.Enabled = false;
                txtCon.Enabled = false;
                cmbType.Enabled = false;
                txtNic.Enabled = false;
                txtSearch.Enabled = true;

                txtName.Text = "";
                txtPass.Text = "";
                txtCon.Text = "";
                txtNic.Text = "";
                cmbType.Text = "";
                txtSearch.Text = "";

                txtSearch_TextChanged(txtSearch, e);

                txtSearch .Focus();

            }
            catch (Exception )
            {

            }


        }

        private void rbtnNIC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
                    if (rbtnNIC.Checked == true )
                    {
                         x = "select * from AccessRight where NIC like '" + (txtSearch.Text).Trim() + "%'";

                    }
                    else if (rbtnName .Checked == true)
                    {
                        x = "select * from AccessRight where User_Name like '" + (txtSearch.Text).Trim() + "%'";

                    }
                    else
                    {
                        x = "select * from AccessRight";

                    }

                    cmd = new SqlCommand(x, con);
                    da.SelectCommand = cmd;
                    da.Fill(ds,"AR");
                    dgv.DataSource = ds.Tables["AR"] ;  
                    dgv.Refresh();
                   

                                    
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.ToString());
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error...!");
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtNic_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCon_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbtnName_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dgv.Refresh();
                txtName.Text = dgv.SelectedRows[0].Cells[0].Value.ToString();
                txtPass.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
                txtCon.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
                txtNic.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();
                cmbType.Text = dgv.SelectedRows[0].Cells[3].Value.ToString();

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
