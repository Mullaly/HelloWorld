using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorld
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        static int siteCounter = 0;
        private static readonly Object lockobj = new Object();

        protected void Page_Init(object sender, EventArgs e)
        {
            
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            ++siteCounter;
            lock (lockobj)
            {
                SiteCount.Text = siteCounter.ToString(); 
            }
            Response.Write("This Site has been visited" + siteCounter.ToString() + " times");
        }
    }
}
