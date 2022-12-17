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
    public partial class frmRentBooking : Form
    {
        SqlConnection con = new SqlConnection("Server= localhost; Database= AyuboDriveDatabase;Integrated Security = SSPI;");
        String po = null;


        string Ppo = null;



        public frmRentBooking()
        {
            InitializeComponent();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void rbtDT_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCAdd_Click(object sender, EventArgs e)
        {
            CustomerDetails cd = new CustomerDetails();
            cd.Show();

        }

        private void btnNew_Click(object sender, EventArgs e)
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
                    x = "select * from Rent;";

                    cmd = new SqlCommand(x, con);
                    da.SelectCommand = cmd;
                    da.Fill(ds, "ARC");

                    int rentNo;
                    rentNo = 0;
                    rentNo = int.Parse (ds.Tables["ARC"].Rows[ds.Tables["ARC"].Rows.Count - 1].ItemArray[0].ToString ());
                    rentNo = rentNo + 1;

                    txtRentNo.Text = rentNo.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString() + "   12");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error...!" + ex.ToString());
            }


            try
            {
                po = "NEW";
                //txtRentNo.ReadOnly = false ;
                cmbPack.Enabled = true;
                cmbVehi .Enabled = true;
                cmbVehiNo.Enabled = true;
                txtVehiCha.ReadOnly = false ;
                txtDChages.ReadOnly = false;
                txtAPay.ReadOnly = false;
                txtTPay.ReadOnly = true;
                dtp1.Enabled = true;
                dtp2.Enabled = true;
                dtp1.Text = DateTime.Now.ToString();
                dtp2.Text  = DateTime.Now.ToString();

                txtSearch.ReadOnly = true;

                btnNew .Enabled = false;
                btnUpdate .Enabled = false ;
                btnDelete .Enabled = false ;
                btnSave .Enabled = true;
                btnCancel  .Enabled = true;
                btnPrint .Enabled = true ;
                btnNew.Enabled = true;
                btnCustLoad.Enabled = true;

                txtSK.ReadOnly = false;
                txtek.ReadOnly = false;
                dgv1.Enabled = false;

                rbtWithD.Enabled = true;
                rbtWithoutD.Enabled = true;
                rbtWithoutD.Checked = true;
                rbtSPack.Enabled = false;
                rbtVType.Enabled = false;

                txtName.Text = "";
                txtNic.Text = "";
                txtAddress.Text = "";
                txtCN.Text = "";
                cmbPack.Text = "";
                cmbVehi.Text = "";
                cmbVehiNo.Text = "";
                txtVehiCha.Text = "0.0";
                txtDChages.Text = "0.0";
                txtAPay.Text = "0.0";
                txtTPay.Text = "0.0";
                txtBalancePay.Text = "0.0";
                txtSK.Text = "0";
                txtek.Text = "0";

                txtSearch.Text = "";

                try
                {
                    con.Open();

                    try
                    {
                        SqlCommand cmd = new SqlCommand("Select * from Package", con);
                        SqlDataReader x = cmd.ExecuteReader();

                        cmbPack .Items.Clear();
                        while (x.Read())
                        {
                            cmbPack.Items.Add(x["Package_Type"]);

                        }



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
            catch (Exception ex)
            {

            }
         }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                po = "UPDATE";
                cmbPack.Enabled = true;
                cmbVehi.Enabled = true;
                cmbVehiNo.Enabled = true;
                txtVehiCha.ReadOnly = false ;
                txtDChages.ReadOnly = false;
                txtAPay.ReadOnly = false;
                txtTPay.ReadOnly = true;
                dtp1.Enabled = true;
                dtp2.Enabled = true;

                txtSearch.ReadOnly = true;

                btnNew.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                btnPrint.Enabled = true;
                btnCustLoad .Enabled = true;


                txtSK.ReadOnly = false;
                txtek.ReadOnly = false;
                dgv1.Enabled = false;


                rbtWithD.Enabled = true;
                rbtWithoutD .Enabled = true; 
                rbtWithoutD.Checked = true;
                rbtSPack.Enabled = false;
                rbtVType.Enabled = false;



            }
            catch (Exception ex)
            {

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                po = null;
                txtRentNo.ReadOnly = true ;
                cmbPack.Enabled = false ;
                cmbVehi.Enabled = false;
                cmbVehiNo.Enabled = false;
                txtVehiCha.ReadOnly = true ;
                txtDChages.ReadOnly = true ;
                txtAPay.ReadOnly = true;
                txtTPay.ReadOnly = false ;
                dtp1.Enabled = false;
                dtp2.Enabled = false;

                txtSearch.ReadOnly = false;

                btnNew.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnSave.Enabled = false ;
                btnCancel.Enabled = false;
                btnPrint.Enabled = false;
                btnCustLoad .Enabled = false ;


                rbtWithD.Enabled = false;
                rbtWithoutD.Enabled = false;
                rbtWithoutD.Checked = true ;
                rbtSPack.Enabled = true ;
                rbtVType.Enabled = true ;


                txtSK.ReadOnly = true;
                txtek.ReadOnly = true;
                dgv1.Enabled = true ;

                txtName.Text = "";
                txtNic.Text = "";
                txtAddress.Text = "";
                txtCN.Text = "";
                cmbPack.Text = "";
                cmbVehi.Text = "";
                cmbVehiNo.Text = "";
                txtVehiCha.Text = "0.0";
                txtDChages.Text = "0.0";
                txtAPay.Text = "0.0";
                txtTPay.Text = "0.0";
                txtBalancePay.Text = "0.0";
                txtSK.Text = "0";
                txtek .Text = "0";

                txtSearch.Text = "";

                txtSearch_TextChanged(txtSearch, e);


            }
            catch (Exception ex)
            {

            }
        }

        private void cmbPack_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbPack_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {
                con.Open();

                try
                {
                    SqlCommand cmd = new SqlCommand("Select * from Package where Package_Type = '" + (cmbPack .Text ).Trim ().ToString () + "';", con);
                    SqlDataReader x = cmd.ExecuteReader();

                    cmbVehiNo.Text = "";
                    cmbVehiNo.Items.Clear();
                    cmbVehi.Text = "";
                    txtVehiCha.Text = "0.0";

                    cmbVehi .Items.Clear();
                    while (x.Read())
                    {
                        cmbVehi .Items.Add(x["Vehical_Type"]);

                    }



                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.ToString());
                }

                con.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Connection Error...! 44444");
            }

        }

        private void cmbPack_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void cmbVehi_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                try
                {
                    SqlCommand cmd = new SqlCommand("Select * from Vehicale where Vehical_Type = '" + (cmbVehi.Text).Trim().ToString() + "';", con);
                    SqlDataReader x = cmd.ExecuteReader();

                    cmbVehiNo.Items.Clear();
                    while (x.Read())
                    {
                        cmbVehiNo.Items.Add(x["Vehical_NO"]);

                    }



                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.ToString());
                }

                con.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Connection Error...! 555555");
            }
        }

        private void cmbVehiNo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void frmRentBooking_Load(object sender, EventArgs e)
        {
            btnCancel_Click(btnCancel, e);
        }

        private void cmbVehi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            if ((txtNic.Text).Trim() == "")
            {
                MessageBox.Show("Please Enter Customer NIC ..!");
                txtNic.Focus();
            }

            else if ((txtName.Text).Trim() == "")
            {
                MessageBox.Show("Please Enter Customer Name..!");
                txtName.Focus();
            }
            else if ((txtAddress.Text).Trim() == "")
            {
                MessageBox.Show("Please Enter Customer Address ..!");
                txtAddress.Focus();
            }
            else if ((txtCN.Text).Trim() == "")
            {
                MessageBox.Show("Please Enter Customer Contact Number ..!");
                txtCN.Focus();
            }
            else if ((cmbPack.Text).Trim() == "")
            {
                MessageBox.Show("Please Select Package ..!");
                cmbPack.Focus();
            }
            else if ((cmbVehi.Text).Trim() == "")
            {
                MessageBox.Show("Please Select Vehical Type ..!");
                cmbVehi.Focus();
            }
            else if ((cmbVehiNo.Text).Trim() == "")
            {
                MessageBox.Show("Please Select Vehical No ..!");
                cmbVehiNo.Focus();
            }
            else if ((txtVehiCha.Text).Trim() == "")
            {
                MessageBox.Show("Please Enter Vehical Chages ..!");
                txtVehiCha.Focus();
            }
            else if ((txtRentNo.Text).Trim() == "")
            {
                MessageBox.Show("Please Enter Rent No ..!");
                txtRentNo.Focus();
            }
            else if ((dtp1.Text).Trim() == "")
            {
                MessageBox.Show("Please Enter Start Date ..!");
                dtp1.Focus();
            }
            else if ((dtp2.Text).Trim() == "")
            {
                MessageBox.Show("Please Enter End Date ..!");
                dtp2.Focus();
            }
            else if ((txtSK .Text).Trim() == "")
            {
                MessageBox.Show("Please Enter Start Killo Meter ..!");
                txtSK .Focus();
            }
            else if ((txtek .Text).Trim() == "")
            {
                MessageBox.Show("Please Enter End Killo Meter ..!");
                txtek .Focus();
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
                        if (po == "NEW")
                        {
                            string st = "Active";
                            x = "insert into Rent values('" + (txtRentNo .Text).Trim().ToString() + "','" + (cmbVehiNo .Text).Trim().ToString() + "','" + (cmbVehi.Text).Trim ().ToString () + "','" + (cmbPack .Text).Trim() + "','" + (txtVehiCha.Text).Trim() + "','" + (txtDChages .Text).Trim() + "','" + (txtNic .Text).Trim() + "','" + (txtName .Text).Trim() + "','" + (txtAddress .Text).Trim() + "','" + (txtCN .Text).Trim() + "','" + (dtp1 .Text).Trim() + "','" + (dtp2.Text).Trim() + "','" + (txtSK.Text).Trim() + "','" + (txtek.Text).Trim() + "','" + (txtTPay.Text).Trim() + "','" + (txtAPay .Text).Trim() + "','" + (txtBalancePay .Text).Trim() + "','" + "Not Paid" + "')";
                        }
                        else
                        {
                            x = "update Rent set VehicleNumber='" + (cmbVehiNo.Text).Trim().ToString() + "',VehicalType='" + (cmbVehi.Text).Trim().ToString() + "',PackegeType='" + (cmbPack.Text).Trim() + "',ChargesPerDay='" + (txtVehiCha.Text).Trim() + "',DriverCharges='" + (txtDChages.Text).Trim() + "',Customer_Nic='" + (txtNic.Text).Trim() + "',Customer_Name='" + (txtName.Text).Trim() + "',Customer_Address='" + (txtAddress.Text).Trim() + "',Contact_No='" + (txtCN.Text).Trim() + "',StartDate='" + (dtp1.Text).Trim() + "',EndDate='" + (dtp2.Text).Trim() + "',StartKm='" + (txtSK.Text).Trim() + "',EndKm='" + (txtek.Text).Trim() + "',TotalAmount='" + (txtTPay.Text).Trim() + "',AdvanceAmount='" + (txtAPay.Text).Trim() + "',BalanceAmount='" + (txtBalancePay.Text).Trim() + "',Status='"+ "Paid" +"' where RentBookingNumber='" + (txtRentNo .Text ).Trim () + "'";

                        }

                        cmd = new SqlCommand(x, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Saved / Updated ! ");


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Data Insert Or  Update Error...!" );
                    }

                    con.Close();
                }
                catch(Exception )
                {
                    MessageBox.Show("Database not  connected...!");

                }
                btnCancel_Click(btnCancel, e);

            }
        }

        private void label5_Click(object sender, EventArgs e)
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
                    if (rbtSPack.Checked == true)
                    {
                        x = "select * from Rent where PackegeType like '" + (txtSearch.Text).Trim() + "%'";

                    }
                    else if (rbtVType.Checked == true)
                    {
                        x = "select * from Rent where VehicalType like '" + (txtSearch.Text).Trim() + "%'";

                    }
                    else
                    {
                        x = "select * from Rent";

                    }

                    cmd = new SqlCommand(x, con);
                    da.SelectCommand = cmd;
                    da.Fill(ds, "ARD");
                    dgv1.DataSource = ds.Tables["ARD"];
                    dgv1.Refresh();



                }
                catch (Exception ex)
                {
                    //MessageBox .Show(ex.ToString());
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error...!");
            }
        }

        private void cmbSPack_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cmbSPack_SelectedValueChanged(object sender, EventArgs e)
        {

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

                        x = "delete from Rent where RentBookingNumber ='" + (txtRentNo.Text).ToString() + "'";
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

        private void dgv1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dgv1.Refresh();
                txtRentNo.Text = dgv1 .SelectedRows[0].Cells[0].Value.ToString();
                cmbVehiNo.Text = dgv1.SelectedRows[0].Cells[1].Value.ToString();
                cmbVehi.Text = dgv1.SelectedRows[0].Cells[2].Value.ToString();
                cmbPack .Text = dgv1.SelectedRows[0].Cells[3].Value.ToString();
                txtVehiCha.Text = dgv1.SelectedRows[0].Cells[4].Value.ToString();
                txtDChages .Text = dgv1.SelectedRows[0].Cells[5].Value.ToString();
                txtNic .Text = dgv1.SelectedRows[0].Cells[6].Value.ToString();
                txtName .Text = dgv1.SelectedRows[0].Cells[7].Value.ToString();
                txtAddress .Text = dgv1.SelectedRows[0].Cells[8].Value.ToString();
                txtCN .Text = dgv1.SelectedRows[0].Cells[9].Value.ToString();
                dtp1 .Text = dgv1.SelectedRows[0].Cells[10].Value.ToString();
                dtp2 .Text = dgv1.SelectedRows[0].Cells[11].Value.ToString();
                txtSK .Text = dgv1.SelectedRows[0].Cells[12].Value.ToString();
                txtek .Text = dgv1.SelectedRows[0].Cells[13].Value.ToString();
                txtTPay.Text = dgv1.SelectedRows[0].Cells[14].Value.ToString();
                txtAPay .Text = dgv1.SelectedRows[0].Cells[15].Value.ToString();
                txtBalancePay .Text = dgv1.SelectedRows[0].Cells[16].Value.ToString();

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }

        private void dtp1_ValueChanged(object sender, EventArgs e)
        {
            float total_rent, w;
            int x, d;

            if ((txtVehiCha .Text.Trim () =="0.0") || (txtVehiCha .Text.Trim() == "" ))
            {
                MessageBox.Show("Please Enter Vehical Charges ....!");
                txtVehiCha.Focus();
            }
            else if ((txtDChages.Text.Trim() == "0.0") || (txtDChages.Text.Trim() == "" ))
            {
                MessageBox.Show("Please Enter driver Charges ....!");
                txtDChages.Focus();

            }
            else
            {
                try
                {
                    x = dtp2.Value.DayOfYear - dtp1.Value.DayOfYear;
                    if (x > 6)
                    {
                        w = x / 7;
                        d = (x % 7) + 1;
                        if (rbtWithD.Checked == true)
                        {
                            total_rent = w * (float.Parse(txtVehiCha.Text.Trim()) * 7) + d * float .Parse(txtVehiCha.Text.Trim()) + (x + 1) * float .Parse(txtDChages.Text.Trim());
                            txtTPay.Text = total_rent.ToString();
                            txtAPay.Text = "0.0";
                            txtBalancePay.Text = "0.0";

                        }
                        else
                        {
                            total_rent = w * (float.Parse(txtVehiCha.Text.Trim()) * 7) + d * float.Parse(txtVehiCha.Text.Trim());
                            txtTPay.Text = total_rent.ToString();
                            txtAPay.Text = "0.0";
                            txtBalancePay.Text = "0.0";

                        }
                    }
                    else
                    {
                        if (rbtWithD.Checked == true)
                        {
                            total_rent = (x + 1) * float.Parse(txtVehiCha.Text.Trim()) + (x + 1) * float.Parse(txtDChages.Text.Trim());
                            txtTPay.Text = total_rent.ToString();
                            txtAPay.Text = "0.0";
                            txtBalancePay.Text = "0.0";

                        }
                        else
                        {
                            total_rent = (x + 1) * float.Parse(txtVehiCha.Text.Trim());
                            txtTPay.Text = total_rent.ToString();
                            txtAPay.Text = "0.0";
                            txtBalancePay.Text = "0.0";

                        }

                    }


                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.ToString());
                }
            }
           
        }

        private void dtp2_ValueChanged(object sender, EventArgs e)
        {
            dtp1_ValueChanged(dtp1, e);
        }

        private void txtVehiCha_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtDChages_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAPay_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtBalancePay.Text = (int.Parse (txtTPay.Text.Trim ()) - int.Parse (txtAPay.Text.Trim ())).ToString ();
            }
            catch
            {

            }
        }

        private void frmRentBooking_Activated(object sender, EventArgs e)
        {
        }

        private void txtVehiCha_Leave(object sender, EventArgs e)
        {

        }

        private void txtDChages_Leave(object sender, EventArgs e)
        {

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCustLoad_Click(object sender, EventArgs e)
        {
            try
            {
                panaCust.Visible = true;
                txtPSearch_TextChanged(txtPSearch, e);
                btnPCustLoad.Enabled = false;

            }
            catch (Exception ex)
            {

            }
            
        }

        private void panaCust_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            btnCustLoad.Enabled = true;
            panaCust.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Ppo = null;
                btnPNew.Enabled = true;
                btnPUpdate.Enabled = true;
                btnPDelete.Enabled = true;
                btnPSave.Enabled = false;
                button2 .Enabled = false;

                rbtPName.Enabled = true;
                rbtPNIC.Enabled = true;

                txtPName.Enabled = false;
                txtPNic.Enabled = false;
                txtPNC.Enabled = false;
                txtPAddress.Enabled = false;
                txtPSearch.Enabled = true;

                txtPName.Text = "";
                txtPNic.Text = "";
                txtPNC.Text = "";
                txtPAddress.Text = "";
                txtPSearch.Text = "";

                txtPSearch_TextChanged(txtPSearch, e);

                txtPSearch.Focus();

            }
            catch (Exception)
            {

            }
        }

        private void btnPSave_Click(object sender, EventArgs e)
        {
            if ((txtPNic.Text).Trim() == "")
            {
                MessageBox.Show("Please Enter  Your NIC..!");
                txtPName.Focus();
            }
            else if ((txtPName.Text).Trim() == "")
            {
                MessageBox.Show("Please Enter Your Name..!");
                txtPName.Focus();
            }

            else if ((txtPNC.Text).Trim() == "")
            {
                MessageBox.Show("Please Enter Contact Number..!");
                txtPNC .Focus();
            }
            else if ((txtPAddress.Text).Trim() == "")
            {
                MessageBox.Show("Please Enter Address..!");
                txtPAddress.Focus();
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
                        if (Ppo == "New")
                        {
                            x = "insert into CustomerDetails values('" + (txtPNic.Text).ToString() + "','" + (txtPName.Text).ToString() + "','" + (txtPNC.Text).ToString() + "','" + (txtPAddress.Text).Trim() + "');";
                        }
                        else
                        {
                            x = "update CustomerDetails set Name ='" + (txtPName.Text).Trim() + "',ContactNumber='" + (txtPNC.Text).Trim() + "',Address = '" + (txtPAddress.Text).Trim() + "' where NIC ='" + (txtPNic.Text).Trim() + "'";
                        }

                        MessageBox.Show("Data Saved / Updated ! ");
                        cmd = new SqlCommand(x, con);
                        cmd.ExecuteNonQuery();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Data Insert Or  Update Error...!" + ex.ToString());
                    }

                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Database not  connected...!");

                }

                button2_Click(button2 , e);

            }



        }

        private void btnPNew_Click(object sender, EventArgs e)
        {
            try
            {
                Ppo = "New";
                btnPNew.Enabled = false;
                btnPUpdate.Enabled = false;
                btnPDelete.Enabled = false;
                btnPSave.Enabled = true;
                button2.Enabled = true;
                

                rbtPName.Enabled = false;
                rbtPNIC.Enabled = false;

                txtPName.Enabled = true;
                txtPNic.Enabled = true;
                txtPNC.Enabled = true;
                txtPAddress.Enabled = true;
                txtPSearch.Enabled = false;

                txtPName.Text = "";
                txtPNic.Text = "";
                txtPAddress.Text = "";
                txtPNC.Text = "";
                txtPSearch.Text = "";

                txtPNic.Focus();

            }
            catch (Exception)
            {

            }
        }

        private void btnPUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Ppo = "Update";
                btnPUpdate.Enabled = false;
                btnPNew.Enabled = false;
                btnPDelete.Enabled = false;
                btnPSave.Enabled = true;
                button2.Enabled = true;

                rbtPName.Enabled = false;
                rbtPNIC.Enabled = false;


                txtPName.Enabled = true;
                txtPNic.Enabled = false;
                txtPNC.Enabled = true;
                txtPAddress.Enabled = true;
                txtPSearch.Enabled = false;
                txtPName.Focus();


            }
            catch (Exception)
            {

            }
        }

        private void btnPDelete_Click(object sender, EventArgs e)
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

                        x = "delete from CustomerDetails where NIC ='" + (txtPNic.Text).ToString() + "'";
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

            button2_Click(button2 , e);

            txtPName.Focus();

        }

        private void txtPSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                try
                {
                    SqlCommand cmd;
                    SqlDataAdapter Pda = new SqlDataAdapter();
                    DataSet Pds = new DataSet();

                    string x;
                    if (rbtPNIC.Checked == true)
                    {
                        x = "select * from CustomerDetails where NIC like '" + (txtPSearch.Text).Trim() + "%'";

                    }
                    else if (rbtPName.Checked == true)
                    {
                        x = "select * from CustomerDetails where Name like '" + (txtPSearch.Text).Trim() + "%'";

                    }

                    else
                    {
                        x = "select * from CustomerDetails";

                    }

                    cmd = new SqlCommand(x, con);
                    Pda.SelectCommand = cmd;
                    Pda.Fill(Pds, "PARC");
                    dgvCustomer.DataSource = Pds.Tables["PARC"];
                    dgvCustomer.Refresh();



                }
                catch (Exception ex)
                {
                   // MessageBox.Show(ex.ToString());
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error...!");
            }
        }

        private void dgvCustomer_SelectionChanged(object sender, EventArgs e)
        {
            dgvCustomer.Refresh();
            txtPNic.Text = dgvCustomer.SelectedRows[0].Cells[0].Value.ToString();
            txtPName.Text = dgvCustomer.SelectedRows[0].Cells[1].Value.ToString();
            txtPNC.Text = dgvCustomer.SelectedRows[0].Cells[2].Value.ToString();
            txtPAddress.Text = dgvCustomer.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void dgvCustomer_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtNic.Text = dgvCustomer.SelectedRows[0].Cells[0].Value.ToString();
                txtName.Text = dgvCustomer.SelectedRows[0].Cells[1].Value.ToString();
                txtCN.Text = dgvCustomer.SelectedRows[0].Cells[2].Value.ToString();
                txtAddress.Text = dgvCustomer.SelectedRows[0].Cells[3].Value.ToString();

                button6_Click(button6, e);
            }
            catch(Exception ex)
            {

            }
        }

        private void cmbVehiNo_SelectedValueChanged(object sender, EventArgs e)
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
                    x = "Select Chages from Vehicale where Vehical_NO='" + cmbVehiNo.Text.Trim().ToString() + "';";

                    cmd = new SqlCommand(x, con);
                    da.SelectCommand = cmd;
                    da.Fill(ds, "ARC");
                    txtVehiCha.Text = ds.Tables["ARC"].Rows[0].ItemArray[0].ToString();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.ToString());
                }

                con.Close();
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Connection Error...! 66666");
            }
        }

        private void btnPCustLoad_Click(object sender, EventArgs e)
        {
            dgvCustomer_DoubleClick(dgvCustomer, e);
        }
    }
}
