using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectWebForms.ServiceReference1;

namespace ProjectWebForms
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Service1Client sc = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = sc.GetEmployee();
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = sc.GetCustomer();
            GridView1.DataBind();
        }
    }
}