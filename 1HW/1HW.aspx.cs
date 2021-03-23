using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1HW
{
    public partial class prime : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int num = 12;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    Response.Write(num + "不是質數");
                    break;
                }
                else
                {
                    Response.Write(num + "是質數");
                    break;
                }
            }
        }
    }
}