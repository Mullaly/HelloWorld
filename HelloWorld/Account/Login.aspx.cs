using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.SessionState;

namespace HelloWorld.Account
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Username = null;
            RegisterHyperLink.NavigateUrl = "Register.aspx?ReturnUrl=" + HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            if (Session.Count > 0) Username = Session["UserName"].ToString();
            if (Username == "Murali")
            {
                Response.Write("Session Validated");
            }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            Session["UserName"] = LoginUser.UserName.ToString();
            Response.Write(LoginUser.UserName.ToString());
        }
    }
}
