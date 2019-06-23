using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

using System.IO;
using System.Net;
using System.Diagnostics;

namespace ConstructionEquipmentsSol
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            SqlConnect Con = new SqlConnect();
            connection = Con.fn_SqlConnect();
            try
            {
                string Query = "select count (*) from [User] where username = @Username and Password = @Passw0rd;";
                SqlCommand Sqlcmd = new SqlCommand(Query, connection);

                Sqlcmd.Parameters.AddWithValue("@Username",txtUsername.Text.Trim());
                Sqlcmd.Parameters.AddWithValue("@Passw0rd", txtPassword.Text.Trim());
                int count = Convert.ToInt32(Sqlcmd.ExecuteScalar());

                if (count == 1)
                {
                    Session["Username"] = txtUsername.Text.Trim();
                    Response.Redirect("Home.aspx",false);
                    connection.Close();
                }
                else
                {
                    lblErrorMessage.Visible = true;
                }

            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
           

        }
    }
}