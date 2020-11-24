using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace SurpriseProject
{
    public partial class Output : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FlightConnectionString"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from FlightTable Where Source=@source AND Destination = @destination",con );
            cmd.Parameters.AddWithValue("@source", TextBox6.Text);
            cmd.Parameters.AddWithValue("@destination", TextBox7.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.HasRows)
            {
                Response.Write("Ticket has generated as per the details: ");
                SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["OutputConnectionString"].ConnectionString);
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("insert into OutputTable1 values(@fid,@fno,@fname,@pname,@age,@g,@source,@destination",con1);
                cmd1.Parameters.AddWithValue("@fid", TextBox1.Text);
                cmd1.Parameters.AddWithValue("@fno", TextBox2.Text);
                     cmd1.Parameters.AddWithValue("@fname", TextBox3.Text);
                cmd1.Parameters.AddWithValue("@pname", TextBox4.Text);
                cmd1.Parameters.AddWithValue("@age", TextBox5.Text);
                if (rdb1.Checked)
                {
                    cmd.Parameters.AddWithValue("@g", rdb1.Text);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@g", rdb2.Text);
                }
                cmd1.Parameters.AddWithValue("@source", TextBox6.Text);
                cmd1.Parameters.AddWithValue("@destination", TextBox7.Text);
                con.Close();
                Response.Write("<br>FlightID = " + TextBox1.Text);
                Response.Write("<br>FlightNumber = " + TextBox2.Text);
                Response.Write("<br>FlightName = " + TextBox3.Text);
                Response.Write("<br>PassengerName = " + TextBox4.Text);
                Response.Write("<br>Age = " + TextBox5.Text);
                if (rdb1.Checked)
                {
                    Response.Write("<br>Gender = " + rdb1.Text);
                }
                else
                {
                    Response.Write("<br>Gender = " + rdb2.Text);
                }
                Response.Write("<br>Source= " + TextBox6.Text);
                Response.Write("<br>Destination = " + TextBox7.Text);
            }
        }
        protected void btn2_Click(object sender, EventArgs e)
        {
            Response.Redirect("FlightDetails.aspx");
        }
    }
}