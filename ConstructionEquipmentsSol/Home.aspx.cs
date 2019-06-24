using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using log4net;

namespace ConstructionEquipmentsSol
{
    public partial class Home : System.Web.UI.Page
    {
        private int RentalFee = 100;
        private int PremiumFee = 60;
        private int RegularFee = 40;
        private double price;
        private double TotalPrice ;
        ILog logger = log4net.LogManager.GetLogger("ErrorLog");

        protected void Page_Load(object sender, EventArgs e)
        {
            lblUserDetails.Text = "Welcome " + Session["Username"];
            lblErrorMsg.Visible = false;
            btnCart.Enabled = false;

            //SqlConnection connection = new SqlConnection();
            //SqlConnect Con = new SqlConnect();
            //connection = Con.fn_SqlConnect();
            //try
            //{
            //    //string Query = "select points from [user] where username = @Username;";
            //    //SqlCommand Sqlcmd = new SqlCommand(Query, connection);

            //    //Sqlcmd.Parameters.AddWithValue("@Username", Session["Username"]);
            //    //int count = Convert.ToInt32(Sqlcmd.ExecuteScalar());
            //    //lblCurrentPoints.Text = count.ToString();

            //    connection.Close();
            //}catch(Exception ee)
            //{
            //    throw new Exception(ee.Message);
            //}
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("index.aspx", false);
        }

        protected void BtnAddToCrt_Click(object sender, EventArgs e)
        {
            try
            {
                TotalPrice = 0;

                TotalPrice = Fn_CalculateHeavyPrice(Convert.ToDouble(TextBox1.Text)) + Fn_CalculateHeavyPrice(Convert.ToDouble(TextBox2.Text))
                    + Fn_CalculateRegularPrice(Convert.ToDouble(TextBox3.Text)) + Fn_CalculateRegularPrice(Convert.ToDouble(TextBox4.Text))
                    + Fn_CalculateSpecializedPrice(Convert.ToDouble(TextBox5.Text));

                lblCart.Text = TotalPrice.ToString();
                double heavy1 = Convert.ToDouble(TextBox1.Text);
                double heavy2 = Convert.ToDouble(TextBox2.Text);
                double regular1 = Convert.ToDouble(TextBox3.Text);
                double regular2 = Convert.ToDouble(TextBox4.Text);
                double specialized = Convert.ToDouble(TextBox5.Text);

                lblAddedPoints.Text = fn_CalculatePoints(heavy1,heavy2,regular1,regular2,specialized).ToString();
                if (TotalPrice >0)
                    btnCart.Enabled = true;
            }
            catch (Exception ex)
            {
                lblErrorMsg.Visible = true;
                logger.Info(ex.Message);
            }
        }

        public double Fn_CalculateHeavyPrice (double daysNum)
        {
            if (daysNum > 0)
            {
                price = RentalFee + (daysNum * PremiumFee);
                return price;
            }
            else return 0;
        }
        public double Fn_CalculateRegularPrice(double daysNum)
        {
            if (daysNum > 0)
            {
                if (daysNum > 2)
                {
                    double DaysOver2 = daysNum - 2;
                    price = RentalFee + (2 * PremiumFee) + (DaysOver2 * RegularFee);
                }
                else
                {
                    price = RentalFee + (daysNum * PremiumFee);
                }

                return price;
            }
            else return 0;
        }
        public double Fn_CalculateSpecializedPrice(double daysNum)
        {
            if (daysNum > 0)
            {
                if (daysNum > 3)
                {
                    double DaysOver3 = daysNum - 3;
                    price = (3 * PremiumFee) + (DaysOver3 * RegularFee);
                }
                else
                {
                    price = daysNum * PremiumFee;
                }

                return price;
            }
            else return 0;
        }
        public int fn_CalculatePoints(double heavy1, double heavy2, double regular1, double regular2, double specialized)
        {
            int points = 0;
            if (heavy1 > 0)
                points = points + 2;
            if (heavy2 > 0)
                points = points + 2;
            if (regular1 > 0)
                points = points + 1;
            if (regular2 > 0)
                points = points + 1;
            if (specialized > 0)
                points = points + 1;

            return points;
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            lblAddedPoints.Text = "0";
            lblCart.Text = "0";
            TextBox1.Text = "0";
            TextBox2.Text = "0";
            TextBox3.Text = "0";
            TextBox4.Text = "0";
            TextBox5.Text = "0";
            btnCart.Enabled = false;
        }

        protected void btnCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cart.aspx", false);

            //Session["CurrPoints"] = lblCurrentPoints.Text;
            Session["AddedPoints"] = lblAddedPoints.Text;
            Session["TotalPrice"] = lblCart.Text;
            Session["H1NumDays"] = TextBox1.Text;
            Session["H1Price"] = Fn_CalculateHeavyPrice(Convert.ToDouble( TextBox1.Text));
            Session["H2NumDays"] = TextBox2.Text;
            Session["H2Price"] = Fn_CalculateHeavyPrice(Convert.ToDouble(TextBox2.Text));
            Session["R1NumDays"] = TextBox3.Text;
            Session["R1Price"] = Fn_CalculateRegularPrice(Convert.ToDouble(TextBox3.Text));
            Session["R2NumDays"] = TextBox4.Text;
            Session["R2Price"] = Fn_CalculateRegularPrice(Convert.ToDouble(TextBox4.Text));
            Session["SNumDays"] = TextBox5.Text;
            Session["SPrice"] = Fn_CalculateSpecializedPrice(Convert.ToDouble(TextBox5.Text));


        }
    }
}