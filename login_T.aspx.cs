using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login_T : System.Web.UI.Page
{

    string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * FROM  UserLogin WHERE UserName = @UserName AND Password = @Password", con);
                cmd.Parameters.AddWithValue("@UserName", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", TextBox2.Text.Trim());

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Response.Write("<script> alert('Login Successfull');</script>");
                        Session["username"] = dr.GetValue(2).ToString();
                        Session["UserID"] = dr.GetValue(0).ToString();
                        Session["Userrole"] = dr.GetValue(1).ToString(); ;
                        //Session["status"] = dr.GetValue(10).ToString();
                    }
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    Response.Write("<script> alert('Invalid Credential');</script>");
                }
            }
        }
        catch (Exception ex)
        {
            // Handle the exception (log it and show a user-friendly message)
            Response.Write("<script> alert('" + ex.Message + "');</script>");
        }
    }

    //user defined function

}