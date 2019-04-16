using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIAV_WebForm
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie myHttpCookie = new HttpCookie("LastVisit", DateTime.Now.ToString());
            myHttpCookie.Name = "MyHttpCookie";
            Response.AppendCookie(myHttpCookie);
            Response.Write(myHttpCookie.Name);

            // Create an HttpOnly cookie.
            HttpCookie myHttpOnlyCookie = new HttpCookie("LastVisit", DateTime.Now.ToString());
            myHttpOnlyCookie.HttpOnly = true;
            myHttpOnlyCookie.Name = "MyHttpOnlyCookie";
            Response.AppendCookie(myHttpOnlyCookie);
            Response.Write(myHttpOnlyCookie.Name);

            HttpCookie myHttpSecureCookie = new HttpCookie("LastVisit", DateTime.Now.ToString());
            myHttpSecureCookie.Secure = true;
            myHttpSecureCookie.Name = "MyHttpSecureCookie";
            Response.AppendCookie(myHttpSecureCookie);
            Response.Write(myHttpSecureCookie.Name);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.Label1.Text = this.DropDownList1.SelectedItem.Value;
        }
    }
}