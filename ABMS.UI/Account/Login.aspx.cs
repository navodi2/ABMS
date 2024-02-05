using System;
using System.Data;
namespace ABMS.UI.Account
{
    public partial class Login : System.Web.UI.Page
    {
        ABMS.BL.BLLogin objBL = new ABMS.BL.BLLogin();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            ABMS.BE.BELogin obJBE = new BE.BELogin();
            obJBE.UserId = UserName.Text.Trim();
            obJBE.Password = Password.Text.Trim();
            DataSet ds = new DataSet();
            ds = objBL.UserLogin(obJBE);
            if (ds.Tables.Count == 1)
            {
                lblErrorMsg.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else if (ds.Tables[1].Rows[0][0].ToString() == "1")
            {
                lblErrorMsg.Text = string.Empty;
                Session["UserId"] = ds.Tables[0].Rows[0][0].ToString();
                String name=null;
                if (!string.IsNullOrEmpty( ds.Tables[0].Rows[0][1].ToString()))
                {
                    name = name + ds.Tables[0].Rows[0][1].ToString();
                }
                if (!string.IsNullOrEmpty(ds.Tables[0].Rows[0][2].ToString()))
                {
                    name = name +" "+ ds.Tables[0].Rows[0][2].ToString();
                }
                if (!string.IsNullOrEmpty(ds.Tables[0].Rows[0][3].ToString()))
                {
                    name = name + " "+ds.Tables[0].Rows[0][3].ToString();
                }
                Session["Name"] = name;
                Response.Redirect("~/Default.aspx");

            }
        }

        
    }
}
