using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace test_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HP\Desktop\Sem 4\Dot Net\Login Form (Test_1)\test_2\test_2\App_Data\Database1.mdf"";Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        public void display()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from form";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            Gridview1.DataSource= dt;
            Gridview1.DataBind();
        }

        protected void view_btn_Click(object sender, EventArgs e)
        {
            display();
            Response.Write("View button clicked");
        }

        protected void insert_btn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into form values('"+name_txt.Text+"','"+dep_txt.Text+"','"+prn_txt.Text+"')";
            cmd.ExecuteNonQuery();
            name_txt.Text = "";
            dep_txt.Text = "";
            prn_txt.Text = "";
            display();
        }

        protected void delete_btn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from form where Name='" + name_txt.Text + "'";
            cmd.ExecuteNonQuery();
            name_txt.Text = "";
            display();
        }
    }
}