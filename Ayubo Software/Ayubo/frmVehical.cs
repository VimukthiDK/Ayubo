using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ayubo
{
    public partial class frmVehical : Form
    {
        SqlConnection con = new SqlConnection("Server= localhost; Database= AyuboDriveDatabase;Integrated Security = SSPI;");

        string po = null;

        public frmVehical()
        {
            InitializeComponent();
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

                rbtVehiNo.Enabled = false;
                rbtVehiType.Enabled = false;
                cmbVehicalType.Enabled = true;

                txtChages.Enabled = true;
                txtVehiNo.Enabled = true;
                txtOther.Enabled = true;
                txtSearch.Enabled = false;

                txtChages.Text = "";
                txtVehiNo.Text = "";
                txtOther.Text = "";
                txtSearch.Text = "";
                cmbVehicalType.Text = "";

                try
                {
                    con.Open();

                     try
                        {
                            SqlCommand cmd = new SqlCommand("Select * from VehicaleType", con);
                            SqlDataReader x = cmd.ExecuteReader();

                            cmbVehicalType.Items.Clear();
                            while (x.Read())
                            {
                                cmbVehicalType.Items.Add(x["Vehical_Type"]);

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

                txtVehiNo.Focus();

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

                rbtVehiNo.Enabled = false;
                rbtVehiType.Enabled = false;
                cmbVehicalType.Enabled = true;



                txtChages.Enabled = true;
                txtVehiNo.Enabled = false;
                txtOther.Enabled = true;
                txtSearch.Enabled = false;
                txtChages.Focus();

                try
                {
                    con.Open();

                    try
                    {
                        SqlCommand cmd = new SqlCommand("Select * from VehicaleType", con);
                        SqlDataReader x = cmd.ExecuteReader();

                        cmbVehicalType.Items.Clear();
                        while (x.Read())
                        {
                            cmbVehicalType.Items.Add(x["Vehical_Type"]);

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
            catch (Exception)
            {

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            {

                if ((txtChages.Text).Trim() == "")
                {
                    MessageBox.Show("Please Enter Chages..!");
                    txtChages.Focus();
                }

                else if ((txtVehiNo.Text).Trim() == "")
                {
                    MessageBox.Show("Please Enter Vehical No..!");
                    txtVehiNo.Focus();
                }
                else if ((cmbVehicalType.Text).Trim() == "")
                {
                    MessageBox.Show("Please Enter Select Vehical Type..!");
                    cmbVehicalType.Focus();
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
                                x = "insert into Vehicale values('" + (txtVehiNo.Text).Trim().ToString() + "','" + txtChages.Text.Trim().ToString() + "','" + cmbVehicalType.Text + "','" + (txtOther.Text).Trim() + "');";
                            }
                            else
                            {
                                x = "update Vehicale set Chages ='" + (txtChages.Text).ToString() + "',Vehical_Type = '" + cmbVehicalType.Text.Trim().ToString() + "',Other ='" + (txtOther.Text).Trim().ToString() + "' where Vehical_NO ='" + txtVehiNo.Text.Trim().ToString() + "';";
                            }

                            MessageBox.Show("Data Saved / Updated ! ");
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

                rbtVehiNo.Enabled = true;
                rbtVehiType.Enabled = true;
                cmbVehicalType.Enabled = false ;


                txtChages.Enabled = false;
                txtVehiNo.Enabled = false;
                txtOther.Enabled = false;
                txtSearch.Enabled = true;

                txtChages.Text = "";
                txtVehiNo.Text = "";
                txtOther.Text = "";
                txtSearch.Text = "";

                cmbVehicalType.Items.Clear();

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
                    if (rbtVehiNo .Checked == true)
                    {
                        x = "select * from Vehicale where Vehical_NO like '" + (txtSearch.Text).Trim() + "%'";

                    }
                    else if (rbtVehiType .Checked == true)
                    {
                        x = "select * from Vehicale where Vehical_Type like '" + (txtSearch.Text).Trim() + "%'";

                    }
                    else                    
                    {
                        x = "select * from Vehicale";

                    }

                    cmd = new SqlCommand(x, con);
                    da.SelectCommand = cmd;
                    da.Fill(ds, "ARC");
                    dgvC.DataSource = ds.Tables["ARC"];
                    dgvC.Refresh();



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

        private void frmVehical_Load(object sender, EventArgs e)
        {
            btnCancel_Click(btnCancel, e);

        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvC.Refresh();
                txtVehiNo.Text = dgvC.SelectedRows[0].Cells[0].Value.ToString();
                txtChages.Text = dgvC.SelectedRows[0].Cells[1].Value.ToString();
                cmbVehicalType .Text = dgvC.SelectedRows[0].Cells[2].Value.ToString();
                txtOther.Text = dgvC.SelectedRows[0].Cells[3].Value.ToString();

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
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

                        x = "delete from Vehicale where Vehical_NO ='" + (txtVehiNo.Text).ToString() + "'";
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

        private void dgvCustomer_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                dgvC.Refresh();
                txtVehiNo.Text = dgvC.SelectedRows[0].Cells[0].Value.ToString();
                txtChages.Text = dgvC.SelectedRows[0].Cells[1].Value.ToString();
                cmbVehicalType.Text = dgvC.SelectedRows[0].Cells[2].Value.ToString();
                txtOther.Text = dgvC.SelectedRows[0].Cells[3].Value.ToString();
                
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }

        }
    }
}
