using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using log4net;
using System.IO;
using System.Net;
using System.Diagnostics;
using Accounts;

namespace ConstructionEquipmentsSol
{
    public partial class Login : System.Web.UI.Page
    {
        ILog logger = log4net.LogManager.GetLogger("ErrorLog");
        protected void Page_Load(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection();
            //SqlConnect Con = new SqlConnect();
            //connection = Con.fn_SqlConnect();
            try
            {
                //string Query = "select count (*) from [User] where username = @Username and Password = @Passw0rd;";
                //SqlCommand Sqlcmd = new SqlCommand(Query, connection);

                //Sqlcmd.Parameters.AddWithValue("@Username",txtUsername.Text.Trim());
                //Sqlcmd.Parameters.AddWithValue("@Passw0rd", txtPassword.Text.Trim());
                //int count = Convert.ToInt32(Sqlcmd.ExecuteScalar());
                Account A = new Accounts.Account();
                bool Usr = A.Fn_ValidateUser(txtUsername.Text.ToLower().Trim(), txtPassword.Text.ToLower().Trim());
                
                if (Usr == true)
                {
                    Session["Username"] = txtUsername.Text.Trim();
                    Response.Redirect("Home.aspx",false);
                    //connection.Close();
                    logger.Info("Happy logging!");
                }
                else
                {
                    lblErrorMessage.Visible = true;
                    logger.Info("Invalid User!");
                }

            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
                logger.Info(ex.Message);
            }
           

        }
    }
}