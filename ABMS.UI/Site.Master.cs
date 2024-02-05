using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ABMS.UI
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Name"] == null)
            {
                lnkLogin.Text = "Login";
                lnkLogOut.Visible = false;
                lnkRegister.Visible = true;
            }
            else
            {
                lnkLogin.Text = Session["Name"].ToString();
                lnkLogOut.Visible = true;
                lnkRegister.Visible = false;
            }
        }

        protected void lnkLogin_Click(object sender, EventArgs e)
        {
            if (Session["Name"] == null)
            {
                Response.Redirect("~/Account/Login.aspx");
            }
        }

        protected void lnkLogOut_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.Clear();
        }

        protected void lnkRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Account/Register.aspx");
        }


    }
}
