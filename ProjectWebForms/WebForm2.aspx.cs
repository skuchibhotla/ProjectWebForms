using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectWebForms.ServiceReference1;

namespace ProjectWebForms
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        Service1Client sc = new Service1Client();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int customerid = Convert.ToInt32(TextBox1.Text);
            string customername = TextBox2.Text;
            string address = TextBox3.Text;
            int employeeid = Convert.ToInt32(TextBox4.Text);
            sc.AddCustomer(customerid, customername, address, employeeid);
            Response.Redirect("Webform1.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int customerid = Convert.ToInt32(TextBox1.Text);
            string customername = TextBox2.Text;
            string address = TextBox3.Text;
            int employeeid = Convert.ToInt32(TextBox4.Text);
            //sc.EditCustomer(customerid, customername, address);
            Response.Redirect("Webform1.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int customerid = Convert.ToInt32(TextBox1.Text);
            sc.DeleteCustomer(customerid);
            Response.Redirect("Webform1.aspx");
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}