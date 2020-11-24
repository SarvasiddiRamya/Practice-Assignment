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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["UserConnectionString"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from UserData1 where UserName = @Uname AND Password = @pwd",con);
            cmd.Parameters.AddWithValue("@Uname", TextBox1.Text);
            cmd.Parameters.AddWithValue("@pwd", TextBox2.Text);

            int affectedrows = cmd.ExecuteNonQuery();
            con.Close();
            lbl1.Text = "Login Successfully";
            Response.Redirect("TicketGeneration.aspx");
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            Response.Redirect("FlightDetails.aspx");
        }
    }
}