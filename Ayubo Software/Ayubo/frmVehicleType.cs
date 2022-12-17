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
    public partial class frmVehicleType : Form
    { 
        public frmVehicleType()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Server= localhost; Database= AyuboDriveDatabase;Integrated Security = SSPI;");
        string po;
        private void frmVehicleType_Load(object sender, EventArgs e)
        {
            btnCancel_Click(btnCancel, e);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            po = "New";
            btnNew.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;

            txtvehicalid.ReadOnly = false ;
            txtvehicaltype .ReadOnly = false ;
            txtSearch .ReadOnly = false ;
            rbtID.Enabled = false;
            rbtType.Enabled = false;

            txtvehicalid.Text = "";
            txtvehicaltype.Text = "";

            txtvehicalid.Focus();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            po = "Update";
            btnNew.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;

            txtvehicalid.ReadOnly = true ;
            txtvehicaltype.ReadOnly = false;
            txtSearch.ReadOnly = false;
            rbtID.Enabled = false;
            rbtType.Enabled = false;

            txtvehicaltype.Focus();

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

                        x = "delete from VehicaleType where Vehical_ID ='" + (txtvehicalid.Text).ToString() + "'";
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

            txtSearch.Focus();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string x;
            try
            {
                con.Open();
                try
                {
                    if (txtvehicalid.Text == "")
                    {
                        MessageBox.Show("Please Enter Vehical ID ...!", "Ayubo Car Rent System.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtvehicalid.Focus();
                    }
                    else if (txtvehicaltype.Text == "")
                    {
                        MessageBox.Show("Please Enter Vehical Type ...!", "Ayubo Car Rent System.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtvehicaltype.Focus();

                    }
                    else
                    {
                        SqlCommand cmd;
                        if (po == "New")
                        {
                            x = "insert into VehicaleType values (" + (txtvehicalid.Text).Trim() + ",'" + (txtvehicaltype.Text).Trim() + "');";
                        }
                        else
                        {
                            x = "update VehicaleType set Vehical_Type = '" + (txtvehicaltype.Text).Trim() + "' where Vehical_ID = '" + (txtvehicalid.Text).Trim () + "';";
                        }

                        cmd = new SqlCommand(x, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Saved/Updated ...!", "Ayubo Car Rent System.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data Not Saved Or Updated...!", "Ayubo Car Rent System.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Database not connected...!", "Ayubo Car Rent System.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            btnCancel_Click(btnCancel, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;

            txtvehicalid.ReadOnly = true ;
            txtvehicaltype.ReadOnly = true ;
            txtSearch.ReadOnly = true ;
            rbtID.Enabled = true;
            rbtType.Checked = true;
            rbtType.Enabled = true;
            txtSearch.Focus();

            txtvehicalid.Text = "";
            txtvehicaltype.Text = "";
            txtSearch.Text = "";
            txtSearch_TextChanged(txtSearch, e);

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

                    string x = null;

                    if (rbtType.Checked == true)
                    {
                        x = "select * from VehicaleType where Vehical_Type like'" + txtSearch.Text.Trim() + "%'";

                    }
                    else
                    {
                        x = "select * from VehicaleType where Vehical_ID like'" + txtSearch.Text.Trim() + "%'";

                    }

                    cmd = new SqlCommand(x, con);
                    da.SelectCommand = cmd;
                    da.Fill(ds, "VT");
                    dgv.DataSource = ds.Tables["VT"];
                    dgv.Refresh();



                }
                catch (Exception ex)
                {

                }

                con.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            


        }

        public  void dgv_SelectionChanged(object sender,EventArgs e)
        {
            try
            {
                dgv.Refresh();
                txtvehicalid.Text = dgv.SelectedRows[0].Cells[0].Value.ToString();
                txtvehicaltype.Text = dgv.SelectedRows[0].Cells [1].Value.ToString();

            }
            catch (Exception ex)
            {
            }
        }

        
    }
}
