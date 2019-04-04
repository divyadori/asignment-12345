using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace divya
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        webservice.WebService1 cal = new webservice.WebService1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        

        protected void btnadd_Click(object sender, EventArgs e)
        {
            lblresult.Text = cal.Add(Convert.ToInt16(txt1.Text), Convert.ToInt16(txt2.Text)).ToString();
        }
      
        
        
        protected void btnsub_Click1(object sender, EventArgs e)
        {
            lblresult.Text = cal.Sub(Convert.ToInt16(txt1.Text), Convert.ToInt16(txt2.Text)).ToString();
        }

        protected void btnmul_Click1(object sender, EventArgs e)
        {
            lblresult.Text = cal.Mul(Convert.ToInt16(txt1.Text), Convert.ToInt16(txt2.Text)).ToString();
        }

        protected void btndiv_Click1(object sender, EventArgs e)
        {
            lblresult.Text = cal.Div(Convert.ToInt16(txt1.Text), Convert.ToInt16(txt2.Text)).ToString();
        }
    }
}