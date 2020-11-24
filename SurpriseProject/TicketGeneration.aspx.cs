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
    public partial class TicketGeneration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["TicketConnectionString"].ConnectionString);
            conn.Open();
            var insertquery = "insert into TicketTable1(PassengerName,Age,Gender,PassengerClassTickets,Source,Destination) values(@PN,@A,@G,@PCT,@S,@D)";
            SqlCommand cmd = new SqlCommand(insertquery, conn);
            cmd.Parameters.AddWithValue("@PN", TextBox1.Text);
            cmd.Parameters.AddWithValue("@A", TextBox2.Text);
           
            if (rdb1.Checked)
            {
                cmd.Parameters.AddWithValue("@G", rdb1.Text);
            }
            else
            {
                cmd.Parameters.AddWithValue("@G", rdb2.Text);
            }
            if(RadioButtonList1.SelectedIndex > -1)
            {
                cmd.Parameters.AddWithValue("@PCT", RadioButtonList1.SelectedItem.Text);
            }
            cmd.Parameters.AddWithValue("@S", TextBox3.Text);
            cmd.Parameters.AddWithValue("@D", TextBox4.Text);
            int affectedrows = cmd.ExecuteNonQuery();
            conn.Close();
            Label1.Text = "Ticket Generated Successfully";
            Response.Redirect("Output.aspx");
        }

    }
}
