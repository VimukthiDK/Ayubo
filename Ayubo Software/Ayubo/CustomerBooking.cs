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
    public partial class CustomerBooking : Form
    {
        public CustomerBooking()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Server= localhost; Database= AyuboDriveDatabase;Integrated Security = SSPI;");
        String po = null;


        string Ppo = null;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CustomerBooking_Load(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                try
                {
                    SqlCommand cmd = new SqlCommand("Select * from Package", con);
                    SqlDataReader x = cmd.ExecuteReader();

                    cmbHPack.Items.Clear();
                    while (x.Read())
                    {
                        cmbHPack .Items.Add(x["Package_Type"]);

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

        private void cmbHPack_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbHPack_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {
                con.Open();

                try
                {
                    SqlCommand cmd = new SqlCommand("Select * from Package where Package_Type = '" + (cmbPack.Text).Trim().ToString() + "';", con);
                    SqlDataReader x = cmd.ExecuteReader();

                    cmbVType.Text = "";
                    cmbVType.Items.Clear();
                    cmbVType.Text = "";
                    txtVehiCha.Text = "0.0";

                    cmbVType.Items.Clear();
                    while (x.Read())
                    {
                        cmbVType.Items.Add(x["Vehical_Type"]);

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

        private void cmbVType_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                try
                {
                    SqlCommand cmd = new SqlCommand("Select * from Vehicale where Vehical_Type = '" + (cmbVehiType.Text ).Trim().ToString() + "';", con);
                    SqlDataReader x = cmd.ExecuteReader();

                    cmbVNo.Items.Clear();
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
    }
}
