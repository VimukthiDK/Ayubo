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
    public partial class frmPackage : Form
    {
        public frmPackage()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Server= localhost; Database= AyuboDriveDatabase;Integrated Security = SSPI;");

        string po = null;

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

                rbtType.Enabled = false;
                rbtVehiType.Enabled = false;
                rbtType.Enabled = true;

                txtPNo.Enabled = true;
                txtPackType.Enabled = true;
                txtMaxKm.Enabled = true;
                txtCharges.Enabled = true;
                txtTime.Enabled = true;
                txtEMaxKm.Enabled = true;
                txtEMaxTime.Enabled = true;
                txtOther.Enabled = true;
                cmbVehiType.Enabled = true;
                txtSearch.Enabled = false;

                txtPNo.Text = "";
                txtPackType.Text = "";
                txtCharges.Text = "0.0";
                txtMaxKm.Text = "0";
                txtTime.Text = "0";
                txtEMaxKm.Text = "0";
                txtEMaxTime.Text = "0";
                txtOther.Text = "";
                txtSearch.Text = "";
                cmbVehiType.Text = "";

                try
                {
                    con.Open();

                    try
                    {
                        SqlCommand cmd = new SqlCommand("Select * from VehicaleType", con);
                        SqlDataReader x = cmd.ExecuteReader();

                        cmbVehiType.Items.Clear();
                        while (x.Read())
                        {
                            cmbVehiType.Items.Add(x["Vehical_Type"]);

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

                txtCharges.Focus();

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
                btnNew.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;

                rbtType.Enabled = false;
                rbtVehiType.Enabled = false;
                rbtType.Enabled = true;

                txtPackType.Enabled = true;
                txtMaxKm.Enabled = true;
                txtCharges.Enabled = true;
                txtTime.Enabled = true;
                txtEMaxKm.Enabled = true;
                txtEMaxTime.Enabled = true;
                txtOther.Enabled = true;
                cmbVehiType.Enabled = true;
                txtSearch.Enabled = false;

                try
                {
                    con.Open();

                    try
                    {
                        SqlCommand cmd = new SqlCommand("Select * from VehicaleType", con);
                        SqlDataReader x = cmd.ExecuteReader();

                        cmbVehiType.Items.Clear();
                        while (x.Read())
                        {
                            cmbVehiType.Items.Add(x["Vehical_Type"]);

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

                txtCharges.Focus();

            }
            catch (Exception)
            {

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            {

                if ((txtPNo.Text).Trim() == "")
                {
                    MessageBox.Show("Please Enter Package No..!");
                    txtPNo.Focus();
                }

                else if ((txtPackType.Text).Trim() == "")
                {
                    MessageBox.Show("Please Enter Package Type..!");
                    txtPackType.Focus();
                }
                else if ((txtCharges.Text).Trim() == "")
                {
                    MessageBox.Show("Please Enter Charges..!");
                    txtCharges.Focus();
                }
                else if ((txtEMaxKm.Text).Trim() == "")
                {
                    MessageBox.Show("Please Enter Max KM..!");
                    MessageBox.Show("Please Enter ..!");
                    txtMaxKm.Focus();
                }
                else if ((txtTime.Text).Trim() == "")
                {
                    MessageBox.Show("Please Enter Max Time.!");
                    txtTime.Focus();
                }
                else if ((cmbVehiType.Text).Trim() == "")
                {
                    MessageBox.Show("Please Enter Select Vehical Type..!");
                    cmbVehiType.Focus();
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
                                x = "insert into Package values('" + (txtPNo.Text).Trim().ToString() + "','" + txtPackType.Text.Trim().ToString() + "','" + cmbVehiType.Text.ToString () + "','" + (txtCharges.Text).Trim() + "','" + (txtMaxKm.Text).Trim() + "','" + (txtTime.Text).Trim() + "','" + (txtEMaxKm.Text).Trim() + "','" + (txtEMaxTime.Text).Trim() + "','" + (txtOther.Text).Trim() + "');";
                            }
                            else
                            {
                                x = "update Package set Package_Type ='" + (txtPackType.Text).ToString() + "',Vehical_Type = '" + cmbVehiType.Text.Trim().ToString() + "',Charges ='" + (txtCharges.Text).Trim() + "',Max_Km ='" + (txtMaxKm.Text).Trim() + "',Max_Time ='" + (txtTime .Text).Trim() + "',ExtraCharges_Per_Km ='" + (txtEMaxKm.Text).Trim().ToString() + "',ExtraCharges_Per_Time ='" + (txtEMaxTime.Text).Trim().ToString() + "', Other ='" + (txtOther.Text).Trim().ToString() + "' where PackageNo ='" + (txtPNo.Text).Trim().ToString() + "';";
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

                rbtType.Enabled = true;
                rbtVehiType.Enabled = true;
                rbtType.Enabled = true;

                txtPNo.Enabled = false;
                txtPackType.Enabled = false;
                txtMaxKm.Enabled = false;
                txtCharges.Enabled = false;
                txtTime.Enabled = false;
                txtEMaxKm.Enabled = false;
                txtEMaxTime.Enabled = false;
                txtOther.Enabled = false;
                cmbVehiType.Enabled = false;
                txtSearch.Enabled = true ;

                txtPNo.Text = "";
                txtPackType.Text = "";
                txtCharges.Text = "0.0";
                txtMaxKm.Text = "0";
                txtTime.Text = "0";
                txtEMaxKm.Text = "0";
                txtEMaxTime.Text = "0";
                txtOther.Text = "";
                txtSearch.Text = "";
                cmbVehiType.Text = "";

                cmbVehiType.Items.Clear();

                txtSearch_TextChanged(txtSearch, e);

                txtSearch.Focus();

            }
            catch (Exception ex)
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
                    if (rbtType.Checked == true)
                    {
                        x = "select * from Package where Package_Type like '" + (txtSearch.Text).Trim() + "%'";

                    }
                    else if (rbtVehiType.Checked == true)
                    {
                        x = "select * from Package where Vehical_Type like '" + (txtSearch.Text).Trim() + "%'";

                    }
                    else if (rbtCharges.Checked == true)
                    {
                        x = "select * from Package where Charges like '" + (txtSearch.Text).Trim() + "%'";

                    }
                    else
                    {
                        x = "select * from Package";

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

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmPackage_Load(object sender, EventArgs e)
        {
            btnCancel_Click(btnCancel, e);
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

                        x = "delete from Package where PackageNo ='" + (txtPNo.Text).ToString() + "'";
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
                dgvCustomer.Refresh();
                txtPNo.Text = dgvCustomer.SelectedRows[0].Cells[0].Value.ToString();
                txtPackType .Text = dgvCustomer.SelectedRows[0].Cells[1].Value.ToString();
                cmbVehiType .Text = dgvCustomer.SelectedRows[0].Cells[2].Value.ToString();
                txtCharges .Text = dgvCustomer.SelectedRows[0].Cells[3].Value.ToString();
                txtMaxKm .Text = dgvCustomer.SelectedRows[0].Cells[4].Value.ToString();
                txtTime .Text = dgvCustomer.SelectedRows[0].Cells[5].Value.ToString();
                txtEMaxKm.Text = dgvCustomer.SelectedRows[0].Cells[6].Value.ToString();
                txtEMaxTime.Text = dgvCustomer.SelectedRows[0].Cells[7].Value.ToString();
                txtOther.Text = dgvCustomer.SelectedRows[0].Cells[8].Value.ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }

        private void rbtVehiType_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
