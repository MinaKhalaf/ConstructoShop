using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace ConstructionEquipmentsSol
{
    public partial class Cart : System.Web.UI.Page
    {
        public string Invoice = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            lblUserDetails.Text = "Welcome " + Session["Username"];
            string H1Text="", H2Text ="",R1Text ="",R2Text ="",SText="";

            if (Convert.ToDouble( Session["H1Price"]) >0)
            {
                H1Text = "* Caterpillar bulldozer for " + Session["H1NumDays"] + " days = "+ Session["H1Price"] + " €";
            }
            if (Convert.ToDouble(Session["H2Price"]) > 0)
            {
                H2Text = "* Komatsu crane for " + Session["H2NumDays"] + " days = " + Session["H2Price"] + " €";
            }
            if (Convert.ToDouble(Session["R1Price"]) > 0)
            {
                R1Text = "* KamAZ truck for " + Session["R1NumDays"] + " days = " + Session["R1Price"] + " €";
            }
            if (Convert.ToDouble(Session["R2Price"]) > 0)
            {
                R2Text = "* Volvo steamroller for " + Session["R2NumDays"] + " days = " + Session["R2Price"] + " €";
            }
            if (Convert.ToDouble(Session["SPrice"]) > 0)
            {
                SText = "* Bosch jackhammer for " + Session["SNumDays"] + " days = " + Session["SPrice"] + " €";
            }

            int totalpoints = Convert.ToInt32(Session["CurrPoints"]) + Convert.ToInt32(Session["AddedPoints"]);

            Invoice = "Constructo Shop " + "\r\n"
                + H1Text + "\t\t"
                + H2Text + "\r\n"
                + R1Text + "\t\t"
                + R2Text + "\r\n"
                + SText + "\r\n"
                + "Total Price : " + Session["TotalPrice"] + "\r\n"
                + "Points will be added to your account : " + Session["AddedPoints"] + "\r\n";

            lblInvoice.Text = H1Text + " &nbsp &nbsp " + H2Text  + "<br />" + R1Text + " &nbsp &nbsp " + R2Text  + "<br />" +SText
                + "<br />" + "Total price : " + Session["TotalPrice"]
                + "<br />" +"New added points : "+ Session["AddedPoints"];

        }
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("index.aspx", false);
        }

        protected void GetInvoice_Click(object sender, EventArgs e)
        {
            var t = new Thread((ThreadStart)(() => {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:\";      
            saveFileDialog1.Title = "Save text Files";

            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFileDialog1.OpenFile());
                writer.WriteLine(Invoice);
                writer.Dispose();
                writer.Close();
            }
            }));

            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx", false);
        }
    }
}