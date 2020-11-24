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
    public partial class UserData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UserConnectionString"].ConnectionString);
            conn.Open();
            var insertquery = "insert into UserData1(UserName,Password,ConfirmPassword,Age,Gender) values(@U,@P,@CP,@A,@G)";
            SqlCommand cmd = new SqlCommand(insertquery,conn);
            cmd.Parameters.AddWithValue("@U", TextBox1.Text);
            cmd.Parameters.AddWithValue("@P", TextBox2.Text);
            cmd.Parameters.AddWithValue("@CP", TextBox3.Text);
            cmd.Parameters.AddWithValue("@A", TextBox4.Text);
       if(Rdb1.Checked)
            {
                cmd.Parameters.AddWithValue("@G", Rdb1.Text);
            }
            else
            {
                cmd.Parameters.AddWithValue("@G", Rdb2.Text);
            }
            int affectedrows = cmd.ExecuteNonQuery();
            conn.Close();
            lbl1.Text = "You have Registered Successfully";

        }

        protected void Btn2_Click(object sender, EventArgs e)
        {
            Response.Redirect("FlightDetails.aspx");
        }
    }
}