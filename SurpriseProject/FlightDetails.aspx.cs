using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace SurpriseProject
{
    public partial class FlightDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
     
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["FlightConnectionString"].ConnectionString);
            connect.Open();
            var insertquery = "insert into FlightTable(FlightID,FlightNumber,FlightName,Source,Destination) values(@ID,@Number,@Name,@source,@destination)";
            SqlCommand cmd = new SqlCommand(insertquery, connect);
            cmd.Parameters.AddWithValue("@ID", TextBox1.Text);
            cmd.Parameters.AddWithValue("@Number", TextBox2.Text);
            cmd.Parameters.AddWithValue("@Name", TextBox3.Text);
            cmd.Parameters.AddWithValue("@source", TextBox4.Text);
            cmd.Parameters.AddWithValue("@Destination", TextBox5.Text);
            int affectedrows = cmd.ExecuteNonQuery();
            if (affectedrows > 0)
            {
                Label1.Text = "Flight Details Added Successfully";
            }
            else
            {
                Label1.Text = "Check your data";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserData.aspx");
        }
    }
}